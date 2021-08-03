namespace ShopSystem
{
    partial class frmInstallment
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
            this.txtRecieveDate = new System.Windows.Forms.MaskedTextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtRemainder = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPrePayment = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBank = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtChequeOwner = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtChequeNo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFactorAmount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFamily = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.mtbDate = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvInstallment = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shopDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.familyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.factorAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prePaymentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remainderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chequeNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chequeOwnerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recieveDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.installmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shopDataSet = new ShopSystem.ShopDataSet();
            this.installmentTableAdapter = new ShopSystem.ShopDataSetTableAdapters.installmentTableAdapter();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDeleteRow = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInstallment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.installmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtRecieveDate);
            this.groupBox1.Controls.Add(this.btnCalculate);
            this.groupBox1.Controls.Add(this.txtRemainder);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtPrePayment);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtBank);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtChequeOwner);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtChequeNo);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtFactorAmount);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtTel);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtFamily);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.mtbDate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(927, 145);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "جزییات قسط جدید";
            // 
            // txtRecieveDate
            // 
            this.txtRecieveDate.Location = new System.Drawing.Point(271, 74);
            this.txtRecieveDate.Mask = "00/00/0000";
            this.txtRecieveDate.Name = "txtRecieveDate";
            this.txtRecieveDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtRecieveDate.Size = new System.Drawing.Size(150, 21);
            this.txtRecieveDate.TabIndex = 25;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Enabled = false;
            this.btnCalculate.Image = global::ShopSystem.Properties.Resources.Calculator_MRT;
            this.btnCalculate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCalculate.Location = new System.Drawing.Point(62, 101);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(108, 38);
            this.btnCalculate.TabIndex = 11;
            this.btnCalculate.Text = "محاسبه مانده";
            this.btnCalculate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtRemainder
            // 
            this.txtRemainder.Location = new System.Drawing.Point(271, 101);
            this.txtRemainder.Name = "txtRemainder";
            this.txtRemainder.ReadOnly = true;
            this.txtRemainder.Size = new System.Drawing.Size(150, 21);
            this.txtRemainder.TabIndex = 24;
            this.txtRemainder.TextChanged += new System.EventHandler(this.txtRemainder_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(427, 104);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "مانده:";
            // 
            // txtPrePayment
            // 
            this.txtPrePayment.Enabled = false;
            this.txtPrePayment.Location = new System.Drawing.Point(690, 101);
            this.txtPrePayment.Name = "txtPrePayment";
            this.txtPrePayment.Size = new System.Drawing.Size(150, 21);
            this.txtPrePayment.TabIndex = 10;
            this.txtPrePayment.TextChanged += new System.EventHandler(this.txtPrePayment_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(846, 104);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "پیش پرداخت:";
            // 
            // txtBank
            // 
            this.txtBank.Location = new System.Drawing.Point(20, 74);
            this.txtBank.Name = "txtBank";
            this.txtBank.Size = new System.Drawing.Size(150, 21);
            this.txtBank.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(176, 77);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "نام بانک:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(427, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "تاریخ وصول:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(522, 47);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(318, 21);
            this.txtAddress.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(846, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "آدرس:";
            // 
            // txtChequeOwner
            // 
            this.txtChequeOwner.Location = new System.Drawing.Point(690, 74);
            this.txtChequeOwner.Name = "txtChequeOwner";
            this.txtChequeOwner.Size = new System.Drawing.Size(150, 21);
            this.txtChequeOwner.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(846, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "نام صاحب چک:";
            // 
            // txtChequeNo
            // 
            this.txtChequeNo.Location = new System.Drawing.Point(20, 47);
            this.txtChequeNo.Name = "txtChequeNo";
            this.txtChequeNo.Size = new System.Drawing.Size(150, 21);
            this.txtChequeNo.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(176, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "شماره چک:";
            // 
            // txtFactorAmount
            // 
            this.txtFactorAmount.Location = new System.Drawing.Point(271, 47);
            this.txtFactorAmount.Name = "txtFactorAmount";
            this.txtFactorAmount.Size = new System.Drawing.Size(150, 21);
            this.txtFactorAmount.TabIndex = 5;
            this.txtFactorAmount.TextChanged += new System.EventHandler(this.txtFactorAmount_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(427, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "جمع فاکتور:";
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(20, 20);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(150, 21);
            this.txtTel.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(176, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "شماره تلفن:";
            // 
            // txtFamily
            // 
            this.txtFamily.Location = new System.Drawing.Point(271, 20);
            this.txtFamily.Name = "txtFamily";
            this.txtFamily.Size = new System.Drawing.Size(150, 21);
            this.txtFamily.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(427, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "نام خانوادگی:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(522, 20);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(150, 21);
            this.txtName.TabIndex = 1;
            // 
            // mtbDate
            // 
            this.mtbDate.Location = new System.Drawing.Point(730, 20);
            this.mtbDate.Mask = "00/00/0000";
            this.mtbDate.Name = "mtbDate";
            this.mtbDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mtbDate.Size = new System.Drawing.Size(110, 21);
            this.mtbDate.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(678, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "نام:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(846, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "تاریخ خرید:";
            // 
            // dgvInstallment
            // 
            this.dgvInstallment.AutoGenerateColumns = false;
            this.dgvInstallment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInstallment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.shopDateDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.familyDataGridViewTextBoxColumn,
            this.mobileDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.factorAmountDataGridViewTextBoxColumn,
            this.prePaymentDataGridViewTextBoxColumn,
            this.remainderDataGridViewTextBoxColumn,
            this.chequeNoDataGridViewTextBoxColumn,
            this.chequeOwnerDataGridViewTextBoxColumn,
            this.recieveDateDataGridViewTextBoxColumn});
            this.dgvInstallment.DataSource = this.installmentBindingSource;
            this.dgvInstallment.Location = new System.Drawing.Point(12, 197);
            this.dgvInstallment.Name = "dgvInstallment";
            this.dgvInstallment.ReadOnly = true;
            this.dgvInstallment.Size = new System.Drawing.Size(927, 460);
            this.dgvInstallment.TabIndex = 0;
            this.dgvInstallment.SelectionChanged += new System.EventHandler(this.dgvInstallment_SelectionChanged);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // shopDateDataGridViewTextBoxColumn
            // 
            this.shopDateDataGridViewTextBoxColumn.DataPropertyName = "ShopDate";
            this.shopDateDataGridViewTextBoxColumn.HeaderText = "تاریخ خرید";
            this.shopDateDataGridViewTextBoxColumn.Name = "shopDateDataGridViewTextBoxColumn";
            this.shopDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "نام";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // familyDataGridViewTextBoxColumn
            // 
            this.familyDataGridViewTextBoxColumn.DataPropertyName = "Family";
            this.familyDataGridViewTextBoxColumn.HeaderText = "نام خانوادگی";
            this.familyDataGridViewTextBoxColumn.Name = "familyDataGridViewTextBoxColumn";
            this.familyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mobileDataGridViewTextBoxColumn
            // 
            this.mobileDataGridViewTextBoxColumn.DataPropertyName = "Mobile";
            this.mobileDataGridViewTextBoxColumn.HeaderText = "موبایل";
            this.mobileDataGridViewTextBoxColumn.Name = "mobileDataGridViewTextBoxColumn";
            this.mobileDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "آدرس";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // factorAmountDataGridViewTextBoxColumn
            // 
            this.factorAmountDataGridViewTextBoxColumn.DataPropertyName = "FactorAmount";
            this.factorAmountDataGridViewTextBoxColumn.HeaderText = "جمع فاکتور";
            this.factorAmountDataGridViewTextBoxColumn.Name = "factorAmountDataGridViewTextBoxColumn";
            this.factorAmountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prePaymentDataGridViewTextBoxColumn
            // 
            this.prePaymentDataGridViewTextBoxColumn.DataPropertyName = "PrePayment";
            this.prePaymentDataGridViewTextBoxColumn.HeaderText = "پیش پرداخت";
            this.prePaymentDataGridViewTextBoxColumn.Name = "prePaymentDataGridViewTextBoxColumn";
            this.prePaymentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // remainderDataGridViewTextBoxColumn
            // 
            this.remainderDataGridViewTextBoxColumn.DataPropertyName = "Remainder";
            this.remainderDataGridViewTextBoxColumn.HeaderText = "مانده";
            this.remainderDataGridViewTextBoxColumn.Name = "remainderDataGridViewTextBoxColumn";
            this.remainderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // chequeNoDataGridViewTextBoxColumn
            // 
            this.chequeNoDataGridViewTextBoxColumn.DataPropertyName = "ChequeNo";
            this.chequeNoDataGridViewTextBoxColumn.HeaderText = "شماره چک";
            this.chequeNoDataGridViewTextBoxColumn.Name = "chequeNoDataGridViewTextBoxColumn";
            this.chequeNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // chequeOwnerDataGridViewTextBoxColumn
            // 
            this.chequeOwnerDataGridViewTextBoxColumn.DataPropertyName = "ChequeOwner";
            this.chequeOwnerDataGridViewTextBoxColumn.HeaderText = "صاحب چک";
            this.chequeOwnerDataGridViewTextBoxColumn.Name = "chequeOwnerDataGridViewTextBoxColumn";
            this.chequeOwnerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // recieveDateDataGridViewTextBoxColumn
            // 
            this.recieveDateDataGridViewTextBoxColumn.DataPropertyName = "RecieveDate";
            this.recieveDateDataGridViewTextBoxColumn.HeaderText = "تاریخ وصول";
            this.recieveDateDataGridViewTextBoxColumn.Name = "recieveDateDataGridViewTextBoxColumn";
            this.recieveDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // installmentBindingSource
            // 
            this.installmentBindingSource.DataMember = "installment";
            this.installmentBindingSource.DataSource = this.shopDataSet;
            // 
            // shopDataSet
            // 
            this.shopDataSet.DataSetName = "ShopDataSet";
            this.shopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // installmentTableAdapter
            // 
            this.installmentTableAdapter.ClearBeforeFill = true;
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Image = global::ShopSystem.Properties.Resources.save_alt;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.Location = new System.Drawing.Point(324, 157);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(103, 34);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "ذخیره";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDeleteRow
            // 
            this.btnDeleteRow.Enabled = false;
            this.btnDeleteRow.Image = global::ShopSystem.Properties.Resources.trash_full;
            this.btnDeleteRow.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteRow.Location = new System.Drawing.Point(215, 157);
            this.btnDeleteRow.Name = "btnDeleteRow";
            this.btnDeleteRow.Size = new System.Drawing.Size(103, 34);
            this.btnDeleteRow.TabIndex = 13;
            this.btnDeleteRow.Text = "حذف سطر";
            this.btnDeleteRow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteRow.UseVisualStyleBackColor = true;
            this.btnDeleteRow.Click += new System.EventHandler(this.btnDeleteRow_Click);
            // 
            // btnClear
            // 
            this.btnClear.Image = global::ShopSystem.Properties.Resources.arrow_circle_315;
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClear.Location = new System.Drawing.Point(106, 157);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(103, 34);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "تازه سازی فرم";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnClose
            // 
            this.btnClose.Image = global::ShopSystem.Properties.Resources.exitr4y;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.Location = new System.Drawing.Point(12, 157);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(88, 34);
            this.btnClose.TabIndex = 15;
            this.btnClose.Text = "انصراف";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmInstallment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 669);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDeleteRow);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.dgvInstallment);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmInstallment";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "قسط جدید";
            this.Load += new System.EventHandler(this.frmInstallment_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInstallment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.installmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvInstallment;
        private ShopDataSet shopDataSet;
        private System.Windows.Forms.BindingSource installmentBindingSource;
        private ShopDataSetTableAdapters.installmentTableAdapter installmentTableAdapter;
        private System.Windows.Forms.TextBox txtRemainder;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtPrePayment;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtBank;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtChequeOwner;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtChequeNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFactorAmount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFamily;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.MaskedTextBox mtbDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shopDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn familyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn factorAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prePaymentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remainderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chequeNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chequeOwnerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn recieveDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDeleteRow;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.MaskedTextBox txtRecieveDate;
    }
}