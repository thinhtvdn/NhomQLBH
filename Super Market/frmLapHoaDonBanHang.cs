using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;
using System.IO;

namespace Super_Market
{
    public partial class frmLapHoaDonBanHang : Form
    {
        private static SqlConnection conn;
        private bool controlKey=false;
        HoaDon hd = new HoaDon();
      
        public frmLapHoaDonBanHang()
        {
            InitializeComponent();
            conn = new SqlConnection(ConnectionString.chuoiKetNoi());
            cBMaMatHang.DataSource= load_ProductsID();
            
        }
        public ArrayList load_ProductsID()
        {
            ArrayList productsId = new ArrayList();
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = conn;
                command.CommandText = "Select ProductID from Products";
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    productsId.Add(reader[0].ToString());

                }

            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "errors", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            finally
            {
                conn.Close();
            }
            return productsId;
        }

        private void BtnThemMatHang_Click(object sender, EventArgs e)
        {
            themSPvaoHoadon();
            dgChiTietMH.DataSource = null; // xóa dữ liệu cũ
            dgChiTietMH.Refresh();
            dgChiTietMH.DataSource = hd._Cart; // nạp nguồn dữ liệu mới
            dgChiTietMH.Refresh();
            txtTongTien.Text = hd.tong_HoaDon.ToString("N2");
        }
        public void themSPvaoHoadon()
        {
            String productid = cBMaMatHang.Text;
            try
            {
                conn.Open();
                SqlCommand com = new SqlCommand();
                com.Connection = conn;
                com.CommandText = "Select * From Products where ProductID=" + "'" + productid + "'";
                SqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    if (int.Parse(txtSoluong.Text) > 0) // productid, productName, quantity, productPrice
                        hd.insert_item_toCart(reader[0].ToString(), reader[1].ToString(), int.Parse(txtSoluong.Text), float.Parse(reader[3].ToString()));
                }
            }
            catch (SqlException ex) { MessageBox.Show("Có lỗi sảy ra tại hệ thống cơ sở dữ liệu : " +  ex.ToString()); }
            catch (Exception ex) { MessageBox.Show("Có lỗi sảy ra: " + ex.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            finally
            {
                conn.Close();
            }
        }
        public void insert_Hoadon(int employeeId, float total)
        {
            try
            {
                conn.Open();
                SqlCommand com = new SqlCommand();
                String today = DateTime.Now.ToShortDateString();
                com.Connection = conn;
                com.CommandText = "insert into SellOrders(SellDate,Total,EmployeeID) values("+"'"+today+"'"+"," + "'" + total +"'"+ ","+"'" + employeeId + "')";
                com.ExecuteNonQuery();
            }

            catch (SqlException ex) { MessageBox.Show("Có lỗi sảy ra tại hệ thống cơ sở dữ liệu: " + ex.ToString(), "error", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            finally
            {
                writeToFile();
                conn.Close();
            }
        }
        public void insert_HoadonChitiet(int sellOrderId, String ProductId, int quantity,float ProductPrice)
        {
            try
            {
                conn.Open();
                SqlCommand com = new SqlCommand();
                com.Connection = conn;
                com.CommandText = "insert into SellOrderDetail(SellOrderID,ProductID,Quantity,productPrice,totalProducts) values(" + "'" + sellOrderId + "'" + "," + "'" + ProductId + "','" + quantity + "','" + ProductPrice + "','" + quantity * ProductPrice + "')";
                com.ExecuteNonQuery();
            }
            catch (SqlException ex) { MessageBox.Show("Có lỗi sảy ra tại hệ thống cơ sở dữ liệu :" + ex.ToString(), "error", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            finally { conn.Close(); }
        }

        private void BtnXoaMH_Click(object sender, EventArgs e)
        {
            try
            {
                hd.remove_item(dgChiTietMH.CurrentCell.FormattedValue.ToString()); // xóa trong danh sách
                dgChiTietMH.DataSource = hd._Cart;   // hiển thị danh sách mới
                txtTongTien.Text = hd.tong_HoaDon.ToString(); // hiển thị tổng tiền 
                dgChiTietMH.Refresh();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void BtnHoaDonMoi_Click(object sender, EventArgs e)
        {
            txtSoluong.Text = "";
            if (hd._Cart.Count > 0) hd._Cart.Clear();  // làm rỗng danh sách
            txtTongTien.Text = hd.tong_HoaDon.ToString();
            dgChiTietMH.DataSource = hd._Cart;
            dgChiTietMH.Refresh();
        }

        private void BtnInHoaDon_Click(object sender, EventArgs e)
        {
            int employeeid = Session._EmployeeId;
            float total = hd.tong_HoaDon;
            insert_Hoadon(employeeid, total);
            foreach(Cart cart in hd._Cart)
            {
                insert_HoadonChitiet(select_orderid(), cart._ProductId, cart._Quantity, cart._ProductPrice);
                tangSLsanPhamDaBan(cart._ProductId, cart._Quantity);// tăng số lượng sản phẩm đã bán trong tbl sản phẩm
            }
            if (hd._Cart.Count > 0)
            {
                hd._Cart.Clear();
            }
            txtTongTien.Text = hd.tong_HoaDon.ToString();
            dgChiTietMH.DataSource = hd._Cart;
            dgChiTietMH.Refresh();
        }

        //tangSLsanPhamDaBan(cart._ProductId, cart._Quantity)
        private void tangSLsanPhamDaBan(string _ProductId,int _Quantity)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString.chuoiKetNoi())) // tạo kết nối
            {
                try
                {
                    con.Open(); // mở kết nối
                    string query = " update Products " +
                                   " set   totalSell = totalSell + @slBan" +
                                   " where ProductID=@ProductID";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@ProductID", _ProductId);
                    cmd.Parameters.AddWithValue("@slBan", _Quantity);
                    cmd.ExecuteNonQuery();  // thực hiện lệnh SQL
                    cmd.Dispose();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }


        public int select_orderid()
        {
            int result = 0;
            using (SqlConnection con = new SqlConnection(ConnectionString.chuoiKetNoi())) // tạo kết nối
            {
                try
                {
                    con.Open(); // mở kết nối
                    string query = "Select max(SellOrderID) id from SellOrders";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataReader rd = cmd.ExecuteReader();
                    if (rd.HasRows)
                    {
                        while (rd.Read())
                        {
                            result = int.Parse(rd[0].ToString());
                        }
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

        private void cBMaMatHang_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            if (e.KeyChar == (int)Keys.Escape)
            {
                cBMaMatHang.SelectedIndex = -1;
                cBMaMatHang.Text = "";
                controlKey = true;

            }
            else
            {
                if (char.IsControl(e.KeyChar))
                    controlKey = true;
                else
                    controlKey = false;
            }
        }

        private void cBMaMatHang_TextChanged(object sender, EventArgs e)
        {
            if (cBMaMatHang.Text != "" && !controlKey)
            {
                String matchText = cBMaMatHang.Text;
                int result = cBMaMatHang.FindString(matchText);
                if (result != -1)
                {
                    cBMaMatHang.SelectedIndex = result;
                    cBMaMatHang.SelectionStart = matchText.Length;
                    cBMaMatHang.SelectionLength = cBMaMatHang.Text.Length - cBMaMatHang.SelectionStart;
                }
            }
        }

        private void dgChiTietMH_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            
        }
        private void ctMenuXoa_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Name.Equals("ctMenudelete"))
            {
                try
                {
                    string stt = dgChiTietMH.CurrentCell.FormattedValue.ToString();
                    hd.remove_item(stt);
                    dgChiTietMH.DataSource = hd._Cart;
                    txtTongTien.Text = hd.tong_HoaDon.ToString();
                    dgChiTietMH.Refresh();

                }catch (Exception ex) { MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            }
        }

        private void frmLapHoaDonBanHang_Load(object sender, EventArgs e)
        {

        }

        private void BtnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void writeToFile()
        {
            String today = DateTime.Today.ToShortDateString();
            int rows = dgChiTietMH.Rows.Count;
            using (FileStream stream = new FileStream("donhang.txt", FileMode.Create))
            {
                using (StreamWriter writer = new StreamWriter(stream, Encoding.UTF8))
                {
                    writer.WriteLine(clsCacBienChung.tenDonVi);
                    writer.WriteLine(today);
                    writer.WriteLine("Hóa đơn thanh toán");
                    writer.WriteLine("");
                    for (int i = 0; i < rows; i++)
                    {
                        String productname = dgChiTietMH.Rows[i].Cells[1].FormattedValue.ToString();
                        String soluong = dgChiTietMH.Rows[i].Cells[2].FormattedValue.ToString();
                        String gia = dgChiTietMH.Rows[i].Cells[3].FormattedValue.ToString();
                        String tong = dgChiTietMH.Rows[i].Cells[4].FormattedValue.ToString();
                        writer.WriteLine(productname + " " + soluong + " " + gia + " " + tong);
                    }
                    writer.WriteLine("Tổng tiền:"+hd.tong_HoaDon.ToString());
                    writer.WriteLine("Cảm ơn quý khách đã mua hàng tại siêu thị của chúng tôi");
                    writer.WriteLine("Nhân viên:"+ Session._EmployeeName);
                    writer.Close();
                }
                stream.Close();
            }
        }

        private void txtSoluong_TextChanged(object sender, EventArgs e)
        {
            int result;
            try
            {
                if (txtSoluong.Text != "")
                {
                    if (!(int.TryParse(txtSoluong.Text, out result)))
                        txtSoluong.BackColor = Color.Red;
                    else
                        txtSoluong.BackColor = Color.WhiteSmoke;
                }
            }
            catch (Exception ex) { }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void ctMenudelete_Click(object sender, EventArgs e)
        {

        }
    }
}