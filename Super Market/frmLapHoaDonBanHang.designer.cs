namespace Super_Market
{
    partial class frmLapHoaDonBanHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSoluong = new System.Windows.Forms.TextBox();
            this.BtnThemMatHang = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cBMaMatHang = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgChiTietMH = new System.Windows.Forms.DataGridView();
            this.productIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctMenuXoa = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctMenudelete = new System.Windows.Forms.ToolStripMenuItem();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cartBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hoaDonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnInHoaDon = new System.Windows.Forms.Button();
            this.BtnHoaDonMoi = new System.Windows.Forms.Button();
            this.BtnDong = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgChiTietMH)).BeginInit();
            this.ctMenuXoa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cartBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonBindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(434, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lập Hóa đơn Bán hàng";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtSoluong);
            this.groupBox1.Controls.Add(this.BtnThemMatHang);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cBMaMatHang);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(18, 77);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(1110, 111);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // txtSoluong
            // 
            this.txtSoluong.Location = new System.Drawing.Point(802, 38);
            this.txtSoluong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSoluong.Name = "txtSoluong";
            this.txtSoluong.Size = new System.Drawing.Size(108, 26);
            this.txtSoluong.TabIndex = 1;
            this.txtSoluong.TextChanged += new System.EventHandler(this.txtSoluong_TextChanged);
            // 
            // BtnThemMatHang
            // 
            this.BtnThemMatHang.BackColor = System.Drawing.SystemColors.Info;
            this.BtnThemMatHang.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnThemMatHang.Location = new System.Drawing.Point(970, 37);
            this.BtnThemMatHang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnThemMatHang.Name = "BtnThemMatHang";
            this.BtnThemMatHang.Size = new System.Drawing.Size(112, 35);
            this.BtnThemMatHang.TabIndex = 2;
            this.BtnThemMatHang.Text = "&Thêm";
            this.BtnThemMatHang.UseVisualStyleBackColor = false;
            this.BtnThemMatHang.Click += new System.EventHandler(this.BtnThemMatHang_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(690, 42);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "&Số lượng";
            // 
            // cBMaMatHang
            // 
            this.cBMaMatHang.FormattingEnabled = true;
            this.cBMaMatHang.ItemHeight = 20;
            this.cBMaMatHang.Location = new System.Drawing.Point(190, 35);
            this.cBMaMatHang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cBMaMatHang.Name = "cBMaMatHang";
            this.cBMaMatHang.Size = new System.Drawing.Size(298, 28);
            this.cBMaMatHang.TabIndex = 0;
            this.cBMaMatHang.TextChanged += new System.EventHandler(this.cBMaMatHang_TextChanged);
            this.cBMaMatHang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cBMaMatHang_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(20, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "&Mã mặt hàng";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.dgChiTietMH);
            this.groupBox2.Location = new System.Drawing.Point(18, 197);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(1110, 462);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // dgChiTietMH
            // 
            this.dgChiTietMH.AutoGenerateColumns = false;
            this.dgChiTietMH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgChiTietMH.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dgChiTietMH.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgChiTietMH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgChiTietMH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIdDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.productPriceDataGridViewTextBoxColumn,
            this.Column1});
            this.dgChiTietMH.DataSource = this.cartBindingSource;
            this.dgChiTietMH.Location = new System.Drawing.Point(21, 20);
            this.dgChiTietMH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgChiTietMH.Name = "dgChiTietMH";
            this.dgChiTietMH.Size = new System.Drawing.Size(1062, 402);
            this.dgChiTietMH.TabIndex = 5;
            this.dgChiTietMH.TabStop = false;
            this.dgChiTietMH.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgChiTietMH_DataError);
            // 
            // productIdDataGridViewTextBoxColumn
            // 
            this.productIdDataGridViewTextBoxColumn.ContextMenuStrip = this.ctMenuXoa;
            this.productIdDataGridViewTextBoxColumn.DataPropertyName = "_ProductId";
            this.productIdDataGridViewTextBoxColumn.HeaderText = "Mã sản phẩm";
            this.productIdDataGridViewTextBoxColumn.Name = "productIdDataGridViewTextBoxColumn";
            // 
            // ctMenuXoa
            // 
            this.ctMenuXoa.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ctMenuXoa.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctMenudelete});
            this.ctMenuXoa.Name = "ctMenuXoa";
            this.ctMenuXoa.Size = new System.Drawing.Size(116, 34);
            this.ctMenuXoa.Text = "Xóa";
            this.ctMenuXoa.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ctMenuXoa_ItemClicked);
            // 
            // ctMenudelete
            // 
            this.ctMenudelete.Name = "ctMenudelete";
            this.ctMenudelete.Size = new System.Drawing.Size(115, 30);
            this.ctMenudelete.Text = "Xóa";
            this.ctMenudelete.ToolTipText = "Xóa sản phẩm này";
            this.ctMenudelete.Click += new System.EventHandler(this.ctMenudelete_Click);
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "_ProductName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "Tên sản phẩm";
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "_Quantity";
            dataGridViewCellStyle1.Format = "N";
            this.quantityDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Số lượng";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // productPriceDataGridViewTextBoxColumn
            // 
            this.productPriceDataGridViewTextBoxColumn.DataPropertyName = "_ProductPrice";
            dataGridViewCellStyle2.Format = "N2";
            this.productPriceDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.productPriceDataGridViewTextBoxColumn.HeaderText = "Giá bán";
            this.productPriceDataGridViewTextBoxColumn.Name = "productPriceDataGridViewTextBoxColumn";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "_totalProducts";
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column1.HeaderText = "Thành tiền";
            this.Column1.Name = "Column1";
            // 
            // cartBindingSource
            // 
            this.cartBindingSource.DataMember = "_Cart";
            this.cartBindingSource.DataSource = this.hoaDonBindingSource;
            // 
            // hoaDonBindingSource
            // 
            this.hoaDonBindingSource.DataSource = typeof(Super_Market.HoaDon);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtTongTien);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(614, 668);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(514, 80);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(462, 23);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "VND";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(128, 23);
            this.txtTongTien.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(334, 26);
            this.txtTongTien.TabIndex = 6;
            this.txtTongTien.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 25);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tổng tiền";
            // 
            // BtnInHoaDon
            // 
            this.BtnInHoaDon.BackColor = System.Drawing.SystemColors.Info;
            this.BtnInHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnInHoaDon.Location = new System.Drawing.Point(63, 668);
            this.BtnInHoaDon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnInHoaDon.Name = "BtnInHoaDon";
            this.BtnInHoaDon.Size = new System.Drawing.Size(136, 55);
            this.BtnInHoaDon.TabIndex = 3;
            this.BtnInHoaDon.Text = "&In Hóa đơn";
            this.BtnInHoaDon.UseVisualStyleBackColor = false;
            this.BtnInHoaDon.Click += new System.EventHandler(this.BtnInHoaDon_Click);
            // 
            // BtnHoaDonMoi
            // 
            this.BtnHoaDonMoi.BackColor = System.Drawing.SystemColors.Info;
            this.BtnHoaDonMoi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnHoaDonMoi.Location = new System.Drawing.Point(243, 668);
            this.BtnHoaDonMoi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnHoaDonMoi.Name = "BtnHoaDonMoi";
            this.BtnHoaDonMoi.Size = new System.Drawing.Size(136, 55);
            this.BtnHoaDonMoi.TabIndex = 4;
            this.BtnHoaDonMoi.Text = "&Hóa đơn mới";
            this.BtnHoaDonMoi.UseVisualStyleBackColor = false;
            this.BtnHoaDonMoi.Click += new System.EventHandler(this.BtnHoaDonMoi_Click);
            // 
            // BtnDong
            // 
            this.BtnDong.BackColor = System.Drawing.SystemColors.Info;
            this.BtnDong.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnDong.Location = new System.Drawing.Point(422, 668);
            this.BtnDong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnDong.Name = "BtnDong";
            this.BtnDong.Size = new System.Drawing.Size(136, 55);
            this.BtnDong.TabIndex = 6;
            this.BtnDong.Text = "&Đóng";
            this.BtnDong.UseVisualStyleBackColor = false;
            this.BtnDong.Click += new System.EventHandler(this.BtnDong_Click);
            // 
            // frmLapHoaDonBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Super_Market.Properties.Resources.BackgroundImage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1146, 794);
            this.Controls.Add(this.BtnDong);
            this.Controls.Add(this.BtnHoaDonMoi);
            this.Controls.Add(this.BtnInHoaDon);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmLapHoaDonBanHang";
            this.Text = "Lap Hoa Don Ban hang";
            this.Load += new System.EventHandler(this.frmLapHoaDonBanHang_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgChiTietMH)).EndInit();
            this.ctMenuXoa.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cartBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonBindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cBMaMatHang;
        private System.Windows.Forms.Button BtnThemMatHang;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgChiTietMH;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnInHoaDon;
        private System.Windows.Forms.Button BtnHoaDonMoi;
        private System.Windows.Forms.TextBox txtSoluong;
        private System.Windows.Forms.BindingSource cartBindingSource;
        private System.Windows.Forms.BindingSource hoaDonBindingSource;
        private System.Windows.Forms.ContextMenuStrip ctMenuXoa;
        private System.Windows.Forms.ToolStripMenuItem ctMenudelete;
        private System.Windows.Forms.Button BtnDong;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}