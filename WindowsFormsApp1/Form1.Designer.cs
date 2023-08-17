
namespace WindowsFormsApp1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel3 = new Bunifu.UI.WinForms.BunifuLabel();
            this.admin = new System.Windows.Forms.Button();
            this.panelAdmin = new System.Windows.Forms.Panel();
            this.manageBox = new System.Windows.Forms.Button();
            this.adminBtn2 = new System.Windows.Forms.Button();
            this.adminProductBtn = new System.Windows.Forms.Button();
            this.Stock = new System.Windows.Forms.Button();
            this.panelStock = new System.Windows.Forms.Panel();
            this.stockBtn3 = new System.Windows.Forms.Button();
            this.stockBtn1 = new System.Windows.Forms.Button();
            this.panelSampingUtama = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.bunifuLabel9 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel8 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuPictureBox1 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.panelDashboard = new System.Windows.Forms.Panel();
            this.logo = new Bunifu.UI.WinForms.BunifuLabel();
            this.informationLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel4 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel5 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel6 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel7 = new Bunifu.UI.WinForms.BunifuLabel();
            this.dashboardPanel = new Bunifu.UI.WinForms.BunifuPanel();
            this.panelAdmin.SuspendLayout();
            this.panelStock.SuspendLayout();
            this.panelSampingUtama.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.CursorType = null;
            this.bunifuLabel1.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.bunifuLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuLabel1.Location = new System.Drawing.Point(12, 90);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(39, 45);
            this.bunifuLabel1.TabIndex = 11;
            this.bunifuLabel1.Text = "ID: ";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.bunifuLabel1.Click += new System.EventHandler(this.bunifuLabel1_Click);
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AllowParentOverrides = false;
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.CursorType = null;
            this.bunifuLabel2.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.bunifuLabel2.ForeColor = System.Drawing.Color.White;
            this.bunifuLabel2.Location = new System.Drawing.Point(12, 149);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(104, 45);
            this.bunifuLabel2.TabIndex = 12;
            this.bunifuLabel2.Text = "NAMA: ";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel3
            // 
            this.bunifuLabel3.AllowParentOverrides = false;
            this.bunifuLabel3.AutoEllipsis = false;
            this.bunifuLabel3.CursorType = null;
            this.bunifuLabel3.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.bunifuLabel3.ForeColor = System.Drawing.Color.White;
            this.bunifuLabel3.Location = new System.Drawing.Point(9, 211);
            this.bunifuLabel3.Name = "bunifuLabel3";
            this.bunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel3.Size = new System.Drawing.Size(132, 45);
            this.bunifuLabel3.TabIndex = 13;
            this.bunifuLabel3.Text = "JUMLAH: ";
            this.bunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // admin
            // 
            this.admin.Dock = System.Windows.Forms.DockStyle.Top;
            this.admin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.admin.ForeColor = System.Drawing.Color.White;
            this.admin.Location = new System.Drawing.Point(0, 100);
            this.admin.Name = "admin";
            this.admin.Size = new System.Drawing.Size(200, 23);
            this.admin.TabIndex = 2;
            this.admin.Text = "Admin";
            this.admin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.admin.UseVisualStyleBackColor = true;
            this.admin.Click += new System.EventHandler(this.admin_Click);
            // 
            // panelAdmin
            // 
            this.panelAdmin.BackColor = System.Drawing.Color.Black;
            this.panelAdmin.Controls.Add(this.manageBox);
            this.panelAdmin.Controls.Add(this.adminBtn2);
            this.panelAdmin.Controls.Add(this.adminProductBtn);
            this.panelAdmin.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAdmin.Location = new System.Drawing.Point(0, 123);
            this.panelAdmin.Name = "panelAdmin";
            this.panelAdmin.Size = new System.Drawing.Size(200, 72);
            this.panelAdmin.TabIndex = 3;
            // 
            // manageBox
            // 
            this.manageBox.BackColor = System.Drawing.Color.DimGray;
            this.manageBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.manageBox.FlatAppearance.BorderSize = 0;
            this.manageBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manageBox.ForeColor = System.Drawing.Color.White;
            this.manageBox.Location = new System.Drawing.Point(0, 48);
            this.manageBox.Name = "manageBox";
            this.manageBox.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.manageBox.Size = new System.Drawing.Size(200, 25);
            this.manageBox.TabIndex = 2;
            this.manageBox.Text = "Manage User";
            this.manageBox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.manageBox.UseVisualStyleBackColor = false;
            this.manageBox.Click += new System.EventHandler(this.manageBox_Click);
            // 
            // adminBtn2
            // 
            this.adminBtn2.BackColor = System.Drawing.Color.DimGray;
            this.adminBtn2.Dock = System.Windows.Forms.DockStyle.Top;
            this.adminBtn2.FlatAppearance.BorderSize = 0;
            this.adminBtn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminBtn2.ForeColor = System.Drawing.Color.White;
            this.adminBtn2.Location = new System.Drawing.Point(0, 23);
            this.adminBtn2.Name = "adminBtn2";
            this.adminBtn2.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.adminBtn2.Size = new System.Drawing.Size(200, 25);
            this.adminBtn2.TabIndex = 1;
            this.adminBtn2.Text = "Supplier";
            this.adminBtn2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.adminBtn2.UseVisualStyleBackColor = false;
            this.adminBtn2.Click += new System.EventHandler(this.adminBtn2_Click);
            // 
            // adminProductBtn
            // 
            this.adminProductBtn.BackColor = System.Drawing.Color.DimGray;
            this.adminProductBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.adminProductBtn.FlatAppearance.BorderSize = 0;
            this.adminProductBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminProductBtn.ForeColor = System.Drawing.Color.White;
            this.adminProductBtn.Location = new System.Drawing.Point(0, 0);
            this.adminProductBtn.Name = "adminProductBtn";
            this.adminProductBtn.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.adminProductBtn.Size = new System.Drawing.Size(200, 23);
            this.adminProductBtn.TabIndex = 0;
            this.adminProductBtn.Text = "Produk";
            this.adminProductBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.adminProductBtn.UseVisualStyleBackColor = false;
            this.adminProductBtn.Click += new System.EventHandler(this.adminProductBtn_Click);
            // 
            // Stock
            // 
            this.Stock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Stock.ForeColor = System.Drawing.Color.White;
            this.Stock.Location = new System.Drawing.Point(0, 194);
            this.Stock.Name = "Stock";
            this.Stock.Size = new System.Drawing.Size(200, 23);
            this.Stock.TabIndex = 4;
            this.Stock.Text = "Karyawan";
            this.Stock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Stock.UseVisualStyleBackColor = true;
            this.Stock.Click += new System.EventHandler(this.Stock_Click);
            // 
            // panelStock
            // 
            this.panelStock.BackColor = System.Drawing.Color.Black;
            this.panelStock.Controls.Add(this.stockBtn3);
            this.panelStock.Controls.Add(this.stockBtn1);
            this.panelStock.Location = new System.Drawing.Point(0, 216);
            this.panelStock.Name = "panelStock";
            this.panelStock.Size = new System.Drawing.Size(200, 39);
            this.panelStock.TabIndex = 5;
            this.panelStock.Paint += new System.Windows.Forms.PaintEventHandler(this.panelStock_Paint);
            // 
            // stockBtn3
            // 
            this.stockBtn3.BackColor = System.Drawing.Color.DimGray;
            this.stockBtn3.FlatAppearance.BorderSize = 0;
            this.stockBtn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stockBtn3.ForeColor = System.Drawing.Color.White;
            this.stockBtn3.Location = new System.Drawing.Point(0, 20);
            this.stockBtn3.Name = "stockBtn3";
            this.stockBtn3.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.stockBtn3.Size = new System.Drawing.Size(200, 21);
            this.stockBtn3.TabIndex = 2;
            this.stockBtn3.Text = "Gudang";
            this.stockBtn3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.stockBtn3.UseVisualStyleBackColor = false;
            this.stockBtn3.Click += new System.EventHandler(this.stockBtn3_Click);
            // 
            // stockBtn1
            // 
            this.stockBtn1.BackColor = System.Drawing.Color.DimGray;
            this.stockBtn1.FlatAppearance.BorderSize = 0;
            this.stockBtn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stockBtn1.ForeColor = System.Drawing.Color.White;
            this.stockBtn1.Location = new System.Drawing.Point(0, 0);
            this.stockBtn1.Name = "stockBtn1";
            this.stockBtn1.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.stockBtn1.Size = new System.Drawing.Size(200, 23);
            this.stockBtn1.TabIndex = 0;
            this.stockBtn1.Text = "Kasir";
            this.stockBtn1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.stockBtn1.UseVisualStyleBackColor = false;
            this.stockBtn1.Click += new System.EventHandler(this.stockBtn1_Click);
            // 
            // panelSampingUtama
            // 
            this.panelSampingUtama.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panelSampingUtama.Controls.Add(this.panelStock);
            this.panelSampingUtama.Controls.Add(this.Stock);
            this.panelSampingUtama.Controls.Add(this.panelAdmin);
            this.panelSampingUtama.Controls.Add(this.admin);
            this.panelSampingUtama.Controls.Add(this.panelLogo);
            this.panelSampingUtama.Location = new System.Drawing.Point(0, 0);
            this.panelSampingUtama.Name = "panelSampingUtama";
            this.panelSampingUtama.Size = new System.Drawing.Size(200, 353);
            this.panelSampingUtama.TabIndex = 0;
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panelLogo.Controls.Add(this.bunifuLabel9);
            this.panelLogo.Controls.Add(this.bunifuLabel8);
            this.panelLogo.Controls.Add(this.bunifuPictureBox1);
            this.panelLogo.Controls.Add(this.panelDashboard);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(200, 100);
            this.panelLogo.TabIndex = 1;
            // 
            // bunifuLabel9
            // 
            this.bunifuLabel9.AllowParentOverrides = false;
            this.bunifuLabel9.AutoEllipsis = false;
            this.bunifuLabel9.CursorType = null;
            this.bunifuLabel9.Font = new System.Drawing.Font("Segoe UI", 11.11F);
            this.bunifuLabel9.ForeColor = System.Drawing.Color.White;
            this.bunifuLabel9.Location = new System.Drawing.Point(112, 51);
            this.bunifuLabel9.Name = "bunifuLabel9";
            this.bunifuLabel9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel9.Size = new System.Drawing.Size(64, 20);
            this.bunifuLabel9.TabIndex = 3;
            this.bunifuLabel9.Text = "Karyawan";
            this.bunifuLabel9.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel9.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel8
            // 
            this.bunifuLabel8.AllowParentOverrides = false;
            this.bunifuLabel8.AutoEllipsis = false;
            this.bunifuLabel8.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel8.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel8.Font = new System.Drawing.Font("Segoe UI", 11.13F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel8.ForeColor = System.Drawing.Color.White;
            this.bunifuLabel8.Location = new System.Drawing.Point(98, 22);
            this.bunifuLabel8.Name = "bunifuLabel8";
            this.bunifuLabel8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel8.Size = new System.Drawing.Size(93, 23);
            this.bunifuLabel8.TabIndex = 3;
            this.bunifuLabel8.Text = "Reva Athira";
            this.bunifuLabel8.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel8.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuPictureBox1
            // 
            this.bunifuPictureBox1.AllowFocused = false;
            this.bunifuPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuPictureBox1.AutoSizeHeight = true;
            this.bunifuPictureBox1.BorderRadius = 35;
            this.bunifuPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuPictureBox1.Image")));
            this.bunifuPictureBox1.IsCircle = true;
            this.bunifuPictureBox1.Location = new System.Drawing.Point(12, 12);
            this.bunifuPictureBox1.Name = "bunifuPictureBox1";
            this.bunifuPictureBox1.Size = new System.Drawing.Size(70, 70);
            this.bunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox1.TabIndex = 2;
            this.bunifuPictureBox1.TabStop = false;
            this.bunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // panelDashboard
            // 
            this.panelDashboard.Location = new System.Drawing.Point(206, 3);
            this.panelDashboard.Name = "panelDashboard";
            this.panelDashboard.Size = new System.Drawing.Size(523, 350);
            this.panelDashboard.TabIndex = 1;
            // 
            // logo
            // 
            this.logo.AllowParentOverrides = false;
            this.logo.AutoEllipsis = false;
            this.logo.CursorType = null;
            this.logo.Font = new System.Drawing.Font("Stencil", 18F);
            this.logo.ForeColor = System.Drawing.Color.White;
            this.logo.Location = new System.Drawing.Point(58, 29);
            this.logo.Name = "logo";
            this.logo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.logo.Size = new System.Drawing.Size(58, 29);
            this.logo.TabIndex = 4;
            this.logo.Text = "LOGO";
            this.logo.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.logo.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.logo.Click += new System.EventHandler(this.logo_Click);
            // 
            // informationLabel
            // 
            this.informationLabel.AllowParentOverrides = false;
            this.informationLabel.AutoEllipsis = false;
            this.informationLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.informationLabel.CursorType = System.Windows.Forms.Cursors.Default;
            this.informationLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.informationLabel.ForeColor = System.Drawing.Color.White;
            this.informationLabel.Location = new System.Drawing.Point(139, 8);
            this.informationLabel.Name = "informationLabel";
            this.informationLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.informationLabel.Size = new System.Drawing.Size(224, 89);
            this.informationLabel.TabIndex = 7;
            this.informationLabel.Text = "AAAAAAAAAAAAAAAAAAAAAAAAAAAA\r\nAAAAAAAAAAAAAAAAAAAAAAAAAAAA\r\nAAAAAAAAAAAAAAAAAAAAA" +
    "AAAAAAA\r\nAAAAAAAAAAAAAAAAAAAAAAAAAAAA\r\nAAAAAAAAAAAAAAAAAAAAAAAAAAAA\r\n\r\n";
            this.informationLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.informationLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.informationLabel.Click += new System.EventHandler(this.informationLabel_Click);
            // 
            // bunifuLabel4
            // 
            this.bunifuLabel4.AllowParentOverrides = false;
            this.bunifuLabel4.AutoEllipsis = false;
            this.bunifuLabel4.CursorType = null;
            this.bunifuLabel4.Font = new System.Drawing.Font("Stencil", 36F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel4.ForeColor = System.Drawing.Color.White;
            this.bunifuLabel4.Location = new System.Drawing.Point(174, 3);
            this.bunifuLabel4.Name = "bunifuLabel4";
            this.bunifuLabel4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel4.Size = new System.Drawing.Size(199, 57);
            this.bunifuLabel4.TabIndex = 0;
            this.bunifuLabel4.Text = "PRODUK";
            this.bunifuLabel4.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel4.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel5
            // 
            this.bunifuLabel5.AllowParentOverrides = false;
            this.bunifuLabel5.AutoEllipsis = false;
            this.bunifuLabel5.CursorType = null;
            this.bunifuLabel5.Font = new System.Drawing.Font("Segoe UI", 14.18F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel5.ForeColor = System.Drawing.Color.White;
            this.bunifuLabel5.Location = new System.Drawing.Point(11, 76);
            this.bunifuLabel5.Name = "bunifuLabel5";
            this.bunifuLabel5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel5.Size = new System.Drawing.Size(33, 32);
            this.bunifuLabel5.TabIndex = 1;
            this.bunifuLabel5.Text = "ID: ";
            this.bunifuLabel5.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel5.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel6
            // 
            this.bunifuLabel6.AllowParentOverrides = false;
            this.bunifuLabel6.AutoEllipsis = false;
            this.bunifuLabel6.CursorType = null;
            this.bunifuLabel6.Font = new System.Drawing.Font("Segoe UI", 14.18F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel6.ForeColor = System.Drawing.Color.White;
            this.bunifuLabel6.Location = new System.Drawing.Point(12, 113);
            this.bunifuLabel6.Name = "bunifuLabel6";
            this.bunifuLabel6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel6.Size = new System.Drawing.Size(83, 32);
            this.bunifuLabel6.TabIndex = 2;
            this.bunifuLabel6.Text = "NAMA: ";
            this.bunifuLabel6.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel6.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel7
            // 
            this.bunifuLabel7.AllowParentOverrides = false;
            this.bunifuLabel7.AutoEllipsis = false;
            this.bunifuLabel7.CursorType = null;
            this.bunifuLabel7.Font = new System.Drawing.Font("Segoe UI", 14.18F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel7.ForeColor = System.Drawing.Color.White;
            this.bunifuLabel7.Location = new System.Drawing.Point(12, 151);
            this.bunifuLabel7.Name = "bunifuLabel7";
            this.bunifuLabel7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel7.Size = new System.Drawing.Size(105, 32);
            this.bunifuLabel7.TabIndex = 3;
            this.bunifuLabel7.Text = "JUMLAH: ";
            this.bunifuLabel7.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel7.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.bunifuLabel7.Click += new System.EventHandler(this.bunifuLabel7_Click);
            // 
            // dashboardPanel
            // 
            this.dashboardPanel.BackgroundColor = System.Drawing.Color.Transparent;
            this.dashboardPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dashboardPanel.BackgroundImage")));
            this.dashboardPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dashboardPanel.BorderColor = System.Drawing.Color.Transparent;
            this.dashboardPanel.BorderRadius = 3;
            this.dashboardPanel.BorderThickness = 1;
            this.dashboardPanel.Location = new System.Drawing.Point(199, 0);
            this.dashboardPanel.Name = "dashboardPanel";
            this.dashboardPanel.ShowBorders = true;
            this.dashboardPanel.Size = new System.Drawing.Size(624, 353);
            this.dashboardPanel.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(822, 353);
            this.Controls.Add(this.dashboardPanel);
            this.Controls.Add(this.panelSampingUtama);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Fay.d Medicine";
            this.panelAdmin.ResumeLayout(false);
            this.panelStock.ResumeLayout(false);
            this.panelSampingUtama.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel3;
        private System.Windows.Forms.Button admin;
        private System.Windows.Forms.Panel panelAdmin;
        private System.Windows.Forms.Button adminProductBtn;
        private System.Windows.Forms.Button Stock;
        private System.Windows.Forms.Panel panelStock;
        private System.Windows.Forms.Button stockBtn1;
        private System.Windows.Forms.Panel panelSampingUtama;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelDashboard;
        private Bunifu.UI.WinForms.BunifuLabel logo;
        private Bunifu.UI.WinForms.BunifuLabel informationLabel;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel4;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel5;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel6;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel7;
        private Bunifu.UI.WinForms.BunifuPanel dashboardPanel;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel9;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel8;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox1;
        private System.Windows.Forms.Button stockBtn3;
        private System.Windows.Forms.Button manageBox;
        private System.Windows.Forms.Button adminBtn2;
    }
}

