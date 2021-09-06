namespace RT_OPT
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tbLog = new System.Windows.Forms.TextBox();
            this.tcAll = new System.Windows.Forms.TabControl();
            this.tpTrading = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbAutoreload = new System.Windows.Forms.CheckBox();
            this.cbAllowTrade = new System.Windows.Forms.CheckBox();
            this.bLoad_State = new System.Windows.Forms.Button();
            this.dgv_TPQuote = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.baseCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.baseQtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bid1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ask1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addQtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bid2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ask2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceToBuyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QtyToBuy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceToSellDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyToSellDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diffToMoveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiffMaxBefore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValueAvg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BBuyCurr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BSellCurr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tPQuotingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rT_OPTDataSet = new RT_OPT.RT_OPTDataSet();
            this.dgv_Orders = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tPIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quoteHedgeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.restDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyByTradesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activeOrdersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pTP = new System.Windows.Forms.Panel();
            this.cbOnlyActive = new System.Windows.Forms.CheckBox();
            this.dgv_TP = new System.Windows.Forms.DataGridView();
            this.tPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bApply = new System.Windows.Forms.Button();
            this.tpSettings = new System.Windows.Forms.TabPage();
            this.tbQuoteInterval = new System.Windows.Forms.TextBox();
            this.lRequote_Int = new System.Windows.Forms.Label();
            this.bSaveSettings = new System.Windows.Forms.Button();
            this.tbDropOrderStr = new System.Windows.Forms.TextBox();
            this.lDropOrderStr = new System.Windows.Forms.Label();
            this.tbSetOrderStr = new System.Windows.Forms.TextBox();
            this.lSetOrderStr = new System.Windows.Forms.Label();
            this.bSelectLogFile = new System.Windows.Forms.Button();
            this.tbLogFile = new System.Windows.Forms.TextBox();
            this.lLog = new System.Windows.Forms.Label();
            this.bTriFileSelect = new System.Windows.Forms.Button();
            this.tbTriFile = new System.Windows.Forms.TextBox();
            this.lTriFile = new System.Windows.Forms.Label();
            this.timer_Requote = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.tPTableAdapter = new RT_OPT.RT_OPTDataSetTableAdapters.TPTableAdapter();
            this.activeOrdersTableAdapter = new RT_OPT.RT_OPTDataSetTableAdapters.ActiveOrdersTableAdapter();
            this.tPQuotingTableAdapter = new RT_OPT.RT_OPTDataSetTableAdapters.TPQuotingTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isActiveDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.baseSecIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addSecIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bBuyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bSellDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vBchangeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.volMaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.volMinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.v0DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.psToMoveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PSMaxBefore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tcAll.SuspendLayout();
            this.tpTrading.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TPQuote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPQuotingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rT_OPTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Orders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activeOrdersBindingSource)).BeginInit();
            this.pTP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPBindingSource)).BeginInit();
            this.tpSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbLog
            // 
            this.tbLog.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbLog.Location = new System.Drawing.Point(0, 593);
            this.tbLog.Multiline = true;
            this.tbLog.Name = "tbLog";
            this.tbLog.Size = new System.Drawing.Size(1158, 85);
            this.tbLog.TabIndex = 0;
            // 
            // tcAll
            // 
            this.tcAll.Controls.Add(this.tpTrading);
            this.tcAll.Controls.Add(this.tpSettings);
            this.tcAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcAll.Location = new System.Drawing.Point(0, 0);
            this.tcAll.Name = "tcAll";
            this.tcAll.SelectedIndex = 0;
            this.tcAll.Size = new System.Drawing.Size(1158, 593);
            this.tcAll.TabIndex = 1;
            // 
            // tpTrading
            // 
            this.tpTrading.Controls.Add(this.panel1);
            this.tpTrading.Controls.Add(this.pTP);
            this.tpTrading.Location = new System.Drawing.Point(4, 22);
            this.tpTrading.Name = "tpTrading";
            this.tpTrading.Padding = new System.Windows.Forms.Padding(3);
            this.tpTrading.Size = new System.Drawing.Size(1150, 567);
            this.tpTrading.TabIndex = 0;
            this.tpTrading.Text = "Trading";
            this.tpTrading.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.cbAutoreload);
            this.panel1.Controls.Add(this.cbAllowTrade);
            this.panel1.Controls.Add(this.bLoad_State);
            this.panel1.Controls.Add(this.dgv_TPQuote);
            this.panel1.Controls.Add(this.dgv_Orders);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 217);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(1144, 347);
            this.panel1.TabIndex = 4;
            // 
            // cbAutoreload
            // 
            this.cbAutoreload.AutoSize = true;
            this.cbAutoreload.Location = new System.Drawing.Point(167, 16);
            this.cbAutoreload.Name = "cbAutoreload";
            this.cbAutoreload.Size = new System.Drawing.Size(77, 17);
            this.cbAutoreload.TabIndex = 4;
            this.cbAutoreload.Text = "Autoreload";
            this.cbAutoreload.UseVisualStyleBackColor = true;
            this.cbAutoreload.Click += new System.EventHandler(this.StartStopTimer);
            // 
            // cbAllowTrade
            // 
            this.cbAllowTrade.AutoSize = true;
            this.cbAllowTrade.Location = new System.Drawing.Point(8, 16);
            this.cbAllowTrade.Name = "cbAllowTrade";
            this.cbAllowTrade.Size = new System.Drawing.Size(90, 17);
            this.cbAllowTrade.TabIndex = 3;
            this.cbAllowTrade.Text = "Allow Trading";
            this.cbAllowTrade.UseVisualStyleBackColor = true;
            // 
            // bLoad_State
            // 
            this.bLoad_State.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bLoad_State.Location = new System.Drawing.Point(986, 6);
            this.bLoad_State.Name = "bLoad_State";
            this.bLoad_State.Size = new System.Drawing.Size(150, 30);
            this.bLoad_State.TabIndex = 2;
            this.bLoad_State.Text = "Load State";
            this.bLoad_State.UseVisualStyleBackColor = false;
            this.bLoad_State.Click += new System.EventHandler(this.LoadingState);
            // 
            // dgv_TPQuote
            // 
            this.dgv_TPQuote.AllowUserToAddRows = false;
            this.dgv_TPQuote.AllowUserToDeleteRows = false;
            this.dgv_TPQuote.AutoGenerateColumns = false;
            this.dgv_TPQuote.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_TPQuote.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn2,
            this.nameDataGridViewTextBoxColumn1,
            this.baseCodeDataGridViewTextBoxColumn,
            this.baseQtyDataGridViewTextBoxColumn,
            this.bid1DataGridViewTextBoxColumn,
            this.ask1DataGridViewTextBoxColumn,
            this.addCodeDataGridViewTextBoxColumn,
            this.addQtyDataGridViewTextBoxColumn,
            this.bid2DataGridViewTextBoxColumn,
            this.ask2DataGridViewTextBoxColumn,
            this.priceToBuyDataGridViewTextBoxColumn,
            this.QtyToBuy,
            this.priceToSellDataGridViewTextBoxColumn,
            this.qtyToSellDataGridViewTextBoxColumn,
            this.diffToMoveDataGridViewTextBoxColumn,
            this.DiffMaxBefore,
            this.ValueAvg,
            this.BBuyCurr,
            this.BSellCurr});
            this.dgv_TPQuote.DataSource = this.tPQuotingBindingSource;
            this.dgv_TPQuote.Location = new System.Drawing.Point(8, 49);
            this.dgv_TPQuote.Name = "dgv_TPQuote";
            this.dgv_TPQuote.ReadOnly = true;
            this.dgv_TPQuote.RowHeadersWidth = 10;
            this.dgv_TPQuote.Size = new System.Drawing.Size(1128, 150);
            this.dgv_TPQuote.TabIndex = 1;
            // 
            // idDataGridViewTextBoxColumn2
            // 
            this.idDataGridViewTextBoxColumn2.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn2.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn2.MinimumWidth = 40;
            this.idDataGridViewTextBoxColumn2.Name = "idDataGridViewTextBoxColumn2";
            this.idDataGridViewTextBoxColumn2.ReadOnly = true;
            this.idDataGridViewTextBoxColumn2.Width = 40;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.MinimumWidth = 90;
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn1.Width = 90;
            // 
            // baseCodeDataGridViewTextBoxColumn
            // 
            this.baseCodeDataGridViewTextBoxColumn.DataPropertyName = "BaseCode";
            this.baseCodeDataGridViewTextBoxColumn.HeaderText = "BaseCode";
            this.baseCodeDataGridViewTextBoxColumn.MinimumWidth = 80;
            this.baseCodeDataGridViewTextBoxColumn.Name = "baseCodeDataGridViewTextBoxColumn";
            this.baseCodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.baseCodeDataGridViewTextBoxColumn.Width = 80;
            // 
            // baseQtyDataGridViewTextBoxColumn
            // 
            this.baseQtyDataGridViewTextBoxColumn.DataPropertyName = "BaseQty";
            this.baseQtyDataGridViewTextBoxColumn.HeaderText = "BsQty";
            this.baseQtyDataGridViewTextBoxColumn.MinimumWidth = 40;
            this.baseQtyDataGridViewTextBoxColumn.Name = "baseQtyDataGridViewTextBoxColumn";
            this.baseQtyDataGridViewTextBoxColumn.ReadOnly = true;
            this.baseQtyDataGridViewTextBoxColumn.Width = 40;
            // 
            // bid1DataGridViewTextBoxColumn
            // 
            this.bid1DataGridViewTextBoxColumn.DataPropertyName = "Bid1";
            this.bid1DataGridViewTextBoxColumn.HeaderText = "Bid1";
            this.bid1DataGridViewTextBoxColumn.MinimumWidth = 50;
            this.bid1DataGridViewTextBoxColumn.Name = "bid1DataGridViewTextBoxColumn";
            this.bid1DataGridViewTextBoxColumn.ReadOnly = true;
            this.bid1DataGridViewTextBoxColumn.Width = 50;
            // 
            // ask1DataGridViewTextBoxColumn
            // 
            this.ask1DataGridViewTextBoxColumn.DataPropertyName = "Ask1";
            this.ask1DataGridViewTextBoxColumn.HeaderText = "Ask1";
            this.ask1DataGridViewTextBoxColumn.MinimumWidth = 50;
            this.ask1DataGridViewTextBoxColumn.Name = "ask1DataGridViewTextBoxColumn";
            this.ask1DataGridViewTextBoxColumn.ReadOnly = true;
            this.ask1DataGridViewTextBoxColumn.Width = 50;
            // 
            // addCodeDataGridViewTextBoxColumn
            // 
            this.addCodeDataGridViewTextBoxColumn.DataPropertyName = "AddCode";
            this.addCodeDataGridViewTextBoxColumn.HeaderText = "AddCode";
            this.addCodeDataGridViewTextBoxColumn.MinimumWidth = 80;
            this.addCodeDataGridViewTextBoxColumn.Name = "addCodeDataGridViewTextBoxColumn";
            this.addCodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.addCodeDataGridViewTextBoxColumn.Width = 80;
            // 
            // addQtyDataGridViewTextBoxColumn
            // 
            this.addQtyDataGridViewTextBoxColumn.DataPropertyName = "AddQty";
            this.addQtyDataGridViewTextBoxColumn.HeaderText = "AddQty";
            this.addQtyDataGridViewTextBoxColumn.MinimumWidth = 45;
            this.addQtyDataGridViewTextBoxColumn.Name = "addQtyDataGridViewTextBoxColumn";
            this.addQtyDataGridViewTextBoxColumn.ReadOnly = true;
            this.addQtyDataGridViewTextBoxColumn.Width = 45;
            // 
            // bid2DataGridViewTextBoxColumn
            // 
            this.bid2DataGridViewTextBoxColumn.DataPropertyName = "Bid2";
            this.bid2DataGridViewTextBoxColumn.HeaderText = "Bid2";
            this.bid2DataGridViewTextBoxColumn.MinimumWidth = 50;
            this.bid2DataGridViewTextBoxColumn.Name = "bid2DataGridViewTextBoxColumn";
            this.bid2DataGridViewTextBoxColumn.ReadOnly = true;
            this.bid2DataGridViewTextBoxColumn.Width = 50;
            // 
            // ask2DataGridViewTextBoxColumn
            // 
            this.ask2DataGridViewTextBoxColumn.DataPropertyName = "Ask2";
            this.ask2DataGridViewTextBoxColumn.HeaderText = "Ask2";
            this.ask2DataGridViewTextBoxColumn.MinimumWidth = 50;
            this.ask2DataGridViewTextBoxColumn.Name = "ask2DataGridViewTextBoxColumn";
            this.ask2DataGridViewTextBoxColumn.ReadOnly = true;
            this.ask2DataGridViewTextBoxColumn.Width = 50;
            // 
            // priceToBuyDataGridViewTextBoxColumn
            // 
            this.priceToBuyDataGridViewTextBoxColumn.DataPropertyName = "PriceToBuy";
            this.priceToBuyDataGridViewTextBoxColumn.HeaderText = "PriceBuy";
            this.priceToBuyDataGridViewTextBoxColumn.MinimumWidth = 60;
            this.priceToBuyDataGridViewTextBoxColumn.Name = "priceToBuyDataGridViewTextBoxColumn";
            this.priceToBuyDataGridViewTextBoxColumn.ReadOnly = true;
            this.priceToBuyDataGridViewTextBoxColumn.Width = 60;
            // 
            // QtyToBuy
            // 
            this.QtyToBuy.DataPropertyName = "QtyToBuy";
            this.QtyToBuy.HeaderText = "QBuy";
            this.QtyToBuy.MinimumWidth = 40;
            this.QtyToBuy.Name = "QtyToBuy";
            this.QtyToBuy.ReadOnly = true;
            this.QtyToBuy.Width = 40;
            // 
            // priceToSellDataGridViewTextBoxColumn
            // 
            this.priceToSellDataGridViewTextBoxColumn.DataPropertyName = "PriceToSell";
            this.priceToSellDataGridViewTextBoxColumn.HeaderText = "PriceSell";
            this.priceToSellDataGridViewTextBoxColumn.MinimumWidth = 60;
            this.priceToSellDataGridViewTextBoxColumn.Name = "priceToSellDataGridViewTextBoxColumn";
            this.priceToSellDataGridViewTextBoxColumn.ReadOnly = true;
            this.priceToSellDataGridViewTextBoxColumn.Width = 60;
            // 
            // qtyToSellDataGridViewTextBoxColumn
            // 
            this.qtyToSellDataGridViewTextBoxColumn.DataPropertyName = "QtyToSell";
            this.qtyToSellDataGridViewTextBoxColumn.HeaderText = "QSell";
            this.qtyToSellDataGridViewTextBoxColumn.MinimumWidth = 40;
            this.qtyToSellDataGridViewTextBoxColumn.Name = "qtyToSellDataGridViewTextBoxColumn";
            this.qtyToSellDataGridViewTextBoxColumn.ReadOnly = true;
            this.qtyToSellDataGridViewTextBoxColumn.Width = 40;
            // 
            // diffToMoveDataGridViewTextBoxColumn
            // 
            this.diffToMoveDataGridViewTextBoxColumn.DataPropertyName = "DiffToMove";
            this.diffToMoveDataGridViewTextBoxColumn.HeaderText = "DiffMove";
            this.diffToMoveDataGridViewTextBoxColumn.MinimumWidth = 60;
            this.diffToMoveDataGridViewTextBoxColumn.Name = "diffToMoveDataGridViewTextBoxColumn";
            this.diffToMoveDataGridViewTextBoxColumn.ReadOnly = true;
            this.diffToMoveDataGridViewTextBoxColumn.Width = 60;
            // 
            // DiffMaxBefore
            // 
            this.DiffMaxBefore.DataPropertyName = "DiffMaxBefore";
            this.DiffMaxBefore.HeaderText = "DiffBefore";
            this.DiffMaxBefore.MinimumWidth = 60;
            this.DiffMaxBefore.Name = "DiffMaxBefore";
            this.DiffMaxBefore.ReadOnly = true;
            this.DiffMaxBefore.Width = 60;
            // 
            // ValueAvg
            // 
            this.ValueAvg.DataPropertyName = "ValueAvg";
            this.ValueAvg.HeaderText = "ValueAvg";
            this.ValueAvg.MinimumWidth = 70;
            this.ValueAvg.Name = "ValueAvg";
            this.ValueAvg.ReadOnly = true;
            this.ValueAvg.Width = 70;
            // 
            // BBuyCurr
            // 
            this.BBuyCurr.DataPropertyName = "BBuyCurr";
            this.BBuyCurr.HeaderText = "BBuyCurr";
            this.BBuyCurr.MinimumWidth = 70;
            this.BBuyCurr.Name = "BBuyCurr";
            this.BBuyCurr.ReadOnly = true;
            this.BBuyCurr.Width = 70;
            // 
            // BSellCurr
            // 
            this.BSellCurr.DataPropertyName = "BSellCurr";
            this.BSellCurr.HeaderText = "BSellCurr";
            this.BSellCurr.MinimumWidth = 70;
            this.BSellCurr.Name = "BSellCurr";
            this.BSellCurr.ReadOnly = true;
            this.BSellCurr.Width = 70;
            // 
            // tPQuotingBindingSource
            // 
            this.tPQuotingBindingSource.DataMember = "TPQuoting";
            this.tPQuotingBindingSource.DataSource = this.rT_OPTDataSet;
            // 
            // rT_OPTDataSet
            // 
            this.rT_OPTDataSet.DataSetName = "RT_OPTDataSet";
            this.rT_OPTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgv_Orders
            // 
            this.dgv_Orders.AllowUserToAddRows = false;
            this.dgv_Orders.AllowUserToDeleteRows = false;
            this.dgv_Orders.AutoGenerateColumns = false;
            this.dgv_Orders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Orders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.tPIdDataGridViewTextBoxColumn,
            this.quoteHedgeDataGridViewTextBoxColumn,
            this.orderNoDataGridViewTextBoxColumn,
            this.OrderTime,
            this.codeDataGridViewTextBoxColumn,
            this.operationDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.restDataGridViewTextBoxColumn,
            this.qtyByTradesDataGridViewTextBoxColumn});
            this.dgv_Orders.DataSource = this.activeOrdersBindingSource;
            this.dgv_Orders.Location = new System.Drawing.Point(8, 220);
            this.dgv_Orders.Name = "dgv_Orders";
            this.dgv_Orders.ReadOnly = true;
            this.dgv_Orders.RowHeadersWidth = 10;
            this.dgv_Orders.Size = new System.Drawing.Size(828, 113);
            this.dgv_Orders.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.MinimumWidth = 60;
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idDataGridViewTextBoxColumn1.Width = 60;
            // 
            // tPIdDataGridViewTextBoxColumn
            // 
            this.tPIdDataGridViewTextBoxColumn.DataPropertyName = "TPId";
            this.tPIdDataGridViewTextBoxColumn.HeaderText = "TPId";
            this.tPIdDataGridViewTextBoxColumn.MinimumWidth = 50;
            this.tPIdDataGridViewTextBoxColumn.Name = "tPIdDataGridViewTextBoxColumn";
            this.tPIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.tPIdDataGridViewTextBoxColumn.Width = 50;
            // 
            // quoteHedgeDataGridViewTextBoxColumn
            // 
            this.quoteHedgeDataGridViewTextBoxColumn.DataPropertyName = "QuoteHedge";
            this.quoteHedgeDataGridViewTextBoxColumn.HeaderText = "QuoteHedge";
            this.quoteHedgeDataGridViewTextBoxColumn.MinimumWidth = 70;
            this.quoteHedgeDataGridViewTextBoxColumn.Name = "quoteHedgeDataGridViewTextBoxColumn";
            this.quoteHedgeDataGridViewTextBoxColumn.ReadOnly = true;
            this.quoteHedgeDataGridViewTextBoxColumn.Width = 70;
            // 
            // orderNoDataGridViewTextBoxColumn
            // 
            this.orderNoDataGridViewTextBoxColumn.DataPropertyName = "OrderNo";
            this.orderNoDataGridViewTextBoxColumn.HeaderText = "OrderNo";
            this.orderNoDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.orderNoDataGridViewTextBoxColumn.Name = "orderNoDataGridViewTextBoxColumn";
            this.orderNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // OrderTime
            // 
            this.OrderTime.DataPropertyName = "OrderTime";
            this.OrderTime.HeaderText = "OrderTime";
            this.OrderTime.Name = "OrderTime";
            this.OrderTime.ReadOnly = true;
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "code";
            this.codeDataGridViewTextBoxColumn.MinimumWidth = 80;
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            this.codeDataGridViewTextBoxColumn.ReadOnly = true;
            this.codeDataGridViewTextBoxColumn.Width = 80;
            // 
            // operationDataGridViewTextBoxColumn
            // 
            this.operationDataGridViewTextBoxColumn.DataPropertyName = "Operation";
            this.operationDataGridViewTextBoxColumn.HeaderText = "Operation";
            this.operationDataGridViewTextBoxColumn.MinimumWidth = 60;
            this.operationDataGridViewTextBoxColumn.Name = "operationDataGridViewTextBoxColumn";
            this.operationDataGridViewTextBoxColumn.ReadOnly = true;
            this.operationDataGridViewTextBoxColumn.Width = 60;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 60;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            this.priceDataGridViewTextBoxColumn.Width = 60;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.MinimumWidth = 60;
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            this.quantityDataGridViewTextBoxColumn.Width = 60;
            // 
            // restDataGridViewTextBoxColumn
            // 
            this.restDataGridViewTextBoxColumn.DataPropertyName = "Rest";
            this.restDataGridViewTextBoxColumn.HeaderText = "Rest";
            this.restDataGridViewTextBoxColumn.MinimumWidth = 60;
            this.restDataGridViewTextBoxColumn.Name = "restDataGridViewTextBoxColumn";
            this.restDataGridViewTextBoxColumn.ReadOnly = true;
            this.restDataGridViewTextBoxColumn.Width = 60;
            // 
            // qtyByTradesDataGridViewTextBoxColumn
            // 
            this.qtyByTradesDataGridViewTextBoxColumn.DataPropertyName = "QtyByTrades";
            this.qtyByTradesDataGridViewTextBoxColumn.HeaderText = "QtyByTrades";
            this.qtyByTradesDataGridViewTextBoxColumn.MinimumWidth = 70;
            this.qtyByTradesDataGridViewTextBoxColumn.Name = "qtyByTradesDataGridViewTextBoxColumn";
            this.qtyByTradesDataGridViewTextBoxColumn.ReadOnly = true;
            this.qtyByTradesDataGridViewTextBoxColumn.Width = 70;
            // 
            // activeOrdersBindingSource
            // 
            this.activeOrdersBindingSource.DataMember = "ActiveOrders";
            this.activeOrdersBindingSource.DataSource = this.rT_OPTDataSet;
            // 
            // pTP
            // 
            this.pTP.BackColor = System.Drawing.SystemColors.Info;
            this.pTP.Controls.Add(this.cbOnlyActive);
            this.pTP.Controls.Add(this.dgv_TP);
            this.pTP.Controls.Add(this.bApply);
            this.pTP.Dock = System.Windows.Forms.DockStyle.Top;
            this.pTP.Location = new System.Drawing.Point(3, 3);
            this.pTP.Name = "pTP";
            this.pTP.Padding = new System.Windows.Forms.Padding(5);
            this.pTP.Size = new System.Drawing.Size(1144, 214);
            this.pTP.TabIndex = 3;
            // 
            // cbOnlyActive
            // 
            this.cbOnlyActive.AutoSize = true;
            this.cbOnlyActive.Location = new System.Drawing.Point(891, 8);
            this.cbOnlyActive.Name = "cbOnlyActive";
            this.cbOnlyActive.Size = new System.Drawing.Size(80, 17);
            this.cbOnlyActive.TabIndex = 3;
            this.cbOnlyActive.Text = "Only Active";
            this.cbOnlyActive.UseVisualStyleBackColor = true;
            // 
            // dgv_TP
            // 
            this.dgv_TP.AllowUserToAddRows = false;
            this.dgv_TP.AllowUserToDeleteRows = false;
            this.dgv_TP.AutoGenerateColumns = false;
            this.dgv_TP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_TP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.isActiveDataGridViewCheckBoxColumn,
            this.baseSecIdDataGridViewTextBoxColumn,
            this.addSecIdDataGridViewTextBoxColumn,
            this.bBuyDataGridViewTextBoxColumn,
            this.bSellDataGridViewTextBoxColumn,
            this.vBchangeDataGridViewTextBoxColumn,
            this.volMaxDataGridViewTextBoxColumn,
            this.volMinDataGridViewTextBoxColumn,
            this.v0DataGridViewTextBoxColumn,
            this.psToMoveDataGridViewTextBoxColumn,
            this.PSMaxBefore});
            this.dgv_TP.DataSource = this.tPBindingSource;
            this.dgv_TP.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgv_TP.EnableHeadersVisualStyles = false;
            this.dgv_TP.Location = new System.Drawing.Point(5, 5);
            this.dgv_TP.Name = "dgv_TP";
            this.dgv_TP.RowHeadersWidth = 10;
            this.dgv_TP.Size = new System.Drawing.Size(870, 204);
            this.dgv_TP.TabIndex = 2;
            // 
            // tPBindingSource
            // 
            this.tPBindingSource.DataMember = "TP";
            this.tPBindingSource.DataSource = this.rT_OPTDataSet;
            // 
            // bApply
            // 
            this.bApply.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bApply.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bApply.Location = new System.Drawing.Point(891, 31);
            this.bApply.Name = "bApply";
            this.bApply.Size = new System.Drawing.Size(83, 33);
            this.bApply.TabIndex = 1;
            this.bApply.Text = "Apply";
            this.bApply.UseVisualStyleBackColor = false;
            this.bApply.Click += new System.EventHandler(this.bApply_Click);
            // 
            // tpSettings
            // 
            this.tpSettings.Controls.Add(this.tbQuoteInterval);
            this.tpSettings.Controls.Add(this.lRequote_Int);
            this.tpSettings.Controls.Add(this.bSaveSettings);
            this.tpSettings.Controls.Add(this.tbDropOrderStr);
            this.tpSettings.Controls.Add(this.lDropOrderStr);
            this.tpSettings.Controls.Add(this.tbSetOrderStr);
            this.tpSettings.Controls.Add(this.lSetOrderStr);
            this.tpSettings.Controls.Add(this.bSelectLogFile);
            this.tpSettings.Controls.Add(this.tbLogFile);
            this.tpSettings.Controls.Add(this.lLog);
            this.tpSettings.Controls.Add(this.bTriFileSelect);
            this.tpSettings.Controls.Add(this.tbTriFile);
            this.tpSettings.Controls.Add(this.lTriFile);
            this.tpSettings.Location = new System.Drawing.Point(4, 22);
            this.tpSettings.Name = "tpSettings";
            this.tpSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tpSettings.Size = new System.Drawing.Size(1150, 567);
            this.tpSettings.TabIndex = 1;
            this.tpSettings.Text = "Settings";
            this.tpSettings.UseVisualStyleBackColor = true;
            // 
            // tbQuoteInterval
            // 
            this.tbQuoteInterval.Location = new System.Drawing.Point(133, 127);
            this.tbQuoteInterval.Name = "tbQuoteInterval";
            this.tbQuoteInterval.Size = new System.Drawing.Size(54, 20);
            this.tbQuoteInterval.TabIndex = 25;
            // 
            // lRequote_Int
            // 
            this.lRequote_Int.AutoSize = true;
            this.lRequote_Int.Location = new System.Drawing.Point(9, 130);
            this.lRequote_Int.Name = "lRequote_Int";
            this.lRequote_Int.Size = new System.Drawing.Size(118, 13);
            this.lRequote_Int.TabIndex = 24;
            this.lRequote_Int.Text = "Auto Quote Interval, ms";
            // 
            // bSaveSettings
            // 
            this.bSaveSettings.Location = new System.Drawing.Point(12, 166);
            this.bSaveSettings.Name = "bSaveSettings";
            this.bSaveSettings.Size = new System.Drawing.Size(81, 23);
            this.bSaveSettings.TabIndex = 23;
            this.bSaveSettings.Text = "Save Settings";
            this.bSaveSettings.UseVisualStyleBackColor = true;
            this.bSaveSettings.Click += new System.EventHandler(this.bSaveSettings_Click);
            // 
            // tbDropOrderStr
            // 
            this.tbDropOrderStr.Location = new System.Drawing.Point(96, 101);
            this.tbDropOrderStr.Name = "tbDropOrderStr";
            this.tbDropOrderStr.Size = new System.Drawing.Size(577, 20);
            this.tbDropOrderStr.TabIndex = 22;
            // 
            // lDropOrderStr
            // 
            this.lDropOrderStr.AutoSize = true;
            this.lDropOrderStr.Location = new System.Drawing.Point(9, 104);
            this.lDropOrderStr.Name = "lDropOrderStr";
            this.lDropOrderStr.Size = new System.Drawing.Size(84, 13);
            this.lDropOrderStr.TabIndex = 21;
            this.lDropOrderStr.Text = "DropOrder string";
            // 
            // tbSetOrderStr
            // 
            this.tbSetOrderStr.Location = new System.Drawing.Point(96, 75);
            this.tbSetOrderStr.Name = "tbSetOrderStr";
            this.tbSetOrderStr.Size = new System.Drawing.Size(577, 20);
            this.tbSetOrderStr.TabIndex = 20;
            // 
            // lSetOrderStr
            // 
            this.lSetOrderStr.AutoSize = true;
            this.lSetOrderStr.Location = new System.Drawing.Point(9, 78);
            this.lSetOrderStr.Name = "lSetOrderStr";
            this.lSetOrderStr.Size = new System.Drawing.Size(77, 13);
            this.lSetOrderStr.TabIndex = 19;
            this.lSetOrderStr.Text = "SetOrder string";
            // 
            // bSelectLogFile
            // 
            this.bSelectLogFile.Location = new System.Drawing.Point(487, 30);
            this.bSelectLogFile.Name = "bSelectLogFile";
            this.bSelectLogFile.Size = new System.Drawing.Size(75, 23);
            this.bSelectLogFile.TabIndex = 18;
            this.bSelectLogFile.Text = "Select";
            this.bSelectLogFile.UseVisualStyleBackColor = true;
            this.bSelectLogFile.Click += new System.EventHandler(this.bSelectLogFile_Click);
            // 
            // tbLogFile
            // 
            this.tbLogFile.Location = new System.Drawing.Point(70, 32);
            this.tbLogFile.Name = "tbLogFile";
            this.tbLogFile.Size = new System.Drawing.Size(411, 20);
            this.tbLogFile.TabIndex = 17;
            // 
            // lLog
            // 
            this.lLog.AutoSize = true;
            this.lLog.Location = new System.Drawing.Point(9, 35);
            this.lLog.Name = "lLog";
            this.lLog.Size = new System.Drawing.Size(44, 13);
            this.lLog.TabIndex = 16;
            this.lLog.Text = "Log File";
            // 
            // bTriFileSelect
            // 
            this.bTriFileSelect.Location = new System.Drawing.Point(487, 4);
            this.bTriFileSelect.Name = "bTriFileSelect";
            this.bTriFileSelect.Size = new System.Drawing.Size(75, 23);
            this.bTriFileSelect.TabIndex = 15;
            this.bTriFileSelect.Text = "Select";
            this.bTriFileSelect.UseVisualStyleBackColor = true;
            this.bTriFileSelect.Click += new System.EventHandler(this.bTriFileSelect_Click);
            // 
            // tbTriFile
            // 
            this.tbTriFile.Location = new System.Drawing.Point(70, 6);
            this.tbTriFile.Name = "tbTriFile";
            this.tbTriFile.Size = new System.Drawing.Size(411, 20);
            this.tbTriFile.TabIndex = 14;
            // 
            // lTriFile
            // 
            this.lTriFile.AutoSize = true;
            this.lTriFile.Location = new System.Drawing.Point(9, 9);
            this.lTriFile.Name = "lTriFile";
            this.lTriFile.Size = new System.Drawing.Size(38, 13);
            this.lTriFile.TabIndex = 13;
            this.lTriFile.Text = "Tri File";
            // 
            // timer_Requote
            // 
            this.timer_Requote.Interval = 3000;
            this.timer_Requote.Tick += new System.EventHandler(this.QuoteByTimer);
            // 
            // tPTableAdapter
            // 
            this.tPTableAdapter.ClearBeforeFill = true;
            // 
            // activeOrdersTableAdapter
            // 
            this.activeOrdersTableAdapter.ClearBeforeFill = true;
            // 
            // tPQuotingTableAdapter
            // 
            this.tPQuotingTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 50;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 50;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 120;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 120;
            // 
            // isActiveDataGridViewCheckBoxColumn
            // 
            this.isActiveDataGridViewCheckBoxColumn.DataPropertyName = "IsActive";
            this.isActiveDataGridViewCheckBoxColumn.HeaderText = "IsActive";
            this.isActiveDataGridViewCheckBoxColumn.MinimumWidth = 50;
            this.isActiveDataGridViewCheckBoxColumn.Name = "isActiveDataGridViewCheckBoxColumn";
            this.isActiveDataGridViewCheckBoxColumn.Width = 50;
            // 
            // baseSecIdDataGridViewTextBoxColumn
            // 
            this.baseSecIdDataGridViewTextBoxColumn.DataPropertyName = "BaseSecId";
            this.baseSecIdDataGridViewTextBoxColumn.HeaderText = "BaseSecId";
            this.baseSecIdDataGridViewTextBoxColumn.Name = "baseSecIdDataGridViewTextBoxColumn";
            this.baseSecIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // addSecIdDataGridViewTextBoxColumn
            // 
            this.addSecIdDataGridViewTextBoxColumn.DataPropertyName = "AddSecId";
            this.addSecIdDataGridViewTextBoxColumn.HeaderText = "AddSecId";
            this.addSecIdDataGridViewTextBoxColumn.Name = "addSecIdDataGridViewTextBoxColumn";
            this.addSecIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // bBuyDataGridViewTextBoxColumn
            // 
            this.bBuyDataGridViewTextBoxColumn.DataPropertyName = "BBuy";
            this.bBuyDataGridViewTextBoxColumn.HeaderText = "BBuy";
            this.bBuyDataGridViewTextBoxColumn.MinimumWidth = 80;
            this.bBuyDataGridViewTextBoxColumn.Name = "bBuyDataGridViewTextBoxColumn";
            this.bBuyDataGridViewTextBoxColumn.Width = 80;
            // 
            // bSellDataGridViewTextBoxColumn
            // 
            this.bSellDataGridViewTextBoxColumn.DataPropertyName = "BSell";
            this.bSellDataGridViewTextBoxColumn.HeaderText = "BSell";
            this.bSellDataGridViewTextBoxColumn.MinimumWidth = 80;
            this.bSellDataGridViewTextBoxColumn.Name = "bSellDataGridViewTextBoxColumn";
            this.bSellDataGridViewTextBoxColumn.Width = 80;
            // 
            // vBchangeDataGridViewTextBoxColumn
            // 
            this.vBchangeDataGridViewTextBoxColumn.DataPropertyName = "VBchange";
            this.vBchangeDataGridViewTextBoxColumn.HeaderText = "VBchange";
            this.vBchangeDataGridViewTextBoxColumn.MinimumWidth = 80;
            this.vBchangeDataGridViewTextBoxColumn.Name = "vBchangeDataGridViewTextBoxColumn";
            this.vBchangeDataGridViewTextBoxColumn.Width = 80;
            // 
            // volMaxDataGridViewTextBoxColumn
            // 
            this.volMaxDataGridViewTextBoxColumn.DataPropertyName = "VolMax";
            this.volMaxDataGridViewTextBoxColumn.HeaderText = "VolMax";
            this.volMaxDataGridViewTextBoxColumn.MinimumWidth = 80;
            this.volMaxDataGridViewTextBoxColumn.Name = "volMaxDataGridViewTextBoxColumn";
            this.volMaxDataGridViewTextBoxColumn.Width = 80;
            // 
            // volMinDataGridViewTextBoxColumn
            // 
            this.volMinDataGridViewTextBoxColumn.DataPropertyName = "VolMin";
            this.volMinDataGridViewTextBoxColumn.HeaderText = "VolMin";
            this.volMinDataGridViewTextBoxColumn.MinimumWidth = 80;
            this.volMinDataGridViewTextBoxColumn.Name = "volMinDataGridViewTextBoxColumn";
            this.volMinDataGridViewTextBoxColumn.Width = 80;
            // 
            // v0DataGridViewTextBoxColumn
            // 
            this.v0DataGridViewTextBoxColumn.DataPropertyName = "V0";
            this.v0DataGridViewTextBoxColumn.HeaderText = "V0";
            this.v0DataGridViewTextBoxColumn.MinimumWidth = 50;
            this.v0DataGridViewTextBoxColumn.Name = "v0DataGridViewTextBoxColumn";
            this.v0DataGridViewTextBoxColumn.Width = 50;
            // 
            // psToMoveDataGridViewTextBoxColumn
            // 
            this.psToMoveDataGridViewTextBoxColumn.DataPropertyName = "PsToMove";
            this.psToMoveDataGridViewTextBoxColumn.HeaderText = "PsToMove";
            this.psToMoveDataGridViewTextBoxColumn.MinimumWidth = 80;
            this.psToMoveDataGridViewTextBoxColumn.Name = "psToMoveDataGridViewTextBoxColumn";
            this.psToMoveDataGridViewTextBoxColumn.Width = 80;
            // 
            // PSMaxBefore
            // 
            this.PSMaxBefore.DataPropertyName = "PSMaxBefore";
            this.PSMaxBefore.HeaderText = "PSMaxBefore";
            this.PSMaxBefore.MinimumWidth = 80;
            this.PSMaxBefore.Name = "PSMaxBefore";
            this.PSMaxBefore.Width = 80;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 678);
            this.Controls.Add(this.tcAll);
            this.Controls.Add(this.tbLog);
            this.Name = "MainForm";
            this.Text = "RT_OPT";
            this.Load += new System.EventHandler(this.Form_Load);
            this.tcAll.ResumeLayout(false);
            this.tpTrading.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TPQuote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPQuotingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rT_OPTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Orders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activeOrdersBindingSource)).EndInit();
            this.pTP.ResumeLayout(false);
            this.pTP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPBindingSource)).EndInit();
            this.tpSettings.ResumeLayout(false);
            this.tpSettings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbLog;
        private System.Windows.Forms.TabControl tcAll;
        private System.Windows.Forms.TabPage tpTrading;
        private System.Windows.Forms.TabPage tpSettings;
        private System.Windows.Forms.TextBox tbQuoteInterval;
        private System.Windows.Forms.Label lRequote_Int;
        private System.Windows.Forms.Button bSaveSettings;
        private System.Windows.Forms.TextBox tbDropOrderStr;
        private System.Windows.Forms.Label lDropOrderStr;
        private System.Windows.Forms.TextBox tbSetOrderStr;
        private System.Windows.Forms.Label lSetOrderStr;
        private System.Windows.Forms.Button bSelectLogFile;
        private System.Windows.Forms.TextBox tbLogFile;
        private System.Windows.Forms.Label lLog;
        private System.Windows.Forms.Button bTriFileSelect;
        private System.Windows.Forms.TextBox tbTriFile;
        private System.Windows.Forms.Label lTriFile;
        private System.Windows.Forms.Timer timer_Requote;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button bApply;
        private System.Windows.Forms.DataGridView dgv_TP;
        private RT_OPTDataSet rT_OPTDataSet;
        private System.Windows.Forms.BindingSource tPBindingSource;
        private RT_OPTDataSetTableAdapters.TPTableAdapter tPTableAdapter;
        private System.Windows.Forms.Panel pTP;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv_Orders;
        private System.Windows.Forms.BindingSource activeOrdersBindingSource;
        private RT_OPTDataSetTableAdapters.ActiveOrdersTableAdapter activeOrdersTableAdapter;
        private System.Windows.Forms.DataGridView dgv_TPQuote;
        private System.Windows.Forms.BindingSource tPQuotingBindingSource;
        private RT_OPTDataSetTableAdapters.TPQuotingTableAdapter tPQuotingTableAdapter;
        private System.Windows.Forms.Button bLoad_State;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tPIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quoteHedgeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn operationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn restDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyByTradesDataGridViewTextBoxColumn;
        private System.Windows.Forms.CheckBox cbAllowTrade;
        private System.Windows.Forms.CheckBox cbAutoreload;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn baseCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn baseQtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bid1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ask1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addQtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bid2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ask2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceToBuyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn QtyToBuy;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceToSellDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyToSellDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diffToMoveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiffMaxBefore;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValueAvg;
        private System.Windows.Forms.DataGridViewTextBoxColumn BBuyCurr;
        private System.Windows.Forms.DataGridViewTextBoxColumn BSellCurr;
        private System.Windows.Forms.CheckBox cbOnlyActive;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isActiveDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn baseSecIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addSecIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bBuyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bSellDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vBchangeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn volMaxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn volMinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn v0DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn psToMoveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PSMaxBefore;


    }
}

