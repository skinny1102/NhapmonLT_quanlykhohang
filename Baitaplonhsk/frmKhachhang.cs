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
    public partial class frmKhachhang : Form
    {
        public frmKhachhang()
        {
            InitializeComponent();
        }

        string maKH;
        private static string str = ConfigurationManager.ConnectionStrings["quanlyxuatnhapkho2"].ConnectionString;
        private static SqlConnection cnn = new SqlConnection(str);

        static DataTable gettable(string tenbang)
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
            using (SqlCommand cmd = new SqlCommand("select * from tblKhachhang", cnn))
            {
                cnn.Open();
                cmd.CommandType = CommandType.Text;
                using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                {
                    DataTable table = new DataTable();
                    ad.Fill(table);
                    dgrKhachhang.DataSource = table;
                }
                cnn.Close();
            }
        }

        public void clear()
        {
            txtMaKH.Clear();
            txtHotenKH.Clear();
            txtDiachiKH.Clear();
            rdbNam.AutoCheck = true;
            txtSdt.Clear();
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void dgrKhachhang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnThem.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            errorKhachhang.Clear();
            maKH = txtMaKH.Text = dgrKhachhang.CurrentRow.Cells[0].Value.ToString();
            txtHotenKH.Text = dgrKhachhang.CurrentRow.Cells[1].Value.ToString();
            if (dgrKhachhang.Rows[e.RowIndex].Cells[2].Value.ToString() == "Nam")
                rdbNam.Checked = true;
            else rdbNu.Checked = true;
            txtDiachiKH.Text = dgrKhachhang.CurrentRow.Cells[3].Value.ToString();
            txtSdt.Text = dgrKhachhang.CurrentRow.Cells[4].Value.ToString();
        }


        private void txtMaKH_Validating(object sender, CancelEventArgs e)
        {
            if (txtMaKH.Text == "")
                errorKhachhang.SetError(txtMaKH, "Bạn cần nhập mã khách hàng");
            else
                errorKhachhang.SetError(txtMaKH, "");
        }

        private void txtHotenKH_Validating(object sender, CancelEventArgs e)
        {
            if (txtHotenKH.Text == "")
                errorKhachhang.SetError(txtHotenKH, "Bạn cần nhập tên khách hàng");
            else
            {
                try
                {
                    int a = int.Parse(txtHotenKH.Text);
                    errorKhachhang.SetError(txtHotenKH, "Sai kiểu dữ liệu");
                }
                catch
                {
                    errorKhachhang.SetError(txtHotenKH, "");
                }
            }
        }

        private void txtSdt_Validating(object sender, CancelEventArgs e)
        {
            if (txtSdt.Text == "")
                errorKhachhang.SetError(txtSdt, "Bạn cần nhập số điện thoại");
            else
            {
                try
                {
                    int a = int.Parse(txtSdt.Text);
                    errorKhachhang.SetError(txtSdt, "");
                }
                catch
                {
                    errorKhachhang.SetError(txtSdt, "Sai kiểu dữ liệu");
                }
            }
        }

        private void txtDiachiKH_Validating(object sender, CancelEventArgs e)
        {
            if (txtDiachiKH.Text == "")
                errorKhachhang.SetError(txtDiachiKH, "Bạn cần nhập địa chỉ khách hàng");
            else
                errorKhachhang.SetError(txtDiachiKH, "");
        }

        private void frmKhachhang_Load(object sender, EventArgs e)
        {
            btnBoqua_Click(sender, e);
        }
        private void btnBoqua_Click(object sender, EventArgs e)
        {
            txtMaKH.Clear();
            txtHotenKH.Clear();
            txtSdt.Clear();
            txtDiachiKH.Clear();
            rdbNam.Checked = false;
            rdbNu.Checked = false;
            errorKhachhang.Clear();
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = true;
            hien();
        }

        
        static bool kiemtratrungkhoa(string tenbang, string khoa, string tencot)
        {
            bool kq;
            string select = "select " + tencot + " from " + tenbang + " where " + tencot + " = '" + khoa + "'";
            using (SqlDataAdapter ad = new SqlDataAdapter(select, cnn))
            {
                DataTable dataTable = new DataTable();
                ad.Fill(dataTable);
                if (dataTable.Rows.Count > 0)
                    kq = true;
                else
                    kq = false;
            }
            return kq;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if ((txtMaKH.Text=="") || (txtHotenKH.Text=="") || (txtSdt.Text=="") || (txtDiachiKH.Text == ""))
                MessageBox.Show("Bạn cần nhập đầy đủ thông tin khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                bool kiemtramakh = kiemtratrungkhoa("tblKhachhang", txtMaKH.Text, "sMaKH");
                if (kiemtramakh)
                    MessageBox.Show("Mã khách hàng đã tồn tại");
                else
                {
                    using (SqlCommand cmd = new SqlCommand("sp_Themkhachhang", cnn))
                    {
                        cnn.Open();
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@sMaKH", txtMaKH.Text);
                        cmd.Parameters.AddWithValue("@sTenKH", txtHotenKH.Text);
                        string gt;
                        if (rdbNam.Checked == true)
                            gt = "Nam";
                        else gt = "Nữ";
                        cmd.Parameters.AddWithValue("@sGioitinh", gt);
                        cmd.Parameters.AddWithValue("@sDiachi", txtDiachiKH.Text);
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
            if (maKH.Equals(txtMaKH.Text))
            {
                using (SqlCommand cmd = new SqlCommand("sp_Suakhachhang", cnn))
                {
                    cnn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@sMaKHmoi", txtMaKH.Text);
                    cmd.Parameters.AddWithValue("@sMaKHcu", maKH);
                    cmd.Parameters.AddWithValue("@sTenKH", txtHotenKH.Text);
                    string gt;
                    if (rdbNam.Checked == true)
                        gt = "Nam";
                    else gt = "Nữ";
                    cmd.Parameters.AddWithValue("@sGioitinh", gt);
                    cmd.Parameters.AddWithValue("@sDiachi", txtDiachiKH.Text);
                    cmd.Parameters.AddWithValue("@sDienthoai", txtSdt.Text);
                    int i = cmd.ExecuteNonQuery();
                    cnn.Close();
                }
                btnBoqua_Click(sender, e);
            }
            else
            {
                bool kiemtramakh = kiemtratrungkhoa("tblKhachhang", txtMaKH.Text, "sMaKH");
                if (kiemtramakh)
                    MessageBox.Show("Mã khách hàng này đã tồn tại");
                else
                {
                    using (SqlCommand cmd = new SqlCommand("sp_Suakhachhang", cnn))
                    {
                        cnn.Open();
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@sMaKHmoi", txtMaKH.Text);
                        cmd.Parameters.AddWithValue("@sMaKHcu", maKH);
                        cmd.Parameters.AddWithValue("@sTenKH", txtHotenKH.Text);
                        string gt;
                        if (rdbNam.Checked == true)
                            gt = "Nam";
                        else gt = "Nữ";
                        cmd.Parameters.AddWithValue("@sGioitinh", gt);
                        cmd.Parameters.AddWithValue("@sDiachi", txtDiachiKH.Text);
                        cmd.Parameters.AddWithValue("@sDienthoai", txtSdt.Text);
                        int i = cmd.ExecuteNonQuery();
                        cnn.Close();
                    }
                    btnBoqua_Click(sender,e);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            using (SqlCommand cmd = new SqlCommand("sp_Xoakhachhang", cnn))
            {
                cnn.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@sMaKH", txtMaKH.Text);
                bool trungkhoa = kiemtratrungkhoa("tblKhachhang", txtMaKH.Text, "sMaKH");
                if (trungkhoa)
                {
                    int i = cmd.ExecuteNonQuery();
                }
                else MessageBox.Show("Mã khách hàng này không tồn tại!");
                cnn.Close();
            }
            btnBoqua_Click(sender, e);
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                Close();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            errorKhachhang.Clear();
            string sql = "select sMaKH, sTenKH, sGioitinhKH, sDiachi, sDienthoai" +
                " from tblKhachhang where sMaKH is not null" + " ";
            if (txtMaKH.Text != "")
            {
                sql = sql + " and sMaKH like '%" + txtMaKH.Text + "%'";
            }
            if (txtHotenKH.Text != "")
            {
                sql = sql + " and sTenKh like N'%" + txtHotenKH.Text + "%'";
            }
            if (rdbNam.Checked == true)
            {
                sql = sql + " and sGioitinhKH = N'Nam'";
            }
            if (rdbNu.Checked == true)
                sql = sql + " and sGioitinhKH = N'Nữ'";
            if (txtDiachiKH.Text != "")
            {
                sql = sql + " and sDiachi like N'%" + txtDiachiKH.Text + "%'";
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
                    dgrKhachhang.DataSource = table;
                }
                cnn.Close();
            }
        }
    }
}
