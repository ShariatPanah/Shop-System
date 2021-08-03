namespace ShopSystem
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnShopping = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSell = new System.Windows.Forms.ToolStripMenuItem();
            this.btnReports = new System.Windows.Forms.ToolStripMenuItem();
            this.btnProfit = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPaymentReport = new System.Windows.Forms.ToolStripMenuItem();
            this.اقساطToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNewInstallment = new System.Windows.Forms.ToolStripMenuItem();
            this.پرداختاقساطToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnTelBook = new System.Windows.Forms.ToolStripMenuItem();
            this.btnUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnShopping,
            this.btnSell,
            this.btnReports,
            this.اقساطToolStripMenuItem,
            this.btnTelBook,
            this.btnUsers,
            this.btnExit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(850, 74);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnShopping
            // 
            this.btnShopping.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShopping.Image = global::ShopSystem.Properties.Resources.Shopping;
            this.btnShopping.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnShopping.Name = "btnShopping";
            this.btnShopping.Size = new System.Drawing.Size(60, 70);
            this.btnShopping.Text = "خرید";
            this.btnShopping.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnShopping.Click += new System.EventHandler(this.btnShopping_Click);
            // 
            // btnSell
            // 
            this.btnSell.Image = global::ShopSystem.Properties.Resources.shoping_basket1;
            this.btnSell.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(60, 70);
            this.btnSell.Text = "فروش";
            this.btnSell.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSell.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSell.Click += new System.EventHandler(this.btnSell_Click);
            // 
            // btnReports
            // 
            this.btnReports.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnProfit,
            this.btnPaymentReport});
            this.btnReports.Image = ((System.Drawing.Image)(resources.GetObject("btnReports.Image")));
            this.btnReports.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnReports.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(74, 70);
            this.btnReports.Text = "گزارشات";
            this.btnReports.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReports.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnProfit
            // 
            this.btnProfit.Image = global::ShopSystem.Properties.Resources._1418837499_line_chart;
            this.btnProfit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnProfit.Name = "btnProfit";
            this.btnProfit.Size = new System.Drawing.Size(261, 56);
            this.btnProfit.Text = "گزارش میزان سود و زیان";
            this.btnProfit.Click += new System.EventHandler(this.btnProfit_Click);
            // 
            // btnPaymentReport
            // 
            this.btnPaymentReport.Image = global::ShopSystem.Properties.Resources._1418837488_safe;
            this.btnPaymentReport.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnPaymentReport.Name = "btnPaymentReport";
            this.btnPaymentReport.Size = new System.Drawing.Size(261, 56);
            this.btnPaymentReport.Text = "گزارش پرداخت اقساط";
            this.btnPaymentReport.Click += new System.EventHandler(this.btnPaymentReport_Click);
            // 
            // اقساطToolStripMenuItem
            // 
            this.اقساطToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNewInstallment,
            this.پرداختاقساطToolStripMenuItem});
            this.اقساطToolStripMenuItem.Image = global::ShopSystem.Properties.Resources.CashBox2;
            this.اقساطToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.اقساطToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.اقساطToolStripMenuItem.Name = "اقساطToolStripMenuItem";
            this.اقساطToolStripMenuItem.Size = new System.Drawing.Size(62, 70);
            this.اقساطToolStripMenuItem.Text = "اقساط";
            this.اقساطToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.اقساطToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnNewInstallment
            // 
            this.btnNewInstallment.Image = global::ShopSystem.Properties.Resources._27_edit_text;
            this.btnNewInstallment.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnNewInstallment.Name = "btnNewInstallment";
            this.btnNewInstallment.Size = new System.Drawing.Size(216, 56);
            this.btnNewInstallment.Text = "تعریف قسط جدید";
            this.btnNewInstallment.Click += new System.EventHandler(this.btnNewInstallment_Click);
            // 
            // پرداختاقساطToolStripMenuItem
            // 
            this.پرداختاقساطToolStripMenuItem.Image = global::ShopSystem.Properties.Resources._1418836996_cash_register2;
            this.پرداختاقساطToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.پرداختاقساطToolStripMenuItem.Name = "پرداختاقساطToolStripMenuItem";
            this.پرداختاقساطToolStripMenuItem.Size = new System.Drawing.Size(216, 56);
            this.پرداختاقساطToolStripMenuItem.Text = "پرداخت اقساط";
            this.پرداختاقساطToolStripMenuItem.Click += new System.EventHandler(this.پرداختاقساطToolStripMenuItem_Click);
            // 
            // btnTelBook
            // 
            this.btnTelBook.Image = global::ShopSystem.Properties.Resources.user_48;
            this.btnTelBook.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTelBook.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnTelBook.Name = "btnTelBook";
            this.btnTelBook.Size = new System.Drawing.Size(96, 70);
            this.btnTelBook.Text = "دفترچه تلفن";
            this.btnTelBook.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTelBook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTelBook.Click += new System.EventHandler(this.btnTelBook_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.Image = global::ShopSystem.Properties.Resources.user1;
            this.btnUsers.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUsers.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(62, 70);
            this.btnUsers.Text = "کاربران";
            this.btnUsers.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUsers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnExit
            // 
            this.btnExit.Image = global::ShopSystem.Properties.Resources.fsgfdr;
            this.btnExit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(60, 70);
            this.btnExit.Text = "خروج";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(850, 498);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "سیستم مدیریت فروشگاه";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem btnShopping;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnExit;
        private System.Windows.Forms.ToolStripMenuItem btnUsers;
        private System.Windows.Forms.ToolStripMenuItem btnSell;
        private System.Windows.Forms.ToolStripMenuItem btnTelBook;
        private System.Windows.Forms.ToolStripMenuItem btnReports;
        private System.Windows.Forms.ToolStripMenuItem btnProfit;
        private System.Windows.Forms.ToolStripMenuItem اقساطToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnNewInstallment;
        private System.Windows.Forms.ToolStripMenuItem پرداختاقساطToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnPaymentReport;
    }
}