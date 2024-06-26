namespace Super_Market
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.StatusStrip MainStatus;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.LblUer = new System.Windows.Forms.ToolStripStatusLabel();
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.HeThongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đổiMậtKhẩuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýDanhMụcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loạiHàngHóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hàngHóaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.nhàCungCấpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bánHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lậpHóaĐơnBánHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lậpHóaĐơnNhậpHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêHóaĐơnNhậpHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêHóaĐơnBánHàngToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêHàngTồnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýNhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TroGiupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            MainStatus = new System.Windows.Forms.StatusStrip();
            MainStatus.SuspendLayout();
            this.MainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainStatus
            // 
            MainStatus.AllowDrop = true;
            MainStatus.AutoSize = false;
            MainStatus.ImageScalingSize = new System.Drawing.Size(24, 24);
            MainStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LblUer});
            MainStatus.Location = new System.Drawing.Point(0, 754);
            MainStatus.Name = "MainStatus";
            MainStatus.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            MainStatus.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            MainStatus.RightToLeft = System.Windows.Forms.RightToLeft.No;
            MainStatus.Size = new System.Drawing.Size(1146, 34);
            MainStatus.TabIndex = 2;
            MainStatus.Text = "MainStatus";
            // 
            // LblUer
            // 
            this.LblUer.Name = "LblUer";
            this.LblUer.Size = new System.Drawing.Size(109, 29);
            this.LblUer.Text = "Đăng nhập: ";
            // 
            // MainMenu
            // 
            this.MainMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HeThongToolStripMenuItem,
            this.quảnLýDanhMụcToolStripMenuItem,
            this.bánHàngToolStripMenuItem,
            this.báoCáoToolStripMenuItem,
            this.nhânViênToolStripMenuItem,
            this.TroGiupToolStripMenuItem,
            this.toolStripMenuItem1});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.MainMenu.Size = new System.Drawing.Size(1146, 35);
            this.MainMenu.TabIndex = 1;
            this.MainMenu.Text = "menuStrip1";
            this.MainMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MainMenu_ItemClicked);
            // 
            // HeThongToolStripMenuItem
            // 
            this.HeThongToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đổiMậtKhẩuToolStripMenuItem,
            this.loginToolStripMenuItem,
            this.logoutToolStripMenuItem,
            this.thoatToolStripMenuItem});
            this.HeThongToolStripMenuItem.Name = "HeThongToolStripMenuItem";
            this.HeThongToolStripMenuItem.Size = new System.Drawing.Size(99, 29);
            this.HeThongToolStripMenuItem.Text = "&Hệ thống";
            // 
            // đổiMậtKhẩuToolStripMenuItem
            // 
            this.đổiMậtKhẩuToolStripMenuItem.Name = "đổiMậtKhẩuToolStripMenuItem";
            this.đổiMậtKhẩuToolStripMenuItem.Size = new System.Drawing.Size(203, 30);
            this.đổiMậtKhẩuToolStripMenuItem.Text = "Đổi mật khẩu";
            this.đổiMậtKhẩuToolStripMenuItem.Click += new System.EventHandler(this.đổiMậtKhẩuToolStripMenuItem_Click);
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(203, 30);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(203, 30);
            this.logoutToolStripMenuItem.Text = "&Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // thoatToolStripMenuItem
            // 
            this.thoatToolStripMenuItem.Name = "thoatToolStripMenuItem";
            this.thoatToolStripMenuItem.Size = new System.Drawing.Size(203, 30);
            this.thoatToolStripMenuItem.Text = "&Thoát";
            this.thoatToolStripMenuItem.Click += new System.EventHandler(this.thoatToolStripMenuItem_Click);
            // 
            // quảnLýDanhMụcToolStripMenuItem
            // 
            this.quảnLýDanhMụcToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loạiHàngHóaToolStripMenuItem,
            this.hàngHóaToolStripMenuItem1,
            this.nhàCungCấpToolStripMenuItem});
            this.quảnLýDanhMụcToolStripMenuItem.Name = "quảnLýDanhMụcToolStripMenuItem";
            this.quảnLýDanhMụcToolStripMenuItem.Size = new System.Drawing.Size(169, 29);
            this.quảnLýDanhMụcToolStripMenuItem.Text = "Quản lý danh mục";
            // 
            // loạiHàngHóaToolStripMenuItem
            // 
            this.loạiHàngHóaToolStripMenuItem.Name = "loạiHàngHóaToolStripMenuItem";
            this.loạiHàngHóaToolStripMenuItem.Size = new System.Drawing.Size(208, 30);
            this.loạiHàngHóaToolStripMenuItem.Text = "Loại hàng hóa";
            this.loạiHàngHóaToolStripMenuItem.Click += new System.EventHandler(this.loạiHàngHóaToolStripMenuItem_Click);
            // 
            // hàngHóaToolStripMenuItem1
            // 
            this.hàngHóaToolStripMenuItem1.Name = "hàngHóaToolStripMenuItem1";
            this.hàngHóaToolStripMenuItem1.Size = new System.Drawing.Size(208, 30);
            this.hàngHóaToolStripMenuItem1.Text = "Hàng hóa";
            this.hàngHóaToolStripMenuItem1.Click += new System.EventHandler(this.hàngHóaToolStripMenuItem1_Click);
            // 
            // nhàCungCấpToolStripMenuItem
            // 
            this.nhàCungCấpToolStripMenuItem.Name = "nhàCungCấpToolStripMenuItem";
            this.nhàCungCấpToolStripMenuItem.Size = new System.Drawing.Size(208, 30);
            this.nhàCungCấpToolStripMenuItem.Text = "Nhà cung cấp";
            this.nhàCungCấpToolStripMenuItem.Click += new System.EventHandler(this.nhàCungCấpToolStripMenuItem_Click);
            // 
            // bánHàngToolStripMenuItem
            // 
            this.bánHàngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lậpHóaĐơnBánHàngToolStripMenuItem,
            this.lậpHóaĐơnNhậpHàngToolStripMenuItem});
            this.bánHàngToolStripMenuItem.Name = "bánHàngToolStripMenuItem";
            this.bánHàngToolStripMenuItem.Size = new System.Drawing.Size(170, 29);
            this.bánHàngToolStripMenuItem.Text = "Nhập - Bán - hàng";
            this.bánHàngToolStripMenuItem.Click += new System.EventHandler(this.bánHàngToolStripMenuItem_Click);
            // 
            // lậpHóaĐơnBánHàngToolStripMenuItem
            // 
            this.lậpHóaĐơnBánHàngToolStripMenuItem.Name = "lậpHóaĐơnBánHàngToolStripMenuItem";
            this.lậpHóaĐơnBánHàngToolStripMenuItem.Size = new System.Drawing.Size(286, 30);
            this.lậpHóaĐơnBánHàngToolStripMenuItem.Text = "Lập hóa đơn bán hàng";
            this.lậpHóaĐơnBánHàngToolStripMenuItem.Click += new System.EventHandler(this.lậpHóaĐơnBánHàngToolStripMenuItem_Click);
            // 
            // lậpHóaĐơnNhậpHàngToolStripMenuItem
            // 
            this.lậpHóaĐơnNhậpHàngToolStripMenuItem.Name = "lậpHóaĐơnNhậpHàngToolStripMenuItem";
            this.lậpHóaĐơnNhậpHàngToolStripMenuItem.Size = new System.Drawing.Size(286, 30);
            this.lậpHóaĐơnNhậpHàngToolStripMenuItem.Text = "Lập hóa đơn nhập hàng";
            this.lậpHóaĐơnNhậpHàngToolStripMenuItem.Click += new System.EventHandler(this.lậpHóaĐơnNhậpHàngToolStripMenuItem_Click);
            // 
            // báoCáoToolStripMenuItem
            // 
            this.báoCáoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thốngKêHóaĐơnNhậpHàngToolStripMenuItem,
            this.thốngKêHóaĐơnBánHàngToolStripMenuItem1,
            this.thốngKêHàngTồnToolStripMenuItem});
            this.báoCáoToolStripMenuItem.Name = "báoCáoToolStripMenuItem";
            this.báoCáoToolStripMenuItem.Size = new System.Drawing.Size(87, 29);
            this.báoCáoToolStripMenuItem.Text = "Báo cáo";
            // 
            // thốngKêHóaĐơnNhậpHàngToolStripMenuItem
            // 
            this.thốngKêHóaĐơnNhậpHàngToolStripMenuItem.Name = "thốngKêHóaĐơnNhậpHàngToolStripMenuItem";
            this.thốngKêHóaĐơnNhậpHàngToolStripMenuItem.Size = new System.Drawing.Size(332, 30);
            this.thốngKêHóaĐơnNhậpHàngToolStripMenuItem.Text = "Thống kê hóa đơn nhập hàng";
            this.thốngKêHóaĐơnNhậpHàngToolStripMenuItem.Click += new System.EventHandler(this.thốngKêHóaĐơnNhậpHàngToolStripMenuItem_Click);
            // 
            // thốngKêHóaĐơnBánHàngToolStripMenuItem1
            // 
            this.thốngKêHóaĐơnBánHàngToolStripMenuItem1.Name = "thốngKêHóaĐơnBánHàngToolStripMenuItem1";
            this.thốngKêHóaĐơnBánHàngToolStripMenuItem1.Size = new System.Drawing.Size(332, 30);
            this.thốngKêHóaĐơnBánHàngToolStripMenuItem1.Text = "Thống kê hóa đơn bán hàng";
            this.thốngKêHóaĐơnBánHàngToolStripMenuItem1.Click += new System.EventHandler(this.thốngKêHóaĐơnBánHàngToolStripMenuItem1_Click);
            // 
            // thốngKêHàngTồnToolStripMenuItem
            // 
            this.thốngKêHàngTồnToolStripMenuItem.Name = "thốngKêHàngTồnToolStripMenuItem";
            this.thốngKêHàngTồnToolStripMenuItem.Size = new System.Drawing.Size(332, 30);
            this.thốngKêHàngTồnToolStripMenuItem.Text = "Thống kê hàng tồn";
            this.thốngKêHàngTồnToolStripMenuItem.Click += new System.EventHandler(this.thốngKêHàngTồnToolStripMenuItem_Click);
            // 
            // nhânViênToolStripMenuItem
            // 
            this.nhânViênToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýNhânViênToolStripMenuItem});
            this.nhânViênToolStripMenuItem.Name = "nhânViênToolStripMenuItem";
            this.nhânViênToolStripMenuItem.Size = new System.Drawing.Size(103, 29);
            this.nhânViênToolStripMenuItem.Text = "Nhân viên";
            // 
            // quảnLýNhânViênToolStripMenuItem
            // 
            this.quảnLýNhânViênToolStripMenuItem.Name = "quảnLýNhânViênToolStripMenuItem";
            this.quảnLýNhânViênToolStripMenuItem.Size = new System.Drawing.Size(238, 30);
            this.quảnLýNhânViênToolStripMenuItem.Text = "Quản lý nhân viên";
            this.quảnLýNhânViênToolStripMenuItem.Click += new System.EventHandler(this.quảnLýNhânViênToolStripMenuItem_Click);
            // 
            // TroGiupToolStripMenuItem
            // 
            this.TroGiupToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.TroGiupToolStripMenuItem.Name = "TroGiupToolStripMenuItem";
            this.TroGiupToolStripMenuItem.Size = new System.Drawing.Size(89, 29);
            this.TroGiupToolStripMenuItem.Text = "Trợ &giúp";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(146, 30);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(231, 17);
            this.toolStripStatusLabel1.Text = "Super Market Management Version 1.0";
            this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Finder.ico");
            this.imageList1.Images.SetKeyName(1, "Apps.ico");
            this.imageList1.Images.SetKeyName(2, "Applications.ico");
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(182, 29);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 788);
            this.Controls.Add(MainStatus);
            this.Controls.Add(this.MainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MainMenu;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMain";
            this.Text = "Quản lý bán hàng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            MainStatus.ResumeLayout(false);
            MainStatus.PerformLayout();
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripMenuItem HeThongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TroGiupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýDanhMụcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhàCungCấpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bánHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lậpHóaĐơnBánHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem báoCáoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêHóaĐơnNhậpHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýNhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loạiHàngHóaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hàngHóaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripStatusLabel LblUer;
        private System.Windows.Forms.ToolStripMenuItem đổiMậtKhẩuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lậpHóaĐơnNhậpHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêHóaĐơnBánHàngToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem thốngKêHàngTồnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}

