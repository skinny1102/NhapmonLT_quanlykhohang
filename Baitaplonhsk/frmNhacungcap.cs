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

namespace Baitaplonhsk
{
    public partial class frmNhacungcap : Form
    {
        public String username;
        public frmNhacungcap()
        {
            InitializeComponent();
        }
        public frmNhacungcap(String user)
        {
            InitializeComponent();
            this.username = user;
        }

        string maNCC;
        private static string str = ConfigurationManager.ConnectionStrings["quanlyxuatnhapkho2"].ConnectionString;
        private static SqlConnection cnn = new SqlConnection(str);

        static DataTable gettable (string tenbang)
        {
            string select = "select * from " + tenbang;
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
            using (SqlCommand cmd = new SqlCommand("select * from tblNhacungcap", cnn))
            {
                cnn.Open();
                cmd.CommandType = CommandType.Text;
                using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                {
                    DataTable table = new DataTable();
                    ad.Fill(table);
                    dgrNhacungcap.DataSource = table;
                }
                cnn.Close();
            }
        }

        private void dgrNhacungcap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnThem.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            errorNhacungcap.Clear();
            maNCC = txtMaNCC.Text = dgrNhacungcap.CurrentRow.Cells[0].Value.ToString();
            txtTenNCC.Text = dgrNhacungcap.CurrentRow.Cells[1].Value.ToString();
            txtTengiaodich.Text = dgrNhacungcap.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtDiachi.Text = dgrNhacungcap.CurrentRow.Cells[3].Value.ToString();
            txtSdt.Text = dgrNhacungcap.CurrentRow.Cells[4].Value.ToString();
        }

        private void txtMaNCC_Validating(object sender, CancelEventArgs e)
        {
            if (txtMaNCC.Text == "")
                errorNhacungcap.SetError(txtMaNCC, "Bạn phải nhập mã nhà cung cấp");
            else
                errorNhacungcap.SetError(txtMaNCC, "");
        }

        private void txtTenNCC_Validating(object sender, CancelEventArgs e)
        {
            if (txtTenNCC.Text == "")
                errorNhacungcap.SetError(txtTenNCC, "Bạn cần nhập tên nhà cung cấp");
            else
            {
                try
                {
                    int a = int.Parse(txtTenNCC.Text);
                    errorNhacungcap.SetError(txtTenNCC, "Sai kiểu dữ liệu");
                }
                catch
                {
                    errorNhacungcap.SetError(txtTenNCC, "");
                }
            }
        }

        private void txtTengiaodich_Validating(object sender, CancelEventArgs e)
        {
            if (txtTengiaodich.Text == "")
                errorNhacungcap.SetError(txtTengiaodich, "Bạn cần nhập tên giao dịch");
            else
            {
                try
                {
                    int a = int.Parse(txtTengiaodich.Text);
                    errorNhacungcap.SetError(txtTengiaodich, "Sai kiểu dữ liệu");
                }
                catch
                {
                    errorNhacungcap.SetError(txtTengiaodich, "");
                }
            }
        }

        private void txtSdt_Validating(object sender, CancelEventArgs e)
        {
            if (txtSdt.Text == "")
                errorNhacungcap.SetError(txtSdt, "Bạn cần nhập số điện thoại");
            else
            {
                try
                {
                    int a = int.Parse(txtSdt.Text);
                    errorNhacungcap.SetError(txtSdt, "");
                }
                catch
                {
                    errorNhacungcap.SetError(txtSdt, "Sai kiểu dữ liệu");
                }
            }
        }

        private void txtDiachi_Validating(object sender, CancelEventArgs e)
        {
            if (txtDiachi.Text == "")
                errorNhacungcap.SetError(txtDiachi, "Bạn phải nhập địa chỉ nhà cung cấp");
            else
                errorNhacungcap.SetError(txtDiachi, "");
        }


