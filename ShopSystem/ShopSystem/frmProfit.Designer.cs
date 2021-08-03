namespace ShopSystem
{
    partial class frmProfit
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.mtbStartDate = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnToday = new System.Windows.Forms.Button();
            this.mtbEndDate = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvProfit = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wareTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shopFromDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shopDataSet = new ShopSystem.ShopDataSet();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProfit = new System.Windows.Forms.TextBox();
            this.txtTotalSell = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.sellTableAdapter = new ShopSystem.ShopDataSetTableAdapters.SellTableAdapter();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.mtbStartDate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnToday);
            this.groupBox1.Controls.Add(this.mtbEndDate);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(620, 72);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "عملیات";
            // 
            // btnSearch
            // 
            this.btnSearch.Image = global::ShopSystem.Properties.Resources.magnifier_zoom;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.Location = new System.Drawing.Point(25, 20);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(103, 34);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "جستجو";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // mtbStartDate
            // 
            this.mtbStartDate.Location = new System.Drawing.Point(414, 28);
            this.mtbStartDate.Mask = "00/00/0000";
            this.mtbStartDate.Name = "mtbStartDate";
            this.mtbStartDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mtbStartDate.Size = new System.Drawing.Size(130, 21);
            this.mtbStartDate.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(550, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "از تاریخ";
            // 
            // btnToday
            // 
            this.btnToday.Location = new System.Drawing.Point(174, 26);
            this.btnToday.Name = "btnToday";
            this.btnToday.Size = new System.Drawing.Size(41, 23);
            this.btnToday.TabIndex = 2;
            this.btnToday.Text = "امروز";
            this.btnToday.UseVisualStyleBackColor = true;
            this.btnToday.Click += new System.EventHandler(this.btnToday_Click);
            // 
            // mtbEndDate
            // 
            this.mtbEndDate.Location = new System.Drawing.Point(221, 28);
            this.mtbEndDate.Mask = "00/00/0000";
            this.mtbEndDate.Name = "mtbEndDate";
            this.mtbEndDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mtbEndDate.Size = new System.Drawing.Size(130, 21);
            this.mtbEndDate.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(357, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "تا تاریخ:";
            // 
            // dgvProfit
            // 
            this.dgvProfit.AutoGenerateColumns = false;
            this.dgvProfit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProfit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.wareTitleDataGridViewTextBoxColumn,
            this.shopFromDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.countDataGridViewTextBoxColumn,
            this.profitDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.sellDateDataGridViewTextBoxColumn});
            this.dgvProfit.DataSource = this.sellBindingSource;
            this.dgvProfit.Location = new System.Drawing.Point(12, 146);
            this.dgvProfit.Name = "dgvProfit";
            this.dgvProfit.ReadOnly = true;
            this.dgvProfit.Size = new System.Drawing.Size(620, 542);
            this.dgvProfit.TabIndex = 5;
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
            // 
            // shopFromDataGridViewTextBoxColumn
            // 
            this.shopFromDataGridViewTextBoxColumn.DataPropertyName = "ShopFrom";
            this.shopFromDataGridViewTextBoxColumn.HeaderText = "خریداری شده از";
            this.shopFromDataGridViewTextBoxColumn.Name = "shopFromDataGridViewTextBoxColumn";
            this.shopFromDataGridViewTextBoxColumn.ReadOnly = true;
            this.shopFromDataGridViewTextBoxColumn.Width = 110;
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
            this.profitDataGridViewTextBoxColumn.HeaderText = "میزان سود";
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
            this.amountDataGridViewTextBoxColumn.Width = 85;
            // 
            // sellDateDataGridViewTextBoxColumn
            // 
            this.sellDateDataGridViewTextBoxColumn.DataPropertyName = "SellDate";
            this.sellDateDataGridViewTextBoxColumn.HeaderText = "تاریخ فروش";
            this.sellDateDataGridViewTextBoxColumn.Name = "sellDateDataGridViewTextBoxColumn";
            this.sellDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.sellDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // sellBindingSource
            // 
            this.sellBindingSource.DataMember = "Sell";
            this.sellBindingSource.DataSource = this.shopDataSet;
            // 
            // shopDataSet
            // 
            this.shopDataSet.DataSetName = "ShopDataSet";
            this.shopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(540, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "میزان سود:";
            // 
            // txtProfit
            // 
            this.txtProfit.BackColor = System.Drawing.SystemColors.Control;
            this.txtProfit.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProfit.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtProfit.Location = new System.Drawing.Point(395, 101);
            this.txtProfit.Name = "txtProfit";
            this.txtProfit.ReadOnly = true;
            this.txtProfit.Size = new System.Drawing.Size(130, 23);
            this.txtProfit.TabIndex = 3;
            // 
            // txtTotalSell
            // 
            this.txtTotalSell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalSell.Location = new System.Drawing.Point(130, 101);
            this.txtTotalSell.Name = "txtTotalSell";
            this.txtTotalSell.ReadOnly = true;
            this.txtTotalSell.Size = new System.Drawing.Size(130, 23);
            this.txtTotalSell.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(279, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "میزان فروش:";
            // 
            // sellTableAdapter
            // 
            this.sellTableAdapter.ClearBeforeFill = true;
            // 
            // btnClose
            // 
            this.btnClose.Image = global::ShopSystem.Properties.Resources.exitr4y;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.Location = new System.Drawing.Point(12, 93);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(88, 34);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "انصراف";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmProfit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 700);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtTotalSell);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtProfit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvProfit);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmProfit";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "میزان سود و زیان";
            this.Load += new System.EventHandler(this.frmProfit_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox mtbStartDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnToday;
        private System.Windows.Forms.MaskedTextBox mtbEndDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvProfit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProfit;
        private System.Windows.Forms.TextBox txtTotalSell;
        private System.Windows.Forms.Label label4;
        private ShopDataSet shopDataSet;
        private System.Windows.Forms.BindingSource sellBindingSource;
        private ShopDataSetTableAdapters.SellTableAdapter sellTableAdapter;
        private System.Windows.Forms.Button btnClose;
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