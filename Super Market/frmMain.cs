using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;



namespace Super_Market
{
    public partial class frmMain : Form
    {
   
        public frmMain()
        {
            InitializeComponent();
        }
        public void frmMain_Load(object sender, EventArgs e)
        {
            if (clsBienDungChung.FirstTimeOpen==0) // nếu lần đầu mở chương trình 
            {
                clsBienDungChung.FirstTimeOpen = 1;
                frmDangNhap frmType = new frmDangNhap();
                frmType.MdiParent = this;
                frmType.Show();
            }

            loadMenuDefault();  // Khóa tất cả menu
            if (clsBienDungChung.Quyen.Contains(HangSo.QuyenQuanLy)) LoadMenuAdmin(); // nếu là quản lý thì load menu quản lys
                            else LoadMenuNhanVien();
        }


        public void LoadMenuNhanVien()
        { // menu nhân viên
          // menu hệ thống
            this.đổiMậtKhẩuToolStripMenuItem.Enabled = false;
            this.loginToolStripMenuItem.Enabled = true;
            this.logoutToolStripMenuItem.Enabled = true;
            // menu Quản lý danh mục
            this.MainMenu.Items[1].Enabled = false;
            this.loạiHàngHóaToolStripMenuItem.Enabled = false;
            this.hàngHóaToolStripMenuItem1.Enabled = false;
            this.nhàCungCấpToolStripMenuItem.Enabled = false;
            // menu Bán hàng
            this.MainMenu.Items[2].Enabled = true;
            this.lậpHóaĐơnBánHàngToolStripMenuItem.Enabled = true;
            // menu thống kê
            this.MainMenu.Items[3].Enabled = true;
            this.thốngKêHóaĐơnNhậpHàngToolStripMenuItem.Enabled = false;
            this.thốngKêHóaĐơnNhậpHàngToolStripMenuItem.Enabled = true;
            this.thốngKêHàngTồnToolStripMenuItem.Enabled = true;
            // menu quản lý nhân viên
            this.MainMenu.Items[4].Enabled = false;
            this.quảnLýNhânViênToolStripMenuItem.Enabled = true;
        }

