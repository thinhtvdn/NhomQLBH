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
    public partial class frmQuanLyHangHoa : Form
    {
        private static SqlConnection conn;
        private int cateID;
        public frmQuanLyHangHoa()
        {
            InitializeComponent();
            conn = new SqlConnection(ConnectionString.chuoiKetNoi());
        }
        private void CbLoaiiHangBinding()
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
               // MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void dgChiTietMatHangBinding()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            try
            {
                conn.Open();
                this.cateID = Int32.Parse(CbChungLoaiHang.SelectedValue.ToString());
                string selectCommand = "Select ProductID,Name,UnitCalc,CONVERT(DECIMAL(10,2),sellPrice) as  sellPrice from Products where TypeID = " + cateID+"";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(selectCommand, conn);
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
                DataTable table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                dataAdapter.Fill(table);
                table.Columns["ProductID"].ColumnName = "Mã Sản Phẩm";
                table.Columns["Name"].ColumnName = "Tên sản phẩm";
                table.Columns["UnitCalc"].ColumnName = "Đơn vị tính";
                table.Columns["sellPrice"].ColumnName = "Giá bán";

                dgChiTietMH.DataSource = table;

                int i = dgChiTietMH.RowCount - 1;
                LblSoMatHang.Text = i.ToString();
                conn.Close();
                
            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }
        private void frmQuanLyHangHoa_Load(object sender, EventArgs e)
        {
            CbLoaiiHangBinding();          
        }

        private void CbChungLoaiHang_SelectedValueChanged(object sender, EventArgs e)
        {
                dgChiTietMatHangBinding();
        }
        

        private void BtnThemMatHang_Click(object sender, EventArgs e)
        {
            if (!checkExitsForm("frmThemMatHang"))
            {
                frmThemMatHang frmType = new frmThemMatHang(CbChungLoaiHang.Text);
                frmType.MdiParent = ActiveForm;
                frmType.Show();
                this.Close();  // đóng form quản lý
            }
            else
                ActiveChildForm("frmThemMatHang");

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

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Bạn muốn thoát", "errors", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(DialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void LstLoaiHang_SelectedValueChanged(object sender, EventArgs e)
        {
            dgChiTietMatHangBinding();
        }

      
        
        private void frmQuanLyHangHoa_MouseClick(object sender, MouseEventArgs e)
        {
            dgChiTietMatHangBinding();
        }

        private void dgChiTietMH_CellMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                try
                {
                    dgChiTietMH.Rows[e.RowIndex].Selected = true;
                    dgChiTietMH.CurrentCell = dgChiTietMH.Rows[e.RowIndex].Cells[0];
                    ctMenu.Show(dgChiTietMH, e.Location);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "errors", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void ctMenuDelete_Click(object sender, EventArgs e)
        {
            string productid = dgChiTietMH.CurrentCell.Value.ToString();
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("DELETE FROM Products where ProductID =@ProductID", conn);
                command.Parameters.AddWithValue("ProductID", productid.ToString());
                command.ExecuteNonQuery();
                conn.Close();
                dgChiTietMH.Refresh();
                dgChiTietMatHangBinding();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể xóa vì còn hóa đơn bán hàng", "errors", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        
       
        private void ctMenuEdit_Click_1(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                String mamh = dgChiTietMH.CurrentRow.Cells[0].FormattedValue.ToString();
                String tensp = dgChiTietMH.CurrentRow.Cells[1].FormattedValue.ToString();
                String donvitinh = dgChiTietMH.CurrentRow.Cells[2].FormattedValue.ToString();
                string strgiaban = dgChiTietMH.CurrentRow.Cells[3].FormattedValue.ToString().Trim();

                SqlCommand command = new SqlCommand();
                command.CommandText = "Update Products Set Name=@name,UnitCalc=@unitcalc,sellPrice=@sellPrice where ProductID=@productid";
                command.Connection = conn;
                command.Parameters.AddWithValue("@productid", mamh);
                command.Parameters.AddWithValue("@name", tensp);
                command.Parameters.AddWithValue("@unitcalc", donvitinh);
                float giaban=0; //giaban
                if (strgiaban.Length == 0)
                {  // không nhập gì, giá bán =0
                    command.Parameters.AddWithValue("@sellPrice", giaban);
                    int result = command.ExecuteNonQuery();
                    MessageBox.Show("Đã cập nhập");
                }
                if (strgiaban.Length > 1)
                    if (float.TryParse(strgiaban, out giaban))
                    {
                        command.Parameters.AddWithValue("@sellPrice", giaban);
                        int result = command.ExecuteNonQuery();
                        MessageBox.Show("Đã cập nhập");
                    }
                    else
                    {
                        MessageBox.Show(" Giá bán phải là kiểu số");
                    }
                conn.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void ctMenuNew_Click(object sender, EventArgs e)
        {
            if (!checkExitsForm("frmThemMatHang"))
            {
                frmThemMatHang frmType = new frmThemMatHang(CbChungLoaiHang.Text);
                frmType.MdiParent = ActiveForm;
                frmType.Show();
                this.Close();  // đóng form quản lý
            }
            else ActiveChildForm("frmThemMatHang");
        }

        private void dgChiTietMH_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
          if (e.ColumnIndex==3)
            {
                string strSo = e.FormattedValue.ToString().Trim();
                if  ((strSo.Length>0) && (!IsNumeric(strSo)))
                {
                    MessageBox.Show("Phải nhập dữ liệu số");
                }
            }
        }

        public bool IsNumeric(string value)
        {
            float f = 0;
            bool success = float.TryParse(value, out f);
            return success;
        }

        private void dgChiTietMH_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true; // tắt thông báo lổi , vì đã kiểm tra 
        }

    }
}