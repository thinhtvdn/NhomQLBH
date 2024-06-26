using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
namespace Super_Market
{
    public partial class frmThemNhanVien : Form
    {
        private static SqlConnection conn;
        public frmThemNhanVien()
        {
            InitializeComponent();
            conn = new SqlConnection(ConnectionString.chuoiKetNoi());
        }

        private void BtnThemNHanVien_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString.chuoiKetNoi())) // Khai báo kết nối đến CSDL
            {
                try
                {
                    con.Open(); // mở kết nối
                    string strSQL = "Insert into Employees(EmployeeName, Title, DateOfBirth, Sex, IDCard, Address, Tel, Username, Password) values(@p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9)";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@p1", TxtFullName.Text);
                    cmd.Parameters.AddWithValue("@p2", CbChucVu.Text);
                    cmd.Parameters.AddWithValue("@p3", dtPickerNS.Text);
                    cmd.Parameters.AddWithValue("@p4", CbGioiTinh.Text);
                    cmd.Parameters.AddWithValue("@p5", int.Parse(TxtCMND.Text.ToString()));
                    cmd.Parameters.AddWithValue("@p6", TxtDiaChi.Text);
                    cmd.Parameters.AddWithValue("@p7", TxtDienThoai.Text);
                    cmd.Parameters.AddWithValue("@p8", TxtUsername.Text);
                    cmd.Parameters.AddWithValue("@p9", TxtPassword.Text);
                    cmd.ExecuteNonQuery(); // thực hiện lệnh SQL
                    cmd.Dispose();
                    MessageBox.Show("Đã thêm thông tin");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }


       


        private void BtnDong_Click(object sender, EventArgs e)
        {
            if (!checkExitsForm("frmQuanLyNhanVien"))
            {
                frmQuanLyNhanVien frmType = new frmQuanLyNhanVien();
                frmType.MdiParent = ActiveForm;
                frmType.Show();
                this.Close();  // đóng form  
            }
            else ActiveChildForm("frmQuanLyNhanVien");

            this.Close();
        }

        private bool checkExitsForm(string name)
        {
            bool check = false;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == name)
                { check = true; break; }
            }
            return check;
        }


        private void ActiveChildForm(string name)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == name)
                { frm.Activate(); break; }
            }

        }

 
    }
}