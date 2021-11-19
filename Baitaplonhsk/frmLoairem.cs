using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using Baitaplonhsk.DTO;

namespace Baitaplonhsk
{
    public partial class frmLoairem : Form
    {
        String username;
        public frmLoairem()
        {
            InitializeComponent();
        }
        public frmLoairem(String user)
        {
            InitializeComponent();
            this.username = user;
        }

        string maLr;
        private static string str = ConfigurationManager.ConnectionStrings["quanlyxuatnhapkho2"].ConnectionString;
        private static SqlConnection cnn = new SqlConnection(str);

        static DataTable gettable(string tenbang)
        {
            String select = "select * from " + tenbang;
            using (SqlDataAdapter ad = new SqlDataAdapter(select, cnn))
            {
                using (DataTable table = new DataTable())
                {
                    ad.Fill(table);
                    return table;
                }
            }

        }

        private void hien()
        {
            using (DataTable table = gettable("tblNhacungcap"))
            {
                DataView dv = new DataView(table);
                dv.Sort = "sTenNcc";
                cbbTenncc.DataSource = dv;
                cbbTenncc.DisplayMember = "sTenNcc";
                cbbTenncc.ValueMember = "sMaNcc";
            }
            string select = "select sMaloairem, sTenloairem, sTenNcc, fSoluong, fDongia from tblLoairem, tblNhacungcap where tblLoairem.sMaNcc = tblNhacungcap.sMaNcc";
            //DataProvider provider = new DataProvider();
            //DataTable data = provider.ExecuteQuery(select);
            // dgrLoairem.DataSource = data;
            using (SqlCommand cmd = new SqlCommand(select, cnn))
            {
                cnn.Open();
                cmd.CommandType = CommandType.Text;
                using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                {
                    DataTable table = new DataTable();
                    ad.Fill(table);
                    dgrLoairem.DataSource = table;
                }
                cnn.Close();
            }
        }

