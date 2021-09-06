using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace RT_OPT
{
    public partial class MainForm : Form
    {

        // Working with Orders 

        private int SetDropOrderDB(int vTPId, string vAction, string vCode, string vOperation, string vQuoteHedge, float vPrice, int vQuantity, long vOrderNo   =   -1)
        {
            int vResult = -1;
            if (gConn.State == ConnectionState.Open)
            {
                SqlCommand vSqlCommand = new SqlCommand(string.Format("exec New_Transaction {0}, '{1}', '{2}', '{3}', '{4}', {5}, {6}, {7}",
                                         vTPId, vAction, vCode, vOperation, vQuoteHedge, vPrice.ToString().Replace(',', '.'), vQuantity, vOrderNo), gConn);
                SqlDataReader vReader = vSqlCommand.ExecuteReader();
                while (vReader.Read()) vResult = Convert.ToInt32(vReader[0]);
                vReader.Close();
            }
            return vResult;
        }


        private void SetOrder(int vTPId, string vCode, string vOperation, string vQuoteHedge, float vPrice, int vQuantity)
        {
            string vTriFileName = RT_OPT.Properties.Settings.Default.TriFile.ToString();
            if (System.IO.File.Exists(vTriFileName))
            {
                int vTransId = SetDropOrderDB(vTPId, "S", vCode, vOperation, vQuoteHedge, vPrice, vQuantity, -1);
                if (vTransId > 0)
                {
                    string vSetOrderStr = string.Format(RT_OPT.Properties.Settings.Default.SetOrderStr, vTransId, vCode, vOperation, vPrice, vQuantity);
                    FileLog("SetOrderStr = {0}", vSetOrderStr);
                    System.IO.File.AppendAllText(vTriFileName, vSetOrderStr + "\r\n");
                }
            }
            else FileLog("Tri file does not exists {0}", vTriFileName);
        }

        private void DropOrder(int vTPId, string vCode, long vOrderNo)
        {
            string vTriFileName = RT_OPT.Properties.Settings.Default.TriFile.ToString();
            if (System.IO.File.Exists(vTriFileName))
            {
                int vTransId = SetDropOrderDB(vTPId, "D", vCode, "", "", 0, 0, vOrderNo);
                if (vTransId > 0)
                {
                    string vDropOrderStr = string.Format(RT_OPT.Properties.Settings.Default.DropOrderStr, vTransId, vCode, vOrderNo);
                    FileLog("DropOrderStr = {0}", vDropOrderStr);
                    System.IO.File.AppendAllText(vTriFileName, vDropOrderStr + "\r\n");
                }
            }
            else FileLog("Tri file does not exists {0}", vTriFileName);
        }




    }
}
