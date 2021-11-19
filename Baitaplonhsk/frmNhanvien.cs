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
    public partial class frmNhanvien : Form
    {
        String username;
        public frmNhanvien()
        {
            InitializeComponent();
        }
        public frmNhanvien(String user)
        {
            this.username = user;
            InitializeComponent();
        }
        string maNv;
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
            using (SqlCommand cmd = new SqlCommand("select * from tblNhanvien", cnn))
            {
                cnn.Open();
                cmd.CommandType = CommandType.Text;
                using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                {
                    DataTable table = new DataTable();
                    ad.Fill(table);
                    dgrNhanvien.DataSource = table;
                }
                cnn.Close();
            }
        }

        
        private void frmNhanvien_Load(object sender, EventArgs e)
        {
            btnBoqua_Click(sender,e);
        }

       private void dgrNhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnThem.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            errorNhanvien.Clear();
            maNv=txtMaNV.Text = dgrNhanvien.CurrentRow.Cells[0].Value.ToString();
            txtHotenNV.Text = dgrNhanvien.CurrentRow.Cells[1].Value.ToString();
            dtpNgaysinhnv.Text = dgrNhanvien.CurrentRow.Cells[2].Value.ToString();
            if (dgrNhanvien.Rows[e.RowIndex].Cells[3].Value.ToString()=="Nam")
                rdbNam.Checked = true;
            else rdbNu.Checked = true;
            txtDiachiNV.Text = dgrNhanvien.CurrentRow.Cells[4].Value.ToString();
            txtSdt.Text = dgrNhanvien.CurrentRow.Cells[5].Value.ToString();
            dtpNgayvaolam.Text = dgrNhanvien.CurrentRow.Cells[6].Value.ToString();
            txtLcb.Text = dgrNhanvien.CurrentRow.Cells[7].Value.ToString();
        }


        private void txtMaNV_Validating(object sender, CancelEventArgs e)
        {
            if (txtMaNV.Text == "")
                errorNhanvien.SetError(txtMaNV, "Bạn cần nhập mã nhân viên");
            else
                errorNhanvien.SetError(txtMaNV, "");
        }

        private void txtHotenNV_Validating(object sender, CancelEventArgs e)
        {
            if (txtHotenNV.Text == "")
                errorNhanvien.SetError(txtHotenNV, "Bạn cần nhập họ tên nhân viên");
            else
            {
                try
                {
                    int a = int.Parse(txtHotenNV.Text);
                    errorNhanvien.SetError(txtHotenNV, "Sai kiểu dữ liệu");
                }
                catch
                {
                    errorNhanvien.SetError(txtHotenNV, "");
                }
            }     
        }


        private void txtSdt_Validating(object sender, CancelEventArgs e)
        {
            if (txtSdt.Text == "")
                errorNhanvien.SetError(txtSdt, "Bạn cần nhập số điện thoại");
            else
            {
                try
                {
                    int a = int.Parse(txtSdt.Text);
                    errorNhanvien.SetError(txtSdt, "");
                }
                catch
                {
                    errorNhanvien.SetError(txtSdt, "Sai kiểu dữ liệu");
                }
            }
        }
        private void txtDiachiNV_Validating(object sender, CancelEventArgs e)
        {
            if (txtDiachiNV.Text == "")
                errorNhanvien.SetError(txtDiachiNV, "Bạn cần nhập địa chỉ nhân viên");
            else
                errorNhanvien.SetError(txtDiachiNV,"");
        }

        private void txtLcb_Validating(object sender, CancelEventArgs e)
        {
            if (txtLcb.Text == "")
                errorNhanvien.SetError(txtLcb, "Bạn cần nhập lương cơ bản của nhân viên");
            else
            {
                try
                {
                    int a = int.Parse(txtLcb.Text);
                    errorNhanvien.SetError(txtLcb, "");
                }
                catch
                {
                    errorNhanvien.SetError(txtLcb, "Bạn phải nhập kiểu số");
                }
            }
        }

        private void btnBoqua_Click(object sender, EventArgs e)
        {
            txtMaNV.Clear();
            txtHotenNV.Clear();
            txtDiachiNV.Clear();
            errorNhanvien.Clear();
            rdbNam.Checked = false;
            rdbNu.Checked = false;
            dtpNgaysinhnv.Value = DateTime.Now;
            dtpNgayvaolam.Value = DateTime.Now;
            dtpNgaysinhnv.CustomFormat = "'MM/dd/yyyy'";
            dtpNgayvaolam.CustomFormat = "'MM/dd/yyyy'";
            txtSdt.Clear();
            txtLcb.Clear();
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
            if(result == DialogResult.Yes)
            {
                goHome(username);
            }    
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
            if ((txtMaNV.Text == "") || (txtHotenNV.Text == "") || (txtDiachiNV.Text == "") || (txtLcb.Text == "") || (dtpNgaysinhnv.Text == "") || (dtpNgayvaolam.Text == "") || (txtSdt.Text == ""))
                MessageBox.Show("Bạn phải nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                bool kiemtramanv = kiemtratrungkhoa("tblNhanvien", txtMaNV.Text, "sMaNV");
                if (kiemtramanv)
                    MessageBox.Show("Mã nhân viên đã tồn tại");
                else
                {
                    using (SqlCommand cmd = new SqlCommand("sp_Themnhanvien", cnn))
                    {
                        cnn.Open();
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@sMaNV", txtMaNV.Text);
                        cmd.Parameters.AddWithValue("@sTenNV", txtHotenNV.Text);
                        cmd.Parameters.AddWithValue("@dNgaysinh", dtpNgaysinhnv.Text);
                        string gt;
                        if (rdbNam.Checked == true)
                            gt = "Nam";
                        else gt = "Nữ";
                        cmd.Parameters.AddWithValue("@sGioitinh", gt);
                        cmd.Parameters.AddWithValue("@sDiachi", txtDiachiNV.Text);
                        cmd.Parameters.AddWithValue("@sDienthoai", txtSdt.Text);
                        cmd.Parameters.AddWithValue("@dNgayvaolam", dtpNgayvaolam.Text);
                        cmd.Parameters.AddWithValue("@fLuongcoban", txtLcb.Text);
                        int i = cmd.ExecuteNonQuery();
                        cnn.Close();
                    }
                }
            }

            btnBoqua_Click(sender, e);
        }


        private void btnSua_Click(object sender, EventArgs e)
        {
            if (maNv.Equals(txtMaNV.Text))
            {
                using (SqlCommand cmd = new SqlCommand("sp_Suanhanvien", cnn))
                {
                    cnn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@sMaNVmoi", txtMaNV.Text);
                    cmd.Parameters.AddWithValue("@sMaNVcu", maNv);
                    cmd.Parameters.AddWithValue("@sTenNV", txtHotenNV.Text);
                    cmd.Parameters.AddWithValue("@dNgaysinh", dtpNgaysinhnv.Text);
                    string gt;
                    if (rdbNam.Checked == true)
                        gt = "Nam";
                    else gt = "Nữ";
                    cmd.Parameters.AddWithValue("@sGioitinh", gt);
                    cmd.Parameters.AddWithValue("@sDiachi", txtDiachiNV.Text);
                    cmd.Parameters.AddWithValue("@sDienthoai", txtSdt.Text);
                    cmd.Parameters.AddWithValue("@dNgayvaolam", dtpNgayvaolam.Text);
                    cmd.Parameters.AddWithValue("@fLuongcoban", txtLcb.Text);
                    int i = cmd.ExecuteNonQuery();
                    cnn.Close();
                }
                btnBoqua_Click(sender, e);
            }
            else
            {
                bool kiemtramanv = kiemtratrungkhoa("tblNhanvien", txtMaNV.Text, "sMaNV");
                if (kiemtramanv)
                    MessageBox.Show("Mã nhân viên này đã tồn tại");
                else
                {
                    using (SqlCommand cmd = new SqlCommand("sp_Suanhanvien", cnn))
                    {
                        cnn.Open();
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@sMaNVmoi", txtMaNV.Text);
                        cmd.Parameters.AddWithValue("@sMaNVcu", maNv);
                        cmd.Parameters.AddWithValue("@sTenNV", txtHotenNV.Text);
                        cmd.Parameters.AddWithValue("@dNgaysinh", dtpNgaysinhnv.Text);
                        string gt;
                        if (rdbNam.Checked == true)
                            gt = "Nam";
                        else gt = "Nữ";
                        cmd.Parameters.AddWithValue("@sGioitinh", gt);
                        cmd.Parameters.AddWithValue("@sDiachi", txtDiachiNV.Text);
                        cmd.Parameters.AddWithValue("@sDienthoai", txtSdt.Text);
                        cmd.Parameters.AddWithValue("@dNgayvaolam", dtpNgayvaolam.Text);
                        cmd.Parameters.AddWithValue("@fLuongcoban", txtLcb.Text);
                        int i = cmd.ExecuteNonQuery();
                        cnn.Close();
                    }
                    btnBoqua_Click(sender, e);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            using (SqlCommand cmd = new SqlCommand("sp_Xoanhanvien", cnn))
            {
                cnn.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@sMaNV", txtMaNV.Text);
                bool trungkhoa = kiemtratrungkhoa("tblNhanvien", txtMaNV.Text, "sMaNV");
                if (trungkhoa)
                {
                    try
                    {
                        int i = cmd.ExecuteNonQuery();
                        MessageBox.Show("Xóa thành công");
                    }
                    catch
                    {
                        MessageBox.Show("Nhân viên này đang trong 1 hóa đơn");
                    }
                
            
                }
                else MessageBox.Show("Mã nhân viên này không tồn tại!");
                cnn.Close();
            }
            btnBoqua_Click(sender, e);
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {

            errorNhanvien.Clear();
            string sql = "select sMaNV, sTenNV, dNgaysinh, sGioitinh, sDiachi, sDienthoai, dNgayvaolam, fLuongcoban" +
                " from tblNhanvien where sMaNV is not null" + " ";
            if (txtMaNV.Text != "")
            {
                sql = sql + " and sMaNV like '%" + txtMaNV.Text + "%'";
            }
            if (txtHotenNV.Text != "")
            {
                sql = sql + " and sTenNV like N'%" + txtHotenNV.Text + "%'";
            }
            if (dtpNgaysinhnv.Text != "MM/dd/yyyy")
            {
                sql = sql + " and dNgaysinh = '" + dtpNgaysinhnv.Text + "'";
            }
            if (rdbNam.Checked == true)
            {
                sql = sql + " and sGioitinh = N'Nam'";
            }
            else if (rdbNu.Checked == true)
                sql = sql + " and sGioitinh = N'Nữ'";
            if (txtDiachiNV.Text != "")
            {
                sql = sql + " and sDiachi like N'%" + txtDiachiNV.Text + "%'";
            }
            if (txtSdt.Text != "")
            {
                sql = sql + " and sDienthoai like '%" + txtSdt.Text + "%'";
            }
            if (dtpNgayvaolam.Text != "MM/dd/yyyy")
            {
                sql = sql + " and dNgayvaolam = '" + dtpNgayvaolam.Text + "'";
            }
            if (txtLcb.Text != "")
            {
                sql = sql + " and fLuongcoban = " + float.Parse(txtLcb.Text);
            }

            using (SqlCommand cmd = new SqlCommand(sql, cnn))
            {
                cnn.Open();
                cmd.CommandType = CommandType.Text;
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dgrNhanvien.DataSource = table;
                }
                cnn.Close();
            }
        }

        private void dtpNgaysinhnv_ValueChanged(object sender, EventArgs e)
        {
            dtpNgaysinhnv.CustomFormat = "MM/dd/yyyy";
        }

        private void dtpNgayvaolam_ValueChanged(object sender, EventArgs e)
        {
            dtpNgayvaolam.CustomFormat = "MM/dd/yyyy";
        }
    }
}
