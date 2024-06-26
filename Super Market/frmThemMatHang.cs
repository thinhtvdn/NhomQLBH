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
    public partial class frmThemMatHang : Form
    {
        private static SqlConnection conn;
        private int TypeID;
        public string st;  // nhận tên chủng loại hàng, khi mở form, lưu để gán vào combobox
        public frmThemMatHang(string s)
        {
            InitializeComponent();
            st = s;
            conn = new SqlConnection(ConnectionString.chuoiKetNoi());
        }

        private void frmThemMatHang_Load(object sender, EventArgs e)
        {
            cBChungLoaiHangBinding();
            CbChungLoaiHang.SelectedIndex = CbChungLoaiHang.FindString(st);
        }


        private void cBLoaiHangBinding()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }

            try
            {
                this.TypeID = Int32.Parse(this.CbChungLoaiHang.SelectedValue.ToString());
                conn.Open();
                DataSet ds = new DataSet("Categories");
                SqlDataAdapter adapter = new SqlDataAdapter("Select *from Categories where TypeID = " + (int)TypeID + " ", conn);
                adapter.Fill(ds);
                conn.Close();

            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message,"Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
        private void cBChungLoaiHangBinding()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            try
            {
                conn.Open();
                DataSet ds = new DataSet("Types");
                SqlDataAdapter adapter = new SqlDataAdapter("Select * from Types", conn);
                adapter.Fill(ds);
                CbChungLoaiHang.DataSource = ds.Tables[0];
                CbChungLoaiHang.DisplayMember = "Name";
                CbChungLoaiHang.ValueMember = "TypeID";
                conn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        public int select_totalDong()
        { // SP0015 -> 15
            int result = 0;
            using (SqlConnection con = new SqlConnection(ConnectionString.chuoiKetNoi())) // Khai báo kết nối đến CSDL
            {
                try
                {
                    con.Open(); // mở kết nối
                    string strSQL = "SELECT top 1 ProductID FROM Products ORDER BY ProductID DESC"; // xếp giảm từ nhỏ đến lớn, lấy 1 mã có stt lớn nhất
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.CommandType = CommandType.Text;
                    SqlDataReader rd = cmd.ExecuteReader();
                    if (rd.HasRows)
                    {
                        rd.Read();
                        string maso = rd["ProductID"].ToString().Trim();
                        string strSo = maso.Substring(maso.Length - 3, 3);  // lấy chuổi số thứ tự
                        result = int.Parse(strSo);
                    }
                    cmd.Dispose();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return result;
        }

        public string taoMaSPTuDong()
        { // SP + 1234
            string maSP="";

            string stt = (select_totalDong() + 1).ToString();
            switch (stt.Length) 
                {
                case 1:
                    maSP = "SP000" + stt;
                    break;
                case 2:
                    maSP = "SP00" + stt;
                    break;
                case 3:
                    maSP = "SP0" + stt;
                    break;
                case 4:
                    maSP = "SP" + stt;
                    break;
            }
            return maSP;
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString.chuoiKetNoi())) // Khai báo kết nối đến CSDL
            {
                try
                {
                    con.Open(); // mở kết nối
                    string strSQL = "INSERT INTO Products(ProductID,Name,TypeID,UnitCalc,sellPrice) VALUES(@ProductID,@Name,@TypeID,@UnitCalc,@sellPrice)";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@ProductID", taoMaSPTuDong());
                    cmd.Parameters.AddWithValue("@Name", txtTenSanPham.Text);
                    cmd.Parameters.AddWithValue("@UnitCalc",  txtDonViTinh.Text);
                    cmd.Parameters.AddWithValue("@TypeID", CbChungLoaiHang.SelectedValue.ToString());

                    float giaban = 0; //giaban
                    string strgiaban = txtGiaBan.Text.Trim();
                    if (strgiaban.Length > 1)
                       if (!float.TryParse(strgiaban, out giaban))
                        {
                            MessageBox.Show(" Giá bán phải là kiểu số");
                            txtGiaBan.Focus();
                            return;
                        }

                    cmd.Parameters.AddWithValue("@sellPrice", giaban);
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


        private void CbChungLoaiHang_SelectedValueChanged(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            cBLoaiHangBinding();
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            if (!checkExitsForm("frmQuanLyHangHoa"))
            {
                frmQuanLyHangHoa frmType = new frmQuanLyHangHoa();
                frmType.MdiParent = ActiveForm;
                frmType.Show();
                this.Close();  // đóng form  
            }
            else ActiveChildForm("frmQuanLyHangHoa");

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

        
    }
}