        static bool kiemtratrungkhoa(string tenbang, string khoa, string tencot)
        {
            bool kq;
            string select = "select " + tencot + " from " + tenbang + " where " + tencot + "= '" + khoa + "'";
            using (SqlDataAdapter ad = new SqlDataAdapter(select, cnn))
            {
                DataTable table = new DataTable();
                ad.Fill(table);
                if (table.Rows.Count > 0)
                    kq = true;
                else
                    kq = false;
            }
            return kq;
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            if ((txtMaNCC.Text == "") || (txtTenNCC.Text == "") || (txtTengiaodich.Text == "") || (txtSdt.Text == "") || (txtDiachi.Text == ""))
                MessageBox.Show("Bạn phải nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                bool kiemtramancc = kiemtratrungkhoa("tblNhacungcap", txtMaNCC.Text, "sMaNCC");
                if (kiemtramancc)
                    MessageBox.Show("Mã nhà cung cấp đã tồn tại");
                else
                {
                    using (SqlCommand cmd = new SqlCommand("sp_Themnhacungcap", cnn))
                    {
                        cnn.Open();
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@sMaNCC", txtMaNCC.Text);
                        cmd.Parameters.AddWithValue("@sTenNCC", txtTenNCC.Text);
                        cmd.Parameters.AddWithValue("@sTengiaodich", txtTengiaodich.Text);
                        cmd.Parameters.AddWithValue("@sDiachi", txtDiachi.Text);
                        cmd.Parameters.AddWithValue("@sDienthoai", txtSdt.Text);
                        int i = cmd.ExecuteNonQuery();
                        cnn.Close();
                    }
                }
            }
            btnBoqua_Click(sender, e);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (maNCC.Equals(txtMaNCC.Text))
            {
                using (SqlCommand cmd = new SqlCommand("sp_Suanhacungcap", cnn))
                {
                    cnn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@sMaNCCmoi", txtMaNCC.Text);
                    cmd.Parameters.AddWithValue("@sMaNCCcu", maNCC);
                    cmd.Parameters.AddWithValue("@sTenNCC", txtTenNCC.Text);
                    cmd.Parameters.AddWithValue("@sTengiaodich", txtTengiaodich.Text);
                    cmd.Parameters.AddWithValue("@sDiachi", txtDiachi.Text);
                    cmd.Parameters.AddWithValue("@sDienthoai", txtSdt.Text);
                    int i = cmd.ExecuteNonQuery();
                    cnn.Close();
                }
                btnBoqua_Click(sender,e);
            }
            else
            {
                bool kiemtramancc = kiemtratrungkhoa("tblNhacungcap", txtMaNCC.Text, "sMaNCC");
                if (kiemtramancc)
                    MessageBox.Show("Mã nhà cung cấp này đã tồn tại");
                else
                {
                    using (SqlCommand cmd = new SqlCommand("sp_Suanhacungcap", cnn))
                    {
                        cnn.Open();
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@sMaNCCmoi", txtMaNCC.Text);
                        cmd.Parameters.AddWithValue("@sMaNCCcu", maNCC);
                        cmd.Parameters.AddWithValue("@sTenNCC", txtTenNCC.Text);
                        cmd.Parameters.AddWithValue("@sTengiaodich", txtTengiaodich.Text);
                        cmd.Parameters.AddWithValue("@sDiachi", txtDiachi.Text);
                        cmd.Parameters.AddWithValue("@sDienthoai", txtSdt.Text);
                        int i = cmd.ExecuteNonQuery();
                        cnn.Close();
                    }
                } btnBoqua_Click(sender, e);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            using (SqlCommand cmd = new SqlCommand("sp_Xoanhacungcap", cnn))
            {
                cnn.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@sMaNCC", txtMaNCC.Text);
                bool trungkhoa = kiemtratrungkhoa("tblNhacungcap", txtMaNCC.Text, "sMaNcc");
                if (trungkhoa)
                {
                    int i = cmd.ExecuteNonQuery();
                }
                else MessageBox.Show("Mã nhà cung cấp này không tồn tại!");
                cnn.Close();
            }
            btnBoqua_Click(sender, e);
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            errorNhacungcap.Clear();
            string sql = "select sMaNcc, sTenNcc, sTengiaodich, sDiachi, sDienthoai" +
                " from tblNhacungcap where sMaNcc is not null" + " ";
            if (txtMaNCC.Text != "")
            {
                sql = sql + " and sMaNcc like '%" + txtMaNCC.Text + "%'";
            }
            if (txtTenNCC.Text != "")
            {
                sql = sql + " and sTenNcc like N'%" + txtTenNCC.Text + "%'";
            }
            if (txtTengiaodich.Text != "")
            {
                sql = sql + " and sTengiaodich like N'%" + txtTengiaodich.Text + "%'";
            }
            if (txtDiachi.Text != "")
            {
                sql = sql + " and sDiachi like N'%" + txtDiachi.Text + "%'";
            }
            if (txtSdt.Text != "")
            {
                sql = sql + " and sDienthoai like '%" + txtSdt.Text + "%'";
            }

            using (SqlCommand cmd = new SqlCommand(sql, cnn))
            {
                cnn.Open();
                cmd.CommandType = CommandType.Text;
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dgrNhacungcap.DataSource = table;
                }
                cnn.Close();
            }
        }

        private void btnBoqua_Click(object sender, EventArgs e)
        {
            txtMaNCC.Clear();
            txtTenNCC.Clear();
            txtTengiaodich.Clear();
            txtSdt.Clear();
            txtDiachi.Clear();
            errorNhacungcap.Clear();
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

        private void frmNhacungcap_Load(object sender, EventArgs e)
        {
            btnBoqua_Click(sender, e);
        }
    }
}
