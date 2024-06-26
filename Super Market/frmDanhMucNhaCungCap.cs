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
    public partial class frmDanhMucNhaCungCap : Form
    {
        public frmDanhMucNhaCungCap()
        {
            InitializeComponent();
        }

        private void GetListProvider()
        {
            string strSQL = "SELECT ProviderID,Name FROM Providers";
            using (SqlConnection conn = new SqlConnection(ConnectionString.chuoiKetNoi()))
            {
                using (SqlDataAdapter sda = new SqlDataAdapter(strSQL, conn))
                {
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    LstTenNCC.DataSource = dt;
                    LstTenNCC.DisplayMember = "Name";
                    LstTenNCC.ValueMember = "ProviderID";
                }
            }
        }

        private void GetProviderInfo()
        {
            if (string.IsNullOrEmpty(LstTenNCC.SelectedValue.ToString())) return;
            using (SqlConnection con = new SqlConnection(ConnectionString.chuoiKetNoi())) // Khai báo kết nối đến CSDL
            {
                try
                {
                    con.Open(); // mở kết nối
                    string strSQL = "Select * From Providers Where ProviderID = @ProviderID";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.CommandType = CommandType.Text;
                    int idNCC = Convert.ToInt32(LstTenNCC.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@ProviderID", idNCC);
                    SqlDataReader rd = cmd.ExecuteReader();
                    if (rd.HasRows)
                    {
                        rd.Read();
                        TxtName.Text = rd["Name"].ToString();
                        TxtDiachi.Text = rd["Address"].ToString();
                        TxtDienThoai.Text = rd["Tel"].ToString();
                    }
                    cmd.Dispose();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void frmDanhMucNhaCungCap_Load(object sender, EventArgs e)
        {
            GetListProvider();
        }
        private void BtnXoa_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Chắc chắn xóa ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult == DialogResult.Yes)
            {
                using (SqlConnection con = new SqlConnection(ConnectionString.chuoiKetNoi())) // tạo kết nối
                {
                    try
                    {
                        con.Open(); // mở kết nối
                        string query = "delete from Providers where ProviderID=@ProviderID";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.CommandType = CommandType.Text;
                        int idNCC = Convert.ToInt32(LstTenNCC.SelectedValue.ToString());
                        cmd.Parameters.AddWithValue("@ProviderID", idNCC);
                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                        GetListProvider();
                        MessageBox.Show("Đã xóa thông tin trong CSDL");

                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

       
        private void BtnCapNhat_Click(object sender, EventArgs e)
        {
            int idNCC = Convert.ToInt32(LstTenNCC.SelectedValue.ToString());
            string ten = TxtName.Text.ToString();
            string diaChi = TxtDiachi.Text.ToString();
            string dienThoai = TxtDienThoai.Text.ToString();
            using (SqlConnection con = new SqlConnection(ConnectionString.chuoiKetNoi())) // tạo kết nối
            {
                try
                {
                    con.Open(); // mở kết nối
                    string query = " update Providers " +
                                   " set   Name = @Name, Address=@Address, Tel=@Tel " +
                                   " where ProviderID=@ProviderID";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@Name", ten);
                    cmd.Parameters.AddWithValue("@Address", diaChi);
                    cmd.Parameters.AddWithValue("@Tel", dienThoai);
                    cmd.Parameters.AddWithValue("@ProviderID", idNCC);
                    cmd.ExecuteNonQuery();  // thực hiện lệnh SQL
                    cmd.Dispose();
                    MessageBox.Show("Đã cập nhập thông tin");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }

    }

        private void BtnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            if (!checkExitsForm("frmThemNhaCC"))
            {
                frmThemNhaCC frmType = new frmThemNhaCC();
                frmType.MdiParent = ActiveForm;
                frmType.Show();
                this.Close();  // đóng form quản lý
            }
            else ActiveChildForm("frmThemNhaCC");

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

        private void LstTenNCC_SelectedValueChanged(object sender, EventArgs e)
        {
           
        }

        private void LstTenNCC_Click(object sender, EventArgs e)
        {
            GetProviderInfo();
        }
    }
}