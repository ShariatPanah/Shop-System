namespace ShopSystem
{
    partial class frmSelling
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.txtSeller = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtProfit = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSellPrice = new System.Windows.Forms.TextBox();
            this.txtShopPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtWareTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnToday = new System.Windows.Forms.Button();
            this.mtbDate = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvSearch = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.factorNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shopDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wareTitleDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shoppingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shopDataSet = new ShopSystem.ShopDataSet();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDeleteRow = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.dgvSell = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wareTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shopFromDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sellTableAdapter = new ShopSystem.ShopDataSetTableAdapters.SellTableAdapter();
            this.shoppingTableAdapter = new ShopSystem.ShopDataSetTableAdapters.ShoppingTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shoppingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSell)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCalculate);
            this.groupBox1.Controls.Add(this.btnSelect);
            this.groupBox1.Controls.Add(this.txtSeller);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtTotal);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtProfit);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtSellPrice);
            this.groupBox1.Controls.Add(this.txtShopPrice);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtCount);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtWareTitle);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnToday);
            this.groupBox1.Controls.Add(this.mtbDate);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(380, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 235);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "جزئیات فروش";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(43, 206);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(52, 23);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "محاسبه";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Enabled = false;
            this.btnSelect.Location = new System.Drawing.Point(27, 72);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(52, 23);
            this.btnSelect.TabIndex = 3;
            this.btnSelect.Text = "انتخاب";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // txtSeller
            // 
            this.txtSeller.Location = new System.Drawing.Point(85, 74);
            this.txtSeller.Name = "txtSeller";
            this.txtSeller.ReadOnly = true;
            this.txtSeller.Size = new System.Drawing.Size(165, 21);
            this.txtSeller.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(256, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "شرکت فروشنده:";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(101, 208);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(149, 21);
            this.txtTotal.TabIndex = 15;
            this.txtTotal.TextChanged += new System.EventHandler(this.txtTotal_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(256, 211);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "جمع کل:";
            // 
            // txtProfit
            // 
            this.txtProfit.Location = new System.Drawing.Point(101, 181);
            this.txtProfit.Name = "txtProfit";
            this.txtProfit.ReadOnly = true;
            this.txtProfit.Size = new System.Drawing.Size(149, 21);
            this.txtProfit.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(256, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "میزان سود:";
            // 
            // txtSellPrice
            // 
            this.txtSellPrice.Location = new System.Drawing.Point(134, 154);
            this.txtSellPrice.Name = "txtSellPrice";
            this.txtSellPrice.Size = new System.Drawing.Size(116, 21);
            this.txtSellPrice.TabIndex = 5;
            // 
            // txtShopPrice
            // 
            this.txtShopPrice.Location = new System.Drawing.Point(134, 127);
            this.txtShopPrice.Name = "txtShopPrice";
            this.txtShopPrice.ReadOnly = true;
            this.txtShopPrice.Size = new System.Drawing.Size(116, 21);
            this.txtShopPrice.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(256, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "قیمت فروش:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(256, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "قیمت خرید:";
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(167, 100);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(83, 21);
            this.txtCount.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(256, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "تعداد:";
            // 
            // txtWareTitle
            // 
            this.txtWareTitle.Location = new System.Drawing.Point(27, 47);
            this.txtWareTitle.Name = "txtWareTitle";
            this.txtWareTitle.Size = new System.Drawing.Size(223, 21);
            this.txtWareTitle.TabIndex = 2;
            this.txtWareTitle.TextChanged += new System.EventHandler(this.txtWareTitle_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(256, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "نام کالا:";
            // 
            // btnToday
            // 
            this.btnToday.Location = new System.Drawing.Point(73, 20);
            this.btnToday.Name = "btnToday";
            this.btnToday.Size = new System.Drawing.Size(41, 23);
            this.btnToday.TabIndex = 1;
            this.btnToday.Text = "امروز";
            this.btnToday.UseVisualStyleBackColor = true;
            this.btnToday.Click += new System.EventHandler(this.btnToday_Click);
            // 
            // mtbDate
            // 
            this.mtbDate.Location = new System.Drawing.Point(120, 20);
            this.mtbDate.Mask = "00/00/0000 90:00";
            this.mtbDate.Name = "mtbDate";
            this.mtbDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mtbDate.Size = new System.Drawing.Size(130, 21);
            this.mtbDate.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(256, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "تاریخ و ساعت:";
            // 
            // dgvSearch
            // 
            this.dgvSearch.AutoGenerateColumns = false;
            this.dgvSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn1,
            this.factorNoDataGridViewTextBoxColumn,
            this.sellerDataGridViewTextBoxColumn,
            this.shopDateDataGridViewTextBoxColumn,
            this.wareTitleDataGridViewTextBoxColumn1,
            this.priceDataGridViewTextBoxColumn1,
            this.countDataGridViewTextBoxColumn1,
            this.totalAmountDataGridViewTextBoxColumn});
            this.dgvSearch.DataSource = this.shoppingBindingSource;
            this.dgvSearch.Location = new System.Drawing.Point(12, 12);
            this.dgvSearch.Name = "dgvSearch";
            this.dgvSearch.ReadOnly = true;
            this.dgvSearch.Size = new System.Drawing.Size(362, 228);
            this.dgvSearch.TabIndex = 11;
            this.dgvSearch.SelectionChanged += new System.EventHandler(this.dgvSearch_SelectionChanged);
            // 
            // iDDataGridViewTextBoxColumn1
            // 
            this.iDDataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn1.Name = "iDDataGridViewTextBoxColumn1";
            this.iDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn1.Visible = false;
            // 
            // factorNoDataGridViewTextBoxColumn
            // 
            this.factorNoDataGridViewTextBoxColumn.DataPropertyName = "FactorNo";
            this.factorNoDataGridViewTextBoxColumn.HeaderText = "FactorNo";
            this.factorNoDataGridViewTextBoxColumn.Name = "factorNoDataGridViewTextBoxColumn";
            this.factorNoDataGridViewTextBoxColumn.ReadOnly = true;
            this.factorNoDataGridViewTextBoxColumn.Visible = false;
            // 
            // sellerDataGridViewTextBoxColumn
            // 
            this.sellerDataGridViewTextBoxColumn.DataPropertyName = "Seller";
            this.sellerDataGridViewTextBoxColumn.HeaderText = "فروشنده";
            this.sellerDataGridViewTextBoxColumn.Name = "sellerDataGridViewTextBoxColumn";
            this.sellerDataGridViewTextBoxColumn.ReadOnly = true;
            this.sellerDataGridViewTextBoxColumn.Width = 120;
            // 
            // shopDateDataGridViewTextBoxColumn
            // 
            this.shopDateDataGridViewTextBoxColumn.DataPropertyName = "ShopDate";
            this.shopDateDataGridViewTextBoxColumn.HeaderText = "ShopDate";
            this.shopDateDataGridViewTextBoxColumn.Name = "shopDateDataGridViewTextBoxColumn";
            this.shopDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.shopDateDataGridViewTextBoxColumn.Visible = false;
            // 
            // wareTitleDataGridViewTextBoxColumn1
            // 
            this.wareTitleDataGridViewTextBoxColumn1.DataPropertyName = "WareTitle";
            this.wareTitleDataGridViewTextBoxColumn1.HeaderText = "نام کالا";
            this.wareTitleDataGridViewTextBoxColumn1.Name = "wareTitleDataGridViewTextBoxColumn1";
            this.wareTitleDataGridViewTextBoxColumn1.ReadOnly = true;
            this.wareTitleDataGridViewTextBoxColumn1.Width = 119;
            // 
            // priceDataGridViewTextBoxColumn1
            // 
            this.priceDataGridViewTextBoxColumn1.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn1.HeaderText = "قیمت خرید";
            this.priceDataGridViewTextBoxColumn1.Name = "priceDataGridViewTextBoxColumn1";
            this.priceDataGridViewTextBoxColumn1.ReadOnly = true;
            this.priceDataGridViewTextBoxColumn1.Width = 80;
            // 
            // countDataGridViewTextBoxColumn1
            // 
            this.countDataGridViewTextBoxColumn1.DataPropertyName = "Count";
            this.countDataGridViewTextBoxColumn1.HeaderText = "Count";
            this.countDataGridViewTextBoxColumn1.Name = "countDataGridViewTextBoxColumn1";
            this.countDataGridViewTextBoxColumn1.ReadOnly = true;
            this.countDataGridViewTextBoxColumn1.Visible = false;
            // 
            // totalAmountDataGridViewTextBoxColumn
            // 
            this.totalAmountDataGridViewTextBoxColumn.DataPropertyName = "TotalAmount";
            this.totalAmountDataGridViewTextBoxColumn.HeaderText = "TotalAmount";
            this.totalAmountDataGridViewTextBoxColumn.Name = "totalAmountDataGridViewTextBoxColumn";
            this.totalAmountDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalAmountDataGridViewTextBoxColumn.Visible = false;
            // 
            // shoppingBindingSource
            // 
            this.shoppingBindingSource.DataMember = "Shopping";
            this.shoppingBindingSource.DataSource = this.shopDataSet;
            // 
            // shopDataSet
            // 
            this.shopDataSet.DataSetName = "ShopDataSet";
            this.shopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Image = global::ShopSystem.Properties.Resources.save_alt;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.Location = new System.Drawing.Point(324, 246);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(103, 34);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "ذخیره";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Image = global::ShopSystem.Properties.Resources.exitr4y;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.Location = new System.Drawing.Point(12, 246);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(88, 34);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "انصراف";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDeleteRow
            // 
            this.btnDeleteRow.Enabled = false;
            this.btnDeleteRow.Image = global::ShopSystem.Properties.Resources.trash_full;
            this.btnDeleteRow.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteRow.Location = new System.Drawing.Point(215, 246);
            this.btnDeleteRow.Name = "btnDeleteRow";
            this.btnDeleteRow.Size = new System.Drawing.Size(103, 34);
            this.btnDeleteRow.TabIndex = 8;
            this.btnDeleteRow.Text = "حذف سطر";
            this.btnDeleteRow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteRow.UseVisualStyleBackColor = true;
            this.btnDeleteRow.Click += new System.EventHandler(this.btnDeleteRow_Click);
            // 
            // btnClear
            // 
            this.btnClear.Image = global::ShopSystem.Properties.Resources.arrow_circle_315;
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClear.Location = new System.Drawing.Point(106, 246);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(103, 34);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "تازه سازی فرم";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // dgvSell
            // 
            this.dgvSell.AutoGenerateColumns = false;
            this.dgvSell.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSell.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.wareTitleDataGridViewTextBoxColumn,
            this.shopFromDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.countDataGridViewTextBoxColumn,
            this.profitDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.sellDateDataGridViewTextBoxColumn});
            this.dgvSell.DataSource = this.sellBindingSource;
            this.dgvSell.Location = new System.Drawing.Point(12, 286);
            this.dgvSell.Name = "dgvSell";
            this.dgvSell.ReadOnly = true;
            this.dgvSell.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvSell.Size = new System.Drawing.Size(728, 433);
            this.dgvSell.TabIndex = 12;
            this.dgvSell.SelectionChanged += new System.EventHandler(this.dgvSell_SelectionChanged);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // wareTitleDataGridViewTextBoxColumn
            // 
            this.wareTitleDataGridViewTextBoxColumn.DataPropertyName = "WareTitle";
            this.wareTitleDataGridViewTextBoxColumn.HeaderText = "نام کالا";
            this.wareTitleDataGridViewTextBoxColumn.Name = "wareTitleDataGridViewTextBoxColumn";
            this.wareTitleDataGridViewTextBoxColumn.ReadOnly = true;
            this.wareTitleDataGridViewTextBoxColumn.Width = 120;
            // 
            // shopFromDataGridViewTextBoxColumn
            // 
            this.shopFromDataGridViewTextBoxColumn.DataPropertyName = "ShopFrom";
            this.shopFromDataGridViewTextBoxColumn.HeaderText = "خریداری شده از";
            this.shopFromDataGridViewTextBoxColumn.Name = "shopFromDataGridViewTextBoxColumn";
            this.shopFromDataGridViewTextBoxColumn.ReadOnly = true;
            this.shopFromDataGridViewTextBoxColumn.Width = 115;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "قیمت فروش";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            this.priceDataGridViewTextBoxColumn.Width = 90;
            // 
            // countDataGridViewTextBoxColumn
            // 
            this.countDataGridViewTextBoxColumn.DataPropertyName = "Count";
            this.countDataGridViewTextBoxColumn.HeaderText = "تعداد";
            this.countDataGridViewTextBoxColumn.Name = "countDataGridViewTextBoxColumn";
            this.countDataGridViewTextBoxColumn.ReadOnly = true;
            this.countDataGridViewTextBoxColumn.Width = 50;
            // 
            // profitDataGridViewTextBoxColumn
            // 
            this.profitDataGridViewTextBoxColumn.DataPropertyName = "Profit";
            this.profitDataGridViewTextBoxColumn.HeaderText = "مقدار سود";
            this.profitDataGridViewTextBoxColumn.Name = "profitDataGridViewTextBoxColumn";
            this.profitDataGridViewTextBoxColumn.ReadOnly = true;
            this.profitDataGridViewTextBoxColumn.Width = 85;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "جمع فروش";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.ReadOnly = true;
            this.amountDataGridViewTextBoxColumn.Width = 90;
            // 
            // sellDateDataGridViewTextBoxColumn
            // 
            this.sellDateDataGridViewTextBoxColumn.DataPropertyName = "SellDate";
            this.sellDateDataGridViewTextBoxColumn.HeaderText = "تاریخ فروش";
            this.sellDateDataGridViewTextBoxColumn.Name = "sellDateDataGridViewTextBoxColumn";
            this.sellDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.sellDateDataGridViewTextBoxColumn.Width = 135;
            // 
            // sellBindingSource
            // 
            this.sellBindingSource.DataMember = "Sell";
            this.sellBindingSource.DataSource = this.shopDataSet;
            // 
            // sellTableAdapter
            // 
            this.sellTableAdapter.ClearBeforeFill = true;
            // 
            // shoppingTableAdapter
            // 
            this.shoppingTableAdapter.ClearBeforeFill = true;
            // 
            // frmSelling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 731);
            this.Controls.Add(this.dgvSell);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDeleteRow);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.dgvSearch);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmSelling";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "کالاهای فروخته شده";
            this.Load += new System.EventHandler(this.frmSelling_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shoppingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSell)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox mtbDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvSearch;
        private System.Windows.Forms.TextBox txtProfit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSellPrice;
        private System.Windows.Forms.TextBox txtShopPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtWareTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnToday;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDeleteRow;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtSeller;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.DataGridView dgvSell;
        private ShopDataSet shopDataSet;
        private System.Windows.Forms.BindingSource sellBindingSource;
        private ShopDataSetTableAdapters.SellTableAdapter sellTableAdapter;
        private System.Windows.Forms.BindingSource shoppingBindingSource;
        private ShopDataSetTableAdapters.ShoppingTableAdapter shoppingTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn factorNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shopDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wareTitleDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn countDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wareTitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shopFromDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn profitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellDateDataGridViewTextBoxColumn;
    }
}