namespace Super_Market
{
    partial class frmDoiMatKhau    {
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
            this.PanelLogin = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCurrPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnDoi = new System.Windows.Forms.Button();
            this.txtNewPass2 = new System.Windows.Forms.TextBox();
            this.LabelPassword = new System.Windows.Forms.Label();
            this.txtNewPass1 = new System.Windows.Forms.TextBox();
            this.PanelLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelLogin
            // 
            this.PanelLogin.BackColor = System.Drawing.SystemColors.Window;
            this.PanelLogin.Controls.Add(this.label2);
            this.PanelLogin.Controls.Add(this.txtCurrPass);
            this.PanelLogin.Controls.Add(this.label1);
            this.PanelLogin.Controls.Add(this.btnThoat);
            this.PanelLogin.Controls.Add(this.btnDoi);
            this.PanelLogin.Controls.Add(this.txtNewPass2);
            this.PanelLogin.Controls.Add(this.LabelPassword);
            this.PanelLogin.Controls.Add(this.txtNewPass1);
            this.PanelLogin.Location = new System.Drawing.Point(13, 14);
            this.PanelLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PanelLogin.Name = "PanelLogin";
            this.PanelLogin.Size = new System.Drawing.Size(402, 268);
            this.PanelLogin.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Mật khẩu";
            // 
            // txtCurrPass
            // 
            this.txtCurrPass.Location = new System.Drawing.Point(199, 39);
            this.txtCurrPass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCurrPass.Name = "txtCurrPass";
            this.txtCurrPass.PasswordChar = '*';
            this.txtCurrPass.Size = new System.Drawing.Size(180, 26);
            this.txtCurrPass.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 100);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Mật khẩu mới";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(220, 207);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(112, 35);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "&Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnDoi
            // 
            this.btnDoi.Location = new System.Drawing.Point(64, 207);
            this.btnDoi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDoi.Name = "btnDoi";
            this.btnDoi.Size = new System.Drawing.Size(112, 35);
            this.btnDoi.TabIndex = 6;
            this.btnDoi.Text = "&Đổi mật khẩu";
            this.btnDoi.UseVisualStyleBackColor = true;
            this.btnDoi.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // txtNewPass2
            // 
            this.txtNewPass2.Location = new System.Drawing.Point(199, 144);
            this.txtNewPass2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNewPass2.Name = "txtNewPass2";
            this.txtNewPass2.PasswordChar = '*';
            this.txtNewPass2.Size = new System.Drawing.Size(180, 26);
            this.txtNewPass2.TabIndex = 5;
            this.txtNewPass2.UseSystemPasswordChar = true;
            // 
            // LabelPassword
            // 
            this.LabelPassword.AutoSize = true;
            this.LabelPassword.Location = new System.Drawing.Point(18, 150);
            this.LabelPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelPassword.Name = "LabelPassword";
            this.LabelPassword.Size = new System.Drawing.Size(176, 20);
            this.LabelPassword.TabIndex = 4;
            this.LabelPassword.Text = "Xác nhận mật khẩu mới";
            // 
            // txtNewPass1
            // 
            this.txtNewPass1.Location = new System.Drawing.Point(199, 95);
            this.txtNewPass1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNewPass1.Name = "txtNewPass1";
            this.txtNewPass1.PasswordChar = '*';
            this.txtNewPass1.Size = new System.Drawing.Size(180, 26);
            this.txtNewPass1.TabIndex = 3;
            // 
            // frmDoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 293);
            this.Controls.Add(this.PanelLogin);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDoiMatKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi mật khẩu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmDoiMatKhau_FormClosed);
            this.PanelLogin.ResumeLayout(false);
            this.PanelLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelLogin;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnDoi;
        private System.Windows.Forms.TextBox txtNewPass1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCurrPass;
        private System.Windows.Forms.TextBox txtNewPass2;
        private System.Windows.Forms.Label LabelPassword;
    }
}