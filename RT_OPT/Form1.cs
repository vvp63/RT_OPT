using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RT_OPT
{
    public partial class MainForm : Form
    {

        SqlConnection gConn = new SqlConnection();

        string gTriFile = "";
        string gLogFile = "";
        string gSetOrderStr = "";
        string gDropOrderStr = "";
        int gRequoteInterval = 3000;


        public MainForm()
        {
            InitializeComponent();
        }

        private void TextLog(string aLogStr, params object[] aParams)
        {
            tbLog.AppendText(string.Format(aLogStr, aParams) + "\r\n");
        }

        private void FileLog(string aLogStr, params object[] aParams)
        {
            TextLog(aLogStr, aParams);
            string vLogFileName = RT_OPT.Properties.Settings.Default.LogFile.ToString();
            System.IO.File.AppendAllText(vLogFileName,
                string.Format("{0}  {1}\r\n", DateTime.Now.ToString("dd.MM.yyyy hh:mm:ss.ff"), string.Format(aLogStr, aParams)));
        }

        private void Form_Load(object sender, EventArgs e)
        {
            gConn.ConnectionString = RT_OPT.Properties.Settings.Default.RT_OPTConnectionString;
            gConn.Open();
            TextLog("Connection status {0}", gConn.State);
            LoadSettings();
            this.tPTableAdapter.Fill(this.rT_OPTDataSet.TP);
        }

        private void bApply_Click(object sender, EventArgs e)
        {
            this.tPTableAdapter.Update(this.rT_OPTDataSet.TP);
            if (!cbOnlyActive.Checked)
                this.tPTableAdapter.Fill(this.rT_OPTDataSet.TP);
            else
                this.tPTableAdapter.FillBy_Active(this.rT_OPTDataSet.TP);
             
        }



        //   возвращаем флаг - находимся ли внутри торгового интервала
        private bool IsInDay(bool IsHedge   =   false)
        {
            bool vResult = false;
            if (gConn.State == ConnectionState.Open)
            {
                SqlCommand vSqlCommand = new SqlCommand(IsHedge ? "exec IsInHedgeInterval" : "exec IsInInterval", gConn);
                SqlDataReader vReader = vSqlCommand.ExecuteReader();
                while (vReader.Read()) vResult = (vResult) || (Convert.ToInt32(vReader[0]) > 0);
                vReader.Close();
            }
            return vResult;
        }



        private void LoadingState(object sender, EventArgs e)
        {
            this.tPQuotingTableAdapter.Fill(this.rT_OPTDataSet.TPQuoting);
            this.activeOrdersTableAdapter.Fill(this.rT_OPTDataSet.ActiveOrders);
            ProcessingTPS();
        }



        private void ProcessingTPS()
        {
            bool vIsInDay = IsInDay();
            bool vIsInHedgeDay = IsInDay(true);

            //  Перебираем пары
            for (int j = 0; j < dgv_TPQuote.RowCount; j++)
            {
                string vName = "";
                string vBaseCode = ""; int vBaseQty = 0; float vBid1 = 0; float vAsk1 = 0;
                string vAddCode = ""; int vAddQty = 0; float vBid2 = 0; float vAsk2 = 0;
                float vBuyPrice = 0; int vBuyQty = 0; float vSellPrice = 0; int vSellQty = 0;
                float vDiffMove = 0; float vDiffBefore = 0;
                int vTPId = GetTpParams(j, out vName,
                                        out vBaseCode, out vBaseQty, out vBid1, out vAsk1,
                                        out vAddCode, out vAddQty, out vBid2, out vAsk2,
                                        out vBuyPrice, out vBuyQty, out vSellPrice, out vSellQty, 
                                        out vDiffMove, out vDiffBefore);
                FileLog("---QUOTE {0} {1} {2}", j, vTPId, vName);
                if (vTPId > 0)
                {
                    if (HedgingTP(vTPId, vIsInHedgeDay, vBaseQty, vAddQty, vAddCode, vBid2, vAsk2))
                        QuotingTP(vTPId, vIsInDay && cbAllowTrade.Checked, vBaseCode, vBid1, vAsk1,
                            vBuyPrice, vBuyQty, vSellPrice, vSellQty, vDiffMove, vDiffBefore);
                }

            }           

        }



        private bool HedgingTP(int aTPId, bool aInHedgeDay, int aBaseQty, int aAddQty, string aAddCode, float aBid, float aAsk)
        {
            bool vHasActive = false; bool vHedged = (aBaseQty == aAddQty);
            FileLog("   HedgingTP {0} {1} {2}:{3} {4} ({5}-{6})", aTPId, aInHedgeDay, aBaseQty, aAddQty, aAddCode, aBid, aAsk);
            //  Перебираем заявки, все что хеджирующее - снимаем если можем
            for (int j = 0; j < dgv_Orders.RowCount; j++)
            {
                int vTransId; int vTPId; string vQuoteHedge; DateTime vDateTime;
                string vCode; string vOperation; float vPrice; int vQty; int vRest; int vQBT;
                long vOrderid = GetOrderParams(j, out vTransId, out vTPId, out vQuoteHedge, out vDateTime,
                                                out vCode, out vOperation, out vPrice, out vQty, out vRest, out vQBT);

                if ((vTPId == aTPId) && (vQuoteHedge == "H") )
                {
                    FileLog("       HasActiveHedgeOrder {0} {1} {2} {3} {4}/{5} [{6}, {7}]", vTransId, vOrderid, vCode, vOperation, vPrice, vQty, vRest, vQBT);
                    //  Есть активная хедж-заявка - нужно снимать
                    vHasActive = true;
                    if ( (vOrderid > 0) && (vCode == aAddCode) ) DropOrder(aTPId, aAddCode, vOrderid);
                }
            }

            if ((!vHasActive) && (!vHedged) && aInHedgeDay)
            {
                //  Нужно хеджировать и нет активных заявок
                string vOperation = (aBaseQty > aAddQty) ? "B" : "S";
                float vPrice = (aBaseQty > aAddQty) ? aAsk : aBid;
                int vQty = Math.Abs(aBaseQty - aAddQty);
                FileLog("       Need Hedge {0} {1} {2} {3}/{4}", aTPId, aAddCode, vOperation, vPrice, vQty);
                if ((vPrice > 0) && (vQty > 0)) SetOrder(aTPId, aAddCode, vOperation, "H", vPrice, vQty);
            }

            return vHedged && (!vHasActive);
        }



        private void QuotingTP(int aTPId, bool aInDay, string aBaseCode, float aBid, float aAsk,   
                                    float aBuyPrice, int aBuyQty, float aSellPrice, int aSellQty, float aDiffMove, float aDiffBefore)
        {
            FileLog("   QuotingTP {0} {1} {2}   B: {3}/{4}   S: {5}/{6}  {7} {8} ",
                            aTPId, aInDay, aBaseCode, aBuyPrice, aBuyQty, aSellPrice, aSellQty, aDiffMove, aDiffBefore);
            //  Перебираем котирующие заявки, что не нужно - снимаем
            bool vBexist = false; bool vSexist = false;
            for (int j = 0; j < dgv_Orders.RowCount; j++)
            {
                int vTransId; int vTPId; string vQuoteHedge; DateTime vDateTime;
                string vCode; string vOperation; float vPrice; int vQty; int vRest; int vQBT;
                long vOrderid = GetOrderParams(j, out vTransId, out vTPId, out vQuoteHedge, out vDateTime,
                                                out vCode, out vOperation, out vPrice, out vQty, out vRest, out vQBT);

                if ((vTPId == aTPId) && (vQuoteHedge == "Q"))
                {
                    FileLog("       HasActiveQuotingOrder {0} {1} {2} {3} {4}/{5} [{6}, {7}]", vTransId, vOrderid, vCode, vOperation, vPrice, vQty, vRest, vQBT);
                    bool vDropByPrice = false;
                    if (vOperation == "B")
                    {
                        vBexist = true;
                        if ( (Math.Abs(vPrice - aBuyPrice) > aDiffMove) || (aBuyQty == 0) ) vDropByPrice = true;
                    }
                    if (vOperation == "S")
                    {
                        vSexist = true;
                        if ( (Math.Abs(vPrice - aSellPrice) > aDiffMove) || (aSellQty == 0) ) vDropByPrice = true;
                    }
                    if ((!aInDay) || (vDropByPrice))
                    {
                        //  Есть активная котировочная заявка - нужно снимать
                        FileLog("       Need to drop {0} {1}", aInDay, vDropByPrice);
                        if ((vOrderid > 0) && (vCode == aBaseCode)) DropOrder(aTPId, aBaseCode, vOrderid);
                    }
                }
            }
            //  TODO : Quoting!
            FileLog("   Setting quoting {0}     Buy:{1} Bell:{2}", aInDay, vBexist, vSexist);
            if (aInDay)
            {
                if ((!vBexist) && (aBuyPrice > 0) && (aBuyQty > 0))
                {
                    FileLog("       Need set Quoting buy {0} {1}/{2} (Best Bid={3})", aBaseCode, aBuyPrice, aBuyQty, aBid);
                    if ( (aBid - aBuyPrice) <= aDiffBefore) SetOrder(aTPId, aBaseCode, "B", "Q", aBuyPrice, aBuyQty);
                }
                if ((!vSexist) && (aSellPrice > 0) && (aSellQty > 0))
                {
                    FileLog("       Need set Quoting sell {0} {1}/{2} (Best Ask={3})", aBaseCode, aSellPrice, aSellQty, aAsk);
                    if ((aSellPrice - aAsk) <= aDiffBefore) SetOrder(aTPId, aBaseCode, "S", "Q", aSellPrice, aSellQty);
                }
            }

        }



        private int GetTpParams(int i, out string aName,
                                out string aBaseCode, out int aBaseQty, out float aBid1, out float aAsk1,
                                out string aAddCode, out int aAddQty, out float aBid2, out float aAsk2,
                                out float aBuyPrice, out int aBuyQty, out float aSellPrice, out int aSellQty, 
                                out float aDiffMove, out float aDiffBefore)   
        {
            int vTPId = 0;
            int.TryParse(dgv_TPQuote.Rows[i].Cells[0].Value.ToString(), out vTPId);
            aName = dgv_TPQuote.Rows[i].Cells[1].Value.ToString();

            aBaseCode = dgv_TPQuote.Rows[i].Cells[2].Value.ToString();
            int.TryParse(dgv_TPQuote.Rows[i].Cells[3].Value.ToString(), out aBaseQty);
            float.TryParse(dgv_TPQuote.Rows[i].Cells[4].Value.ToString(), out aBid1);
            float.TryParse(dgv_TPQuote.Rows[i].Cells[5].Value.ToString(), out aAsk1);

            aAddCode = dgv_TPQuote.Rows[i].Cells[6].Value.ToString();
            int.TryParse(dgv_TPQuote.Rows[i].Cells[7].Value.ToString(), out aAddQty);
            float.TryParse(dgv_TPQuote.Rows[i].Cells[8].Value.ToString(), out aBid2);
            float.TryParse(dgv_TPQuote.Rows[i].Cells[9].Value.ToString(), out aAsk2);

            float.TryParse(dgv_TPQuote.Rows[i].Cells[10].Value.ToString(), out aBuyPrice);
            int.TryParse(dgv_TPQuote.Rows[i].Cells[11].Value.ToString(), out aBuyQty);
            float.TryParse(dgv_TPQuote.Rows[i].Cells[12].Value.ToString(), out aSellPrice);   
            int.TryParse(dgv_TPQuote.Rows[i].Cells[13].Value.ToString(), out aSellQty);
            float.TryParse(dgv_TPQuote.Rows[i].Cells[14].Value.ToString(), out aDiffMove);
            float.TryParse(dgv_TPQuote.Rows[i].Cells[15].Value.ToString(), out aDiffBefore);
            return vTPId;
        }


        private long GetOrderParams(int i, out int aTransId, out int aTPId, out string aQuoteHedge, out DateTime aOrderTime,
                                    out string aCode, out string aOperation, out float aPrice, out int aQty, out int aRest, out int aQBT)
        {
            long vOrderId = -1;
            long.TryParse(dgv_Orders.Rows[i].Cells[3].Value.ToString(), out vOrderId);
            int.TryParse(dgv_Orders.Rows[i].Cells[0].Value.ToString(), out aTransId);
            int.TryParse(dgv_Orders.Rows[i].Cells[1].Value.ToString(), out aTPId);
            aQuoteHedge = dgv_Orders.Rows[i].Cells[2].Value.ToString();
            DateTime.TryParse(dgv_Orders.Rows[i].Cells[4].Value.ToString(), out aOrderTime);
            aCode = dgv_Orders.Rows[i].Cells[5].Value.ToString();
            aOperation = dgv_Orders.Rows[i].Cells[6].Value.ToString();
            float.TryParse(dgv_Orders.Rows[i].Cells[7].Value.ToString(), out aPrice);
            int.TryParse(dgv_Orders.Rows[i].Cells[8].Value.ToString(), out aQty);
            int.TryParse(dgv_Orders.Rows[i].Cells[9].Value.ToString(), out aRest);
            int.TryParse(dgv_Orders.Rows[i].Cells[10].Value.ToString(), out aQBT);

            return vOrderId;
        }

        private void QuoteByTimer(object sender, EventArgs e)
        {
            LoadingState(sender, e);
        }

        private void StartStopTimer(object sender, EventArgs e)
        {
            timer_Requote.Enabled = cbAutoreload.Checked;
        }

        private void fillBy_ActiveToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tPTableAdapter.FillBy_Active(this.rT_OPTDataSet.TP);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }




    
    }



}
