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
    public partial class frmQuanLyNhanVien : Form
    {
        private static SqlConnection conn;
        public frmQuanLyNhanVien()
        {
            InitializeComponent();
            conn = new SqlConnection(ConnectionString.chuoiKetNoi());
        }

        private void frmQuanLyNhanVien_Load(object sender, EventArgs e)
        {

            dtPickerNgaysinh.Value = DateTime.Today;
            dtPickerNgaysinh.CustomFormat = "dd/MM/yyyy";
            dtPickerNgaysinh.Format = DateTimePickerFormat.Custom;

            ListEmployeeInfo();
        }
        private void BtnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ListEmployeeInfo()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            try
            {
                conn.Open();
                DataSet ds = new DataSet("Employees");
                SqlDataAdapter da = new SqlDataAdapter("Select EmployeeID,EmployeeName from Employees", conn);
                da.Fill(ds);
                LstHoTen.DataSource = ds.Tables[0];
                LstHoTen.DisplayMember = "EmployeeName";
                LstHoTen.ValueMember = "EmployeeID";
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void GetEmployeeInfo()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            try
            {
                conn.Open();
                int EmployeeID = Convert.ToInt32(LstHoTen.SelectedValue.ToString());
                SqlCommand command = new SqlCommand("Select EmployeeName,Title,DateOfBirth,Sex,IDCard,Address,Tel,Username,Password from Employees where EmployeeID = " + EmployeeID + " ", conn);
                SqlDataAdapter da = new SqlDataAdapter(command);
                DataSet ds = new DataSet();
                da.Fill(ds, "Employees");
                int i = ds.Tables[0].Rows.Count;
                if (i > 0)
                {
                    TxtName.Text = ds.Tables[0].Rows[i - 1]["EmployeeName"].ToString();
                    TxtUsername.Text = ds.Tables[0].Rows[i - 1]["Username"].ToString();
                    TxtPassword.Text = ds.Tables[0].Rows[i - 1]["Password"].ToString();
                    dtPickerNgaysinh.Text = ds.Tables[0].Rows[i - 1]["DateOfBirth"].ToString();
                    CbChucVu.Text = ds.Tables[0].Rows[i - 1]["Title"].ToString();
                    CbGioiTinh.Text = ds.Tables[0].Rows[i - 1]["Sex"].ToString();
                    TxtCMND.Text = ds.Tables[0].Rows[i - 1]["IDCard"].ToString();
                    TxtDiachi.Text = ds.Tables[0].Rows[i - 1]["Address"].ToString();
                    TxtDienThoai.Text = ds.Tables[0].Rows[i - 1]["Tel"].ToString();

                }
                conn.Close();
            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.Message,"Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning)
            }
            finally
            {
                conn.Close();
            }
        }
        private void BtnThemNhanVien_Click(object sender, EventArgs e)
        {
            if (!checkExitsForm("frmThemNhanVien"))
            {
                frmThemNhanVien frmType = new frmThemNhanVien();
                frmType.MdiParent = ActiveForm; 
                frmType.Show();
                this.Close();  // đóng form quản lý
            }
            else ActiveChildForm("frmThemNhanVien");          
        }

        private bool checkExitsForm(string name)
        {
            bool check = false;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == name)
                { check = true; break;
                }
            }
            return check;
        }


        private void ActiveChildForm(string name)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == name)
                {
                    frm.Activate(); break;
                }
            }
        }

            private void LstHoTen_SelectedValueChanged(object sender, EventArgs e)
        {
            GetEmployeeInfo();
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            DialogResult = MessageBox.Show("Chắc chắn xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult == DialogResult.Yes)
            {
                using (SqlConnection con = new SqlConnection(ConnectionString.chuoiKetNoi())) // tạo kết nối
                {
                    try
                    {
                        con.Open(); // mở kết nối
                        string query = "Delete from Employees where EmployeeID = @Em";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@Em", int.Parse(LstHoTen.SelectedValue.ToString()));
                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                        MessageBox.Show("Đã xóa thông tin trong CSDL");

                        ListEmployeeInfo();
                    }
                    catch (SqlException ex)
                    {
                        if (ex.Message.Contains("SellOrders"))
                           { MessageBox.Show("Nhân viên này đã có thông tin bán hàng, không được xóa"); }
                       
                    }
                }
            }
    }

        private void BtnCapNhat_Click(object sender, EventArgs e)
        {
            int EmployeeID = int.Parse(LstHoTen.SelectedValue.ToString());
            using (SqlConnection con = new SqlConnection(ConnectionString.chuoiKetNoi())) // tạo kết nối
            {
                try
                {
                    con.Open(); // mở kết nối
                    string query = " Update Employees set EmployeeName = @p1, Title = @p2, DateOfBirth = @p3, Sex = @p4, IDCard = @p5, Address = @p6, Tel = @p7, Username = @p9, Password = @p10 where EmployeeID = @Em ";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@p1", TxtName.Text.ToString());
                    cmd.Parameters.AddWithValue("@p2", CbChucVu.Text.ToString());
                    cmd.Parameters.AddWithValue("@p3", dtPickerNgaysinh.Text);
                    cmd.Parameters.AddWithValue("@p4", CbGioiTinh.Text.ToString());
                    cmd.Parameters.AddWithValue("@p5", int.Parse(TxtCMND.Text.ToString()));
                    cmd.Parameters.AddWithValue("@p6", TxtDiachi.Text.ToString());
                    cmd.Parameters.AddWithValue("@p7", TxtDienThoai.Text.ToString());
                    cmd.Parameters.AddWithValue("@p9", TxtUsername.Text.ToString());
                    cmd.Parameters.AddWithValue("@p10", TxtPassword.Text.ToString());
                    cmd.Parameters.AddWithValue("@Em", EmployeeID);

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



        private void frmQuanLyNhanVien_Shown(object sender, EventArgs e)
        {  // mổi khi show, active thì load lại danh sách mới 
            ListEmployeeInfo();
            LstHoTen.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

      
    }
}