        private void thoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Bạn muốn thoát ứng dụng", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Session._EmployeeId = 0;
            Session._EmployeeName = "";
            Session._Sex = "";
            Session._Title = "";
            Session._Username = "";
            foreach (Form frm in this.MdiChildren) frm.Close(); // đóng tất cả các form đang mở
            loadMenuDefault(); // nạp menu lúc chưa đăng nhập
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!checkExitsForm("frmDangNhap"))
            {
                frmDangNhap frmType = new frmDangNhap();
                frmType.MdiParent = this;
                frmType.Show();
            }
            else ActiveChildForm("frmDangNhap");
        }

        private void ActiveChildForm(string name)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == name)
                { frm.Activate(); break; }
            }

        }
        private bool checkExitsForm(string name)
        {
            bool check = false;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name==name)
                { check = true; break; }
            }
            return check;
        }

        private void hàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void MainMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

      public void LoadMenuAdmin()
        {
            foreach (ToolStripDropDownItem item in MainMenu.Items)  // các menu cấp 1
            {
                item.Enabled = true;
                foreach (ToolStripMenuItem mi in item.DropDownItems)
                {
                    mi.Enabled = true; // các menu cấp 2
                }
            }
        }

        public void loadMenuDefault()
        { // menu mặc định, chưa đăng nhập vào hệ thống
            // menu hệ thống
            đổiMậtKhẩuToolStripMenuItem.Enabled = false;
            loginToolStripMenuItem.Enabled = true;
            logoutToolStripMenuItem.Enabled = false;
            // menu Quản lý danh mục
            MainMenu.Items[1].Enabled = false;
            //loạiHàngHóaToolStripMenuItem.Enabled = false;
            //hàngHóaToolStripMenuItem.Enabled = false;
            //hàngHóaToolStripMenuItem1.Enabled = false;
            //nhàCungCấpToolStripMenuItem.Enabled = false;
            // menu Bán hàng
            MainMenu.Items[2].Enabled = false;
            //lậpHóaĐơnBánHàngToolStripMenuItem.Enabled = false;
            // menu thống kê
            MainMenu.Items[3].Enabled = false;
            //thốngKêHóaĐơnBánHàngToolStripMenuItem.Enabled = false;
            // menu quản lý nhân viên
            MainMenu.Items[4].Enabled = false;
            //quảnLýNhânViênToolStripMenuItem.Enabled = false;
        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!checkExitsForm("frmQuanLyNhanVien"))
            {
                frmQuanLyNhanVien frmType = new frmQuanLyNhanVien();
                frmType.MdiParent =this;
                frmType.Show();
            }
            else ActiveChildForm("frmQuanLyNhanVien");
        }

        private void lậpHóaĐơnBánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!checkExitsForm("frmLapHoaDonBanHang"))
            {
                frmLapHoaDonBanHang frmType = new frmLapHoaDonBanHang();
                frmType.MdiParent = this;
                frmType.Show();
            }
            else ActiveChildForm("frmLapHoaDonBanHang");
        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!checkExitsForm("frmDanhMucNhaCungCap"))
            {
                frmDanhMucNhaCungCap frmType = new frmDanhMucNhaCungCap();
                frmType.MdiParent = ActiveForm;
                frmType.Show();
            }
            else ActiveChildForm("frmDanhMucNhaCungCap");
        }

        private void loạiHàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLyChungLoaiHang frmType = new frmQuanLyChungLoaiHang();
            frmType.MdiParent = this;
            frmType.Show();
        }

        private void hàngHóaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmQuanLyHangHoa frmType = new frmQuanLyHangHoa();
            frmType.MdiParent = this;
            frmType.Show();
            
        }

        private void bánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lậpHóaĐơnNhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!checkExitsForm("frmLapHoaDonNhapHang"))
            {
                frmLapHoaDonNhapHang frmType = new frmLapHoaDonNhapHang();
                frmType.MdiParent = this;
                frmType.Show();
            }
            else ActiveChildForm("frmLapHoaDonNhapHang");
        }

        private void thốngKêHóaĐơnBánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thốngKêHóaĐơnBánHàngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!checkExitsForm("frmTKDanhSachHoaDonBanHang"))
            {
                frmTKDanhSachHoaDonBanHang frmType = new frmTKDanhSachHoaDonBanHang();
                frmType.MdiParent = this;
                frmType.Show();
            }
            else ActiveChildForm("frmTKDanhSachHoaDonBanHang");
        }

        private void thốngKêHàngTồnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!checkExitsForm("frmTKHangTon"))
            {
                frmTKHangTon frmType = new frmTKHangTon();
                frmType.MdiParent = this;
                frmType.Show();
            }
            else ActiveChildForm("frmTKHangTon");
        }

        private void thốngKêHóaĐơnNhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!checkExitsForm("frmTKDanhSachHoaDonNhapHang"))
            {
                frmTKDanhSachHoaDonNhapHang frmType = new frmTKDanhSachHoaDonNhapHang();
                frmType.MdiParent = this;
                frmType.Show();
            }
            else ActiveChildForm("frmTKDanhSachHoaDonNhapHang");
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!checkExitsForm("frmDoiMatKhau"))
            {
                frmDoiMatKhau frmType = new frmDoiMatKhau();
                frmType.MdiParent = this;
                frmType.Show();
            }
            else ActiveChildForm("frmDoiMatKhau");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!checkExitsForm("FrmAbout"))
            {
                FrmAbout frmType = new FrmAbout();
                frmType.MdiParent = this;
                frmType.Show();
            }
            else ActiveChildForm("FrmAbout");
        }
    }
}