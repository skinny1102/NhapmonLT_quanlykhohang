using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Baitaplonhsk
{
    public partial class frmDonnhaphang : Form
    {
        public String username;
        public frmDonnhaphang()
        {
            InitializeComponent();
        }
        public frmDonnhaphang(String user)
        {
            InitializeComponent();
            this.username = user;
        }

        Boolean checkmarem = true;
        DataTable Dscthd = new DataTable();
        string sohd;
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
            using(DataTable tblNv = gettable("tblNhanvien"))
            {
                DataView dv = new DataView(tblNv);
                dv.Sort = "sTenNV";
                cbbNhanvien.DataSource = dv;
                cbbNhanvien.DisplayMember = "sTenNV";
                cbbNhanvien.ValueMember = "sMaNV";
            }

            using (DataTable tbllr = gettable("tblLoairem"))
            {
                DataView dv = new DataView(tbllr);
                dv.Sort = "sMaloairem";
                cbbmarem.DataSource = dv;
                cbbmarem.DisplayMember = "sMaloairem";
                cbbmarem.ValueMember = "sMaloairem";
            }

            string select = "select sSohoadon, sTenNV, dNgaynhaphang  from tblDonnhaphang, tblNhanvien where tblDonnhaphang.sMaNV = tblNhanvien.sMaNV";
            using (SqlCommand cmd = new SqlCommand(select, cnn))
            {
                cnn.Open();
                cmd.CommandType = CommandType.Text;
                using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                {
                    DataTable table = new DataTable();
                    ad.Fill(table);
                    dgrDonnhaphang.DataSource = table;
                }
                cnn.Close();
            }
        }

        private void txtSoHD_Validating(object sender, CancelEventArgs e)
        {
            if (txtSoHD.Text == "")
                errorDonnhaphang.SetError(txtSoHD, "Bạn cần nhập số hóa đơn");
            else
                errorDonnhaphang.SetError(txtSoHD, "");
        }

        private void dtpNgaynhaphang_ValueChanged(object sender, EventArgs e)
        {
            dtpNgaynhaphang.CustomFormat = "MM/dd/yyyy";
        }

       
        private void dgrDonnhaphang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btninhoadon.Enabled = true;
            errorDonnhaphang.Clear();
            sohd = txtSoHD.Text = dgrDonnhaphang.CurrentRow.Cells[0].Value.ToString();
            cbbNhanvien.Text = dgrDonnhaphang.CurrentRow.Cells[1].Value.ToString();
            dtpNgaynhaphang.Text = dgrDonnhaphang.CurrentRow.Cells[2].Value.ToString();
            xemchitiethoadon(sohd);

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
            if (btnThem.Text == "Thêm")
            {
                txtSoHD.ReadOnly = false;
                txtSoHD.Focus();
                cbbNhanvien.Enabled = true;
                dtpNgaynhaphang.Enabled = true;
                cbbmarem.Enabled = true;
                txtSoluong.ReadOnly = false;
                txtGianhap.ReadOnly = false;
                btninhoadon.Enabled = false;
                btnthemlv.Visible = true;
                btnThem.Text = "Lưu";
                btnBoqua.Visible = true;
                try
                {
                    Dscthd.Columns.Add("sMaloairem");
                    Dscthd.Columns.Add("fSoluongnhap");
                    Dscthd.Columns.Add("fGianhap");
                }
                catch
                {
                    Dscthd.Rows.Clear();
                }
            }
            else
            {
                dtpNgaynhaphang.Value = new DateTime(dtpNgaynhaphang.Value.Year, dtpNgaynhaphang.Value.Month, dtpNgaynhaphang.Value.Day, 0, 0, 0);
                
                if (themhd(sender, e))
                {
                    foreach (DataRow row1 in Dscthd.Rows)
                    {
                        if (!themcthd(sender, e, row1))
                        {
                            xoahoadon(txtSoHD.Text);
                            MessageBox.Show("Thêm chi tiết hóa đơn thất bại!");
                            break;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Thêm thất bại !");
                }
                btnThem.Text = "Thêm";
                btnBoqua.Visible = false;
                btnthemlv.Visible = false;
                btnBoqua_Click(sender, e);
            }
        }


        private void xemchitiethoadon(String sohd)
        {
            string select = "select sMaloairem, fSoluongnhap, fGianhap from tblChiTietnhapHang where sSohoadon = '" + sohd + "'";
            using (SqlCommand cmd = new SqlCommand(select, cnn))
            {
                try
                {
                    cnn.Open();
                    DataTable cthd = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(cthd);
                    dgvctnhap.DataSource = cthd;
                }
                catch { }
                finally { cnn.Close(); }
            }
        }


        private Boolean xoahoadon(String mahd)
        {
            Boolean kt = false;
            using (SqlCommand cmd = new SqlCommand("sp_Xoadonnhaphang", cnn))
            {
                try
                {
                    cnn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@sSohoadon", mahd);
                    int i = cmd.ExecuteNonQuery();
                    kt = true;
                }
                catch { MessageBox.Show("Đã có lỗi xảy ra!"); kt = false; }
                finally
                {
                    cnn.Close();
                }
            }
            return kt;
        }

        private Boolean themcthd(object sender, EventArgs e, DataRow row)
        {
            Boolean kt = false;
            using (SqlCommand cmd = new SqlCommand("sp_Themchitietdonnhaphang", cnn))
            {
                try
                {
                    cnn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@sohd", txtSoHD.Text);
                    cmd.Parameters.AddWithValue("@loairem", row["sMaloairem"].ToString());
                    cmd.Parameters.AddWithValue("@soluong", float.Parse(row["fSoluongnhap"].ToString()));
                    cmd.Parameters.AddWithValue("@gia", float.Parse(row["fGianhap"].ToString()));
                    int i = cmd.ExecuteNonQuery();
                    kt = true;
                }
                catch { kt = false; }
                finally
                {
                    cnn.Close();
                }

            }
            return kt;
        }

        private Boolean themhd(object sender, EventArgs e)
        {
            string  manv;
            Boolean kt = false;
            
            try
            {
                manv = cbbNhanvien.SelectedValue.ToString();
            }
            catch
            {
                manv = "";
            }
            if ((txtSoHD.Text == "") || (cbbNhanvien.Text == "") || (dtpNgaynhaphang.Text == ""))
                MessageBox.Show("Bạn phải nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                bool kiemtrasohoadon = kiemtratrungkhoa("tblDonnhaphang", txtSoHD.Text, "sSohoadon");
                bool kiemtramanv = false;
                if (manv != "")
                    kiemtramanv = true;

                if (kiemtrasohoadon)
                    MessageBox.Show("Số hóa đơn đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    if (kiemtramanv)
                    {

                        using (SqlCommand cmd = new SqlCommand("sp_Themdonnhaphang", cnn))
                        {
                            try
                            {
                                cnn.Open();
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.AddWithValue("@sSohoadon", txtSoHD.Text);
                                cmd.Parameters.AddWithValue("@sMaNV", manv);
                                cmd.Parameters.AddWithValue("@dNgaynhaphang", dtpNgaynhaphang.Value);
                                int i = cmd.ExecuteNonQuery();
                                kt = true;
                            }
                            catch
                            {
                                kt = false;
                            }
                            finally
                            {
                                cnn.Close();
                            }
                        }
                    }
                    else
                        MessageBox.Show("Nhân viên này không tồn tại");
                }
            }
            return kt;
        }



        private void btnSua_Click(object sender, EventArgs e)
        {

            if (btnSua.Text == "Sửa")
            {
                btnSua.Text = "Lưu";
                btninhoadon.Enabled = false;
                btnThem.Enabled = false;
                btnXoa.Enabled = false;
                btnTimkiem.Enabled = false;
                btnsuachitiet.Enabled = true;
                btnxoachitiet.Enabled = true;
                btnsuachitiet.Visible = true;
                btnxoachitiet.Visible = true;
                txtSoHD.ReadOnly = true; 
                cbbNhanvien.Enabled = true;
                dtpNgaynhaphang.Enabled = true;
            }
            else
            {
                dtpNgaynhaphang.Value = new DateTime(dtpNgaynhaphang.Value.Year, dtpNgaynhaphang.Value.Month, dtpNgaynhaphang.Value.Day, 0, 0, 0);
                suahoadon(sender, e);
                btnBoqua_Click(sender, e);
            }
        }


        private void suahoadon(object sender, EventArgs e)
        {
            string manv;

            try
            {
                manv = cbbNhanvien.SelectedValue.ToString();
            }
            catch
            {
                manv = "";
            }

            if (sohd.Equals(txtSoHD.Text))
            {
                bool kiemtramanv = false;
                if (manv != "")
                    kiemtramanv = true;


                if (kiemtramanv)
                {
                    using (SqlCommand cmd = new SqlCommand("sp_Suadonnhaphang", cnn))
                    {
                        cnn.Open();
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@sSohoadonmoi", txtSoHD.Text);
                        cmd.Parameters.AddWithValue("@sSohoadoncu", sohd);
                        cmd.Parameters.AddWithValue("@sMaNV", manv);
                        cmd.Parameters.AddWithValue("@dNgaynhaphang", dtpNgaynhaphang.Value);
                        int i = cmd.ExecuteNonQuery();
                        cnn.Close();
                    }
                    btnBoqua_Click(sender, e);
                }
                else
                    MessageBox.Show("Nhân viên này không tồn tại");
            }
            else
            {
                bool kiemtrasohoadon = kiemtratrungkhoa("tblDonnhaphang", txtSoHD.Text, "sSohoadon");

                if (kiemtrasohoadon)
                    MessageBox.Show("Số hóa đơn đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    bool kiemtramanv = false;
                    if (manv != "")
                        kiemtramanv = true;
                    if (kiemtramanv)
                    {
                        using (SqlCommand cmd = new SqlCommand("sp_Suadonnhaphang", cnn))
                        {
                            cnn.Open();
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@sSohoadonmoi", txtSoHD.Text);
                            cmd.Parameters.AddWithValue("@sSohoadoncu", sohd);
                            cmd.Parameters.AddWithValue("@sMaNV", manv);
                            cmd.Parameters.AddWithValue("@dNgaynhaphang", dtpNgaynhaphang.Value);
                            int i = cmd.ExecuteNonQuery();
                            cnn.Close();
                        }
                        btnBoqua_Click(sender, e);
                    }
                    else
                        MessageBox.Show("Nhân viên này không tồn tại");
                }
            }
        }



        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                xoahoadon(txtSoHD.Text);
            btnBoqua_Click(sender, e);
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            if (btnTimkiem.Text == "Tìm kiếm")
            {
                btnTimkiem.Text = "Tìm";
                txtSoHD.Text = "";
                txtSoHD.ReadOnly = false;
                cbbNhanvien.Enabled = true;
                dtpNgaynhaphang.Enabled = true;
            }
            else
            {
                dtpNgaynhaphang.Value = new DateTime(dtpNgaynhaphang.Value.Year, dtpNgaynhaphang.Value.Month, dtpNgaynhaphang.Value.Day, 0, 0, 0);
                errorDonnhaphang.Clear();
                string sql = "select sSohoadon, sTenNV, dNgaynhaphang from tblDonnhaphang, tblNhanvien" +
                    " where tblNhanvien.sMaNV = tblDonnhaphang.sMaNV " + " ";
                if (txtSoHD.Text != "")
                {
                    sql = sql + " and sSohoadon like '%" + txtSoHD.Text + "%'";
                }
                if (cbbNhanvien.Text != "")
                {
                    sql = sql + " and sTenNV like N'%" + cbbNhanvien.Text + "%'";
                }
                if (dtpNgaynhaphang.Text != "MM/dd/yyyy")
                {
                    sql = sql + " and dNgaynhaphang = '" + dtpNgaynhaphang.Value + "'";
                }


                using (SqlCommand cmd = new SqlCommand(sql, cnn))
                {
                    cnn.Open();
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        dgrDonnhaphang.DataSource = table;
                    }
                    cnn.Close();
                }
            }
        }


        private void btnBoqua_Click(object sender, EventArgs e)
        {
            btnSua.Text = "Sửa";
            btnXoa.Text = "Xóa";
            txtSoHD.Text = "";
            btnsuachitiet.Enabled = false;
            btnxoachitiet.Enabled = false;
            btnsuachitiet.Visible = false;
            btnxoachitiet.Visible = false;
            btnThem.Text = "Thêm";
            dtpNgaynhaphang.CustomFormat = "'Ngày: 'dd', Tháng: 'MM', Năm: 'yyyy";
            txtSoHD.ReadOnly = true;
            cbbNhanvien.Enabled = false;
            cbbmarem.Enabled = false;
            txtSoluong.ReadOnly = true;
            btnTimkiem.Enabled = true;
            txtGianhap.ReadOnly = true;
            dtpNgaynhaphang.Enabled = false;
            txtSoluong.Text = "";
            txtGianhap.Text = "";
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnthemlv.Visible = false;
            btninhoadon.Enabled = false;
            btnBoqua.Visible = false;
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

        private void frmDonnhaphang_Load(object sender, EventArgs e)
        {
            btnBoqua_Click(sender, e);
        }


        private void cbbNhanvien_Validating(object sender, CancelEventArgs e)
        {
            if (cbbNhanvien.Text == "")
                errorDonnhaphang.SetError(cbbNhanvien, "Bạn cần nhập họ tên nhân viên");
            else
            {
                try
                {
                    int a = int.Parse(cbbNhanvien.Text);
                    errorDonnhaphang.SetError(cbbNhanvien, "Sai kiểu dữ liệu");
                }
                catch
                {
                    errorDonnhaphang.SetError(cbbNhanvien, "");
                }
            }
        }

        private void btnthemlv_Click(object sender, EventArgs e)
        {
            if (checkmarem)
            {
                Boolean nhapmoi = true;
                foreach (DataRow row1 in Dscthd.Rows)
                {

                    if (cbbmarem.Text == row1["sMaloairem"].ToString())
                    {
                        if (txtGianhap.Text == row1["fGianhap"].ToString())
                        {
                            row1["fSoluongmua"] = float.Parse(txtSoluong.Text) + float.Parse(row1["fSoluongnhap"].ToString());
                            nhapmoi = false;
                            errorDonnhaphang.SetError(txtGianhap, "");
                        }
                        else
                        {
                            errorDonnhaphang.SetError(txtGianhap, "Sai đơn giá!");
                            nhapmoi = false;
                        }
                    }
                }
                if (nhapmoi)
                {
                    errorDonnhaphang.SetError(txtGianhap, "");
                    DataRow row = Dscthd.NewRow();
                    row["sMaloairem"] = cbbmarem.Text;
                    row["fGianhap"] = txtGianhap.Text;
                    row["fSoluongnhap"] = txtSoluong.Text;
                    Dscthd.Rows.Add(row);
                    dgvctnhap.DataSource = Dscthd;
                }
                txtSoluong.Text = "";
                txtGianhap.Text = "";
            }
        }

        private void cbbmarem_Leave(object sender, EventArgs e)
        {
            using (SqlCommand cmd = new SqlCommand("checkmarem", cnn))
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@maloai", cbbmarem.Text);
                    cnn.Open();
                    DataTable table = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(table);
                    if (table.Rows.Count >= 1)
                    { checkmarem = true; errorDonnhaphang.SetError(cbbmarem, ""); }
                    else checkmarem = false;
                }
                catch { checkmarem = false; }
                finally { cnn.Close(); }
            }
            if (!checkmarem)
            {
                errorDonnhaphang.SetError(cbbmarem, "Không tồn tại!");
            }
        }

        private void dgvctnhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int i = e.RowIndex;
                cbbmarem.Text = dgvctnhap.Rows[i].Cells[0].Value.ToString();
                
                txtSoluong.Text = dgvctnhap.Rows[i].Cells[1].Value.ToString();
                txtGianhap.Text = dgvctnhap.Rows[i].Cells[2].Value.ToString();
                if (btnSua.Text == "Lưu")
                {
                    btnsuachitiet.Enabled = true;
                    btnxoachitiet.Enabled = true;
                    txtSoluong.ReadOnly = false;
                    txtGianhap.ReadOnly = false;
                }

            }
            catch { }
        }

        private void btnsuachitiet_Click(object sender, EventArgs e)
        {
            using (SqlCommand cmd = new SqlCommand("sp_Suachitietdonnhaphang", cnn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@sohd", txtSoHD.Text);
                cmd.Parameters.AddWithValue("@loairem", cbbmarem.Text);
                cmd.Parameters.AddWithValue("@soluong", float.Parse(txtSoluong.Text));
                cmd.Parameters.AddWithValue("@gianhap", float.Parse(txtGianhap.Text));
                try
                {
                    cnn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch
                {
                    MessageBox.Show("Đã có lỗi xảy ra!");
                }
                finally { cnn.Close(); }
            }
            xemchitiethoadon(txtSoHD.Text);
        }



        private void btnxoachitiet_Click(object sender, EventArgs e)
        {
            if (dgvctnhap.Rows.Count > 2)
            {
                DialogResult result = MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    using (SqlCommand cmd = new SqlCommand("sp_Xoachitietdonnhaphang", cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@sohd", txtSoHD.Text);
                        cmd.Parameters.AddWithValue("@loairem", cbbmarem.Text);
                        try
                        {
                            cnn.Open();
                            cmd.ExecuteNonQuery();
                        }
                        catch
                        {
                            MessageBox.Show("Đã có lỗi xảy ra! Chi tiết hóa đơn này không tồn tại");
                        }
                        finally { cnn.Close(); }
                    }
                    xemchitiethoadon(txtSoHD.Text);
                }
            }
            else
            {
                DialogResult result = MessageBox.Show("Xóa bản ghi cuối cùng hóa đơn sẽ bị xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    xoahoadon(txtSoHD.Text);
                    btnBoqua_Click(sender, e);
                }
            }
        }

        private void btninhoadon_Click(object sender, EventArgs e)
        {
            frmbaocao f1 = new frmbaocao();
            donnhaphang baocao = new donnhaphang();
            DataTable table = new DataTable();
            using (SqlCommand cmd = new SqlCommand("sp_Indonnhaphang", cnn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@sohd", txtSoHD.Text);
                try
                {
                    cnn.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(table);
                }
                catch
                {
                    MessageBox.Show("Đã có lỗi xảy ra!");
                }
                finally
                {
                    cnn.Close();
                }
            }

            baocao.SetDataSource(table);
            f1.crystalReportViewer1.ReportSource = baocao;
            f1.Show();
        }

        private void cbbNhanvien_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