        private void dgrLoairem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                btnThem.Enabled = false;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                errorLoairem.Clear();
                maLr = txtMaloairem.Text = dgrLoairem.CurrentRow.Cells[0].Value.ToString();
                txtTenloairem.Text = dgrLoairem.CurrentRow.Cells[1].Value.ToString();
                cbbTenncc.Text = dgrLoairem.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtSoluong.Text = dgrLoairem.CurrentRow.Cells[3].Value.ToString();
                txtDongia.Text = dgrLoairem.CurrentRow.Cells[4].Value.ToString();
            }
            catch { }
        }

        private void txtMaloairem_Validating(object sender, CancelEventArgs e)
        {
            if (txtMaloairem.Text == "")
                errorLoairem.SetError(txtMaloairem, "Bạn phải nhập mã loại rèm");
            else
                errorLoairem.SetError(txtMaloairem, "");
        }

        private void txtTenloairem_Validating(object sender, CancelEventArgs e)
        {
            if (txtTenloairem.Text == "")
                errorLoairem.SetError(txtTenloairem, "Bạn cần nhập tên loại rèm");
            else
            {
                try
                {
                    int a = int.Parse(txtTenloairem.Text);
                    errorLoairem.SetError(txtTenloairem, "Sai kiểu dữ liệu");
                }
                catch
                {
                    errorLoairem.SetError(txtTenloairem, "");
                }
            }
        }

        private void txtSoluong_Validating(object sender, CancelEventArgs e)
        {
            if (txtSoluong.Text == "")
                errorLoairem.SetError(txtSoluong, "Bạn cần nhập số lượng");
            else
            {
                try
                {
                    int a = int.Parse(txtSoluong.Text);
                    if (a > 0)
                    {
                        errorLoairem.SetError(txtSoluong, "");
                    }
                    else
                    {
                        MessageBox.Show("Ban phai nhap so luong > 0");
                    }
                    
                }
                catch
                {
                    MessageBox.Show("Sai kieu du lieu");
                }
            }
        }

        private void txtDongia_Validating(object sender, CancelEventArgs e)
        {
            if (txtDongia.Text == "")
                errorLoairem.SetError(txtDongia, "Bạn cần nhập đơn giá");
            else
            {
                try
                {
                    int a = int.Parse(txtDongia.Text);
                    errorLoairem.SetError(txtDongia, "");
                }
                catch
                {
                    errorLoairem.SetError(txtDongia, "Sai kiểu dữ liệu");
                }
            }
        }

        static bool kiemtratrungkhoa(string tenbang, string khoa, string tencot)
        {
            bool kq;
            string query = "select " + tencot + " from " + tenbang + " where " + tencot + "= '" + khoa + "'";
            DataProvider provider = new DataProvider();
            DataTable data = provider.ExecuteQuery(query);
            if (data.Rows.Count > 0)
                kq = true;
            else
                kq = false;

            //using (SqlDataAdapter ad = new SqlDataAdapter(select, cnn))
            //{
            //    DataTable table = new DataTable();
            //    ad.Fill(table);
            //    if (table.Rows.Count > 0)
            //        kq = true;
            //    else
            //        kq = false;
            //}
            return kq;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string mancc;
            using (SqlConnection connection = new SqlConnection(str))
            {
                string sql = "select * from tblNhacungcap where sTenNcc = N'" + cbbTenncc.Text + "'";
                using (SqlCommand cmd = new SqlCommand(sql, connection))  
                {
                    DataTable table = new DataTable();
                    try
                    {
                        connection.Open();
                        cmd.ExecuteNonQuery();
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        da.Fill(table);
                    }
                    catch
                    {
                        MessageBox.Show("Error sql!!");
                    }
                    finally
                    {
                        connection.Close();
                    }
                    mancc = table.Rows[0][0].ToString();
                }
            }


            if (txtMaloairem.Text == "")

                MessageBox.Show("Bạn phải nhập mã ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {

                if (txtTenloairem.Text == "")
                    MessageBox.Show("Bạn phải nhập Tên ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    if (txtSoluong.Text == "")
                        MessageBox.Show("Bạn phải nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                    {
                        try
                        {
                            float a = float.Parse(txtSoluong.Text);
                            if (a < 0)
                            {
                                MessageBox.Show("Số lượng phải > 0", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }

                        }
                        catch
                        {
                            MessageBox.Show("Sai kiểu dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }


                        if (txtDongia.Text == "")
                        {
                            MessageBox.Show("Bạn phải nhập Đơn giá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            try
                            {
                                float a = float.Parse(txtDongia.Text);
                                if (a > 0)
                                {
                                    errorLoairem.SetError(txtDongia, "");
                                    bool kiemtramaloairem = kiemtratrungkhoa("tblLoairem", txtMaloairem.Text, "sMaloairem");
                                    if (kiemtramaloairem)
                                        MessageBox.Show("Mã loại rèm đã tồn tại");
                                    else
                                    {
                                        using (SqlCommand cmd = new SqlCommand("sp_Themloairem", cnn))
                                        {
                                            cnn.Open();
                                            cmd.CommandType = CommandType.StoredProcedure;
                                            cmd.Parameters.AddWithValue("@sMaloairem", txtMaloairem.Text);
                                            cmd.Parameters.AddWithValue("@sTenloairem", txtTenloairem.Text);
                                            cmd.Parameters.AddWithValue("@sMaNcc", mancc);
                                            cmd.Parameters.AddWithValue("@fSoluong", txtSoluong.Text);
                                            cmd.Parameters.AddWithValue("@fDongia", txtDongia.Text);
                                            int i = cmd.ExecuteNonQuery();
                                            cnn.Close();
                                        }
                                    }
                                    btnBoqua_Click(sender, e);
                                }
                                else
                                    MessageBox.Show("Đơn giá phải > 0", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }
                            catch
                            {
                                MessageBox.Show("Sai kiểu dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }

                        }

                    }
                }

            }
        }



        private void btnSua_Click(object sender, EventArgs e)
        {
            string mancc;
            using (SqlConnection connection = new SqlConnection(str))
            {
                string sql = "select * from tblNhacungcap where sTenNcc = N'" + cbbTenncc.Text + "'";
                using (SqlDataAdapter adapter = new SqlDataAdapter(sql, connection))  //đọc ra k có tham số truyền vào
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    mancc = table.Rows[0][0].ToString();
                }
            }

            if (maLr.Equals(txtMaloairem.Text))
            {
                using (SqlCommand cmd = new SqlCommand("sp_Sualoairem", cnn))
                {
                    cnn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@sMaloairemmoi", txtMaloairem.Text);
                    cmd.Parameters.AddWithValue("@sMaloairemcu", maLr);
                    cmd.Parameters.AddWithValue("@sTenloairem", txtTenloairem.Text);
                    cmd.Parameters.AddWithValue("@sMaNcc", mancc);
                    cmd.Parameters.AddWithValue("@fSoluong", txtSoluong.Text);
                    cmd.Parameters.AddWithValue("@fDongia", txtDongia.Text);
                    int i = cmd.ExecuteNonQuery();
                    cnn.Close();
                }
                btnBoqua_Click(sender, e);
            }
            else
            {
                bool kiemtramancc = kiemtratrungkhoa("tblLoairem", txtMaloairem.Text, "sMaloairem");
                if (kiemtramancc)
                    MessageBox.Show("Mã rèm này đã tồn tại");
                else
                {
                    using (SqlCommand cmd = new SqlCommand("sp_Sualoairem", cnn))
                    {
                        cnn.Open();
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@sMaloairemmoi", txtMaloairem.Text);
                        cmd.Parameters.AddWithValue("@sMaloairemcu", maLr);
                        cmd.Parameters.AddWithValue("@sTenloairem", txtTenloairem.Text);
                        cmd.Parameters.AddWithValue("@sMaNcc", mancc);
                        cmd.Parameters.AddWithValue("@fSoluong", txtSoluong.Text);
                        cmd.Parameters.AddWithValue("@fDongia", txtDongia.Text);
                        int i = cmd.ExecuteNonQuery();
                        cnn.Close();
                    }
                }
                btnBoqua_Click(sender, e);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            using (SqlCommand cmd = new SqlCommand("sp_Xoaloairem", cnn))
            {
                cnn.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@sMaloairem", txtMaloairem.Text);
                bool trungkhoa = kiemtratrungkhoa("tblLoairem", txtMaloairem.Text, "sMaloairem");
                if (trungkhoa)
                {
                    DialogResult result= MessageBox.Show("Bạn có muốn xóa không?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        int i = cmd.ExecuteNonQuery();
                        MessageBox.Show("Xóa thành công");
                    }
                }
                else
                {

                    MessageBox.Show("Sản phẩm này đang ở trong 1 đơn hàng");
                } 
                cnn.Close();
            }
            btnBoqua_Click(sender, e);
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            errorLoairem.Clear();
            
            string sql = "select sMaloairem, sTenloairem, sTenNcc, fSoluong, fDongia from tblLoairem, tblNhacungcap" +
                " where tblLoairem.sMaNcc = tblNhacungcap.sMaNcc" + " ";
            if (txtMaloairem.Text != "")
            {
                sql = sql + " and sMaloairem like '%" + txtMaloairem.Text + "%'";
            }
            if (txtTenloairem.Text != "")
            {
                sql = sql + " and sTenloairem like N'%" + txtTenloairem.Text + "%'";
            }
            if (cbbTenncc.Text != "")
            {
                sql = sql + " and sTenNcc like N'%" + cbbTenncc.Text + "%'";
            }
            if (txtSoluong.Text != "")
            {
                sql = sql + " and fSoluong = " + float.Parse(txtSoluong.Text);
            }
            if (txtDongia.Text != "")
            {
                sql = sql + " and fDongia = " + float.Parse(txtDongia.Text);
            }

            using (SqlCommand cmd = new SqlCommand(sql, cnn))
            {
                cnn.Open();
                cmd.CommandType = CommandType.Text;
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dgrLoairem.DataSource = table;
                }
                MessageBox.Show("Tìm thành công!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                cnn.Close();
            } 
        }

        private void btnBoqua_Click(object sender, EventArgs e)
        {
            txtMaloairem.Clear();
            txtTenloairem.Clear();
            errorLoairem.Clear();
            txtSoluong.Clear();
            txtDongia.Clear();
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            hien();
        }
        private void goHome(String username)
        {
            FormTrangChu form = new FormTrangChu(username);
            form.Show();
            this.Hide();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                goHome(username);
            }    
        }

        private void frmLoairem_Load(object sender, EventArgs e)
        {
            btnBoqua_Click(sender, e);
        }
    }
}
