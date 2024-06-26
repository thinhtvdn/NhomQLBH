using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Super_Market
{
    public partial class frmThemNhaCC : Form
    {
        private static SqlConnection conn;
        public frmThemNhaCC()
        {
            InitializeComponent();
            conn = new SqlConnection(ConnectionString.chuoiKetNoi());
        }

        private void BtnDong_Click(object sender, EventArgs e)
        {
            if (!checkExitsForm("frmDanhMucNhaCungCap"))
            {
                frmDanhMucNhaCungCap frmType = new frmDanhMucNhaCungCap();
                frmType.MdiParent = ActiveForm;
                frmType.Show();
                this.Close();  // đóng form  
            }
            else ActiveChildForm("frmDanhMucNhaCungCap");

            this.Close();
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
                if (frm.Name == name)
                { check = true; break; }
            }
            return check;
        }


        private void BtnOK_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString.chuoiKetNoi())) // Khai báo kết nối đến CSDL
            {
                try
                {
                    con.Open(); // mở kết nối
                    string strSQL = "Insert into Providers(Name, Address, Tel) values(@p1, @p2, @p3)";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@p1",  TxtName.Text);
                    cmd.Parameters.AddWithValue("@p2", TxtDiachi.Text);
                    cmd.Parameters.AddWithValue("@p3", TxtDienThoai.Text);
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
    }
}