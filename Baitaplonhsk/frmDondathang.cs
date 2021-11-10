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
using System.ComponentModel.Design;

namespace Baitaplonhsk
{
    public partial class frmDondathang : Form
    {
        public String username;
        Boolean checkmarem = true;
        DataTable Dscthd = new DataTable();
        public frmDondathang()
        {
            InitializeComponent();
        }
        public frmDondathang(String user)
        {
            InitializeComponent();
            this.username = user;
        }

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

            using (DataTable tblkh = gettable("tblKhachhang"))
            {
                DataView dv = new DataView(tblkh);
                dv.Sort = "sTenKH";
                cbbKhachhang.DataSource = dv;
                cbbKhachhang.DisplayMember = "sTenKH";
                cbbKhachhang.ValueMember = "sMaKH";
            }
            using (DataTable tbllr = gettable("tblLoairem"))
            {
                DataView dv = new DataView(tbllr);
                dv.Sort = "sMaloairem";
                cbbmarem.DataSource = dv;
                cbbmarem.DisplayMember = "sMaloairem";
                cbbmarem.ValueMember = "sMaloairem";
            }
            using (DataTable tblNv = gettable("tblNhanvien"))
            {
                DataView dv = new DataView(tblNv);
                dv.Sort = "sTenNV";
                cbbNhanvien.DataSource = dv;
                cbbNhanvien.DisplayMember = "sTenNV";
                cbbNhanvien.ValueMember = "sMaNV";
            }
            string select = "select sSohoadon, sTenNV, sTenKH, dNgaydathang, dNgaygiaohang, sDiachigiaohang" +
                            " from tblDondathang, tblNhanvien, tblKhachhang where tblDondathang.sMaNV = tblNhanvien.sMaNV and tblKhachhang.sMaKH = tblDondathang.sMaKH";
            using (SqlCommand cmd = new SqlCommand(select, cnn))
            {
                cnn.Open();
                cmd.CommandType = CommandType.Text;
                using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                {
                    DataTable table = new DataTable();
                    ad.Fill(table);
                    dgrDondathang.DataSource = table;
                }
                cnn.Close();
            }
            
        }

        private void frmDondathang_Load(object sender, EventArgs e)
        {
            btnBoqua_Click(sender, e);

        }

        private void txtSoHD_Validating(object sender, CancelEventArgs e)
        {
            if (txtSoHD.Text == "")
                errorDondathang.SetError(txtSoHD, "Bạn cần nhập số hóa đơn");
            else
                errorDondathang.SetError(txtSoHD, "");
        }

        

        private void txtDiachigiao_Validating(object sender, CancelEventArgs e)
        {
            if (txtDiachigiao.Text == "")
                errorDondathang.SetError(txtDiachigiao, "Bạn cần nhập địa chỉ giao");
            else
            {
                try
                {
                    int a = int.Parse(txtDiachigiao.Text);
                    errorDondathang.SetError(txtDiachigiao, "Sai kiểu dữ liệu");
                }
                catch
                {
                    errorDondathang.SetError(txtDiachigiao, "");
                }
            }
        }

        private void dtpNgaydathang_ValueChanged(object sender, EventArgs e)
        {
            dtpNgaydathang.CustomFormat = "MM/dd/yyyy";
        }

        private void dtpNgaygiaohang_ValueChanged(object sender, EventArgs e)
        {
            dtpNgaygiaohang.CustomFormat = "MM/dd/yyyy";
        }

        private void dgrDondathang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btninhoadon.Enabled = true;
            errorDondathang.Clear();
            sohd = txtSoHD.Text = dgrDondathang.CurrentRow.Cells[0].Value.ToString();
            cbbNhanvien.Text = dgrDondathang.CurrentRow.Cells[1].Value.ToString();
            cbbKhachhang.Text = dgrDondathang.CurrentRow.Cells[2].Value.ToString();
            dtpNgaydathang.Text = dgrDondathang.CurrentRow.Cells[3].Value.ToString();
            dtpNgaygiaohang.Text = dgrDondathang.CurrentRow.Cells[4].Value.ToString();
            txtDiachigiao.Text = dgrDondathang.CurrentRow.Cells[5].Value.ToString();
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
                cbbKhachhang.Enabled = true;
                txtDiachigiao.ReadOnly = false;
                dtpNgaydathang.Enabled = true;
                dtpNgaygiaohang.Enabled = true;
                cbbmarem.Enabled = true;
                txtsoluong.ReadOnly = false;
                txtdongia.ReadOnly = false;
                btninhoadon.Enabled = false;
                btnthemlv.Visible = true;
                btnThem.Text = "Lưu";
                btnBoqua.Visible = true;
                try
                {
                    Dscthd.Columns.Add("sMaloairem");
                    Dscthd.Columns.Add("fSoluongmua");
                    Dscthd.Columns.Add("fGiaban");
                }
                catch {
                    Dscthd.Rows.Clear();
                }
            }
            else
            {
                dtpNgaydathang.Value = new DateTime(dtpNgaydathang.Value.Year, dtpNgaydathang.Value.Month, dtpNgaydathang.Value.Day, 0, 0, 0);
                dtpNgaygiaohang.Value = new DateTime(dtpNgaygiaohang.Value.Year, dtpNgaygiaohang.Value.Month, dtpNgaygiaohang.Value.Day, 0, 0, 0);
                if (themhd(sender, e))
                {
                    foreach (DataRow row1 in Dscthd.Rows)
                    {
                        if (!themcthd(sender, e, row1)) {
                            xoahoadon(txtSoHD.Text);
                            MessageBox.Show("Thêm thất bại chi ti!");
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
            string select = "select sMaloairem, fSoluongmua, fGiaban from tblChiTietDatHang where sSohoadon = '" + sohd + "'";
            using (SqlCommand cmd = new SqlCommand(select, cnn))
            {
                try
                {
                    cnn.Open();
                    DataTable cthd = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(cthd);
                    dgvctdat.DataSource = cthd;
                }
                catch { }
                finally { cnn.Close(); }
            }
        }
        private Boolean xoahoadon(String mahd)
        {
            Boolean kt = false;
            using (SqlCommand cmd = new SqlCommand("sp_Xoadondathang", cnn))
            {
                try
                {
                    cnn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@sSohoadon", mahd);
                    int i = cmd.ExecuteNonQuery();
                    kt = true;
                }
                catch { MessageBox.Show("Đã có lỗi xảy ra!");kt = false; }
                finally { cnn.Close();}
            }
            return kt;
        }
        private Boolean themcthd(object sender, EventArgs e, DataRow row)
        {
            Boolean kt = false;
            using (SqlCommand cmd = new SqlCommand("sp_Themchitietdondathang", cnn))
            {
                try
                {
                    cnn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@sohd", txtSoHD.Text);
                    cmd.Parameters.AddWithValue("@loairem", row["sMaloairem"].ToString());
                    cmd.Parameters.AddWithValue("@soluong", float.Parse(row["fSoluongmua"].ToString()));
                    cmd.Parameters.AddWithValue("@gia", float.Parse(row["fGiaban"].ToString()));
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
            string makh, manv;
            Boolean kt = false;
            try
            {
                makh = cbbKhachhang.SelectedValue.ToString();
            }
            catch
            {
                makh = "";
            }
            try
            {
                manv = cbbNhanvien.SelectedValue.ToString();
            }
            catch
            {
                manv = "";
            }
            if ((txtSoHD.Text == "") || (cbbNhanvien.Text == "") || (cbbKhachhang.Text == "") || (txtDiachigiao.Text == ""))
                MessageBox.Show("Bạn phải nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                bool kiemtrasohoadon = kiemtratrungkhoa("tblDondathang", txtSoHD.Text, "sSohoadon");
                bool kiemtramanv = false;
                if (manv != "")
                    kiemtramanv = true;

                bool kiemtramakh = false;
                if (makh != "")
                    kiemtramakh = true;

                if (kiemtrasohoadon)
                    MessageBox.Show("Số hóa đơn đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    if (kiemtramanv)
                    {
                        if (kiemtramakh)
                        {
                            using (SqlCommand cmd = new SqlCommand("sp_Themdondathang", cnn))
                            {
                                try
                                {
                                    cnn.Open();
                                    cmd.CommandType = CommandType.StoredProcedure;
                                    cmd.Parameters.AddWithValue("@sSohoadon", txtSoHD.Text);
                                    cmd.Parameters.AddWithValue("@sMaNV", manv);
                                    cmd.Parameters.AddWithValue("@sMaKH", makh);
                                    cmd.Parameters.AddWithValue("@dNgaydathang", dtpNgaydathang.Value);
                                    cmd.Parameters.AddWithValue("@dNgaygiaohang", dtpNgaygiaohang.Value);
                                    cmd.Parameters.AddWithValue("@sDiachigiaohang", txtDiachigiao.Text);
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
                        else MessageBox.Show("Khách hàng không tồn tại");
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
                cbbKhachhang.Enabled = true;
                cbbNhanvien.Enabled = true;
                txtDiachigiao.ReadOnly = false;
                dtpNgaygiaohang.Enabled = true;
            }
            else
            {
                dtpNgaydathang.Value = new DateTime(dtpNgaydathang.Value.Year, dtpNgaydathang.Value.Month, dtpNgaydathang.Value.Day, 0, 0, 0);
                dtpNgaygiaohang.Value = new DateTime(dtpNgaygiaohang.Value.Year, dtpNgaygiaohang.Value.Month, dtpNgaygiaohang.Value.Day, 0, 0, 0);
                suahoadon(sender, e);
                btnBoqua_Click(sender, e);
            }
        }

        private void suahoadon (object sender, EventArgs e)
        {
            string makh, manv;
            try
            {
                makh = cbbKhachhang.SelectedValue.ToString();
            }
            catch
            {
                makh = "";
            }

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

                bool kiemtramakh = false;
                if (makh != "")
                    kiemtramakh = true;

                if (kiemtramanv)
                {
                    if (kiemtramakh)
                    {
                        using (SqlCommand cmd = new SqlCommand("sp_Suadondathang", cnn))
                        {
                            cnn.Open();
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@sSohoadonmoi", txtSoHD.Text);
                            cmd.Parameters.AddWithValue("@sSohoadoncu", sohd);
                            cmd.Parameters.AddWithValue("@sMaNV", manv);
                            cmd.Parameters.AddWithValue("@sMaKH", makh);
                            cmd.Parameters.AddWithValue("@dNgaydathang", dtpNgaydathang.Value);
                            cmd.Parameters.AddWithValue("@dNgaygiaohang", dtpNgaygiaohang.Value);
                            cmd.Parameters.AddWithValue("@sDiachigiaohang", txtDiachigiao.Text);
                            int i = cmd.ExecuteNonQuery();
                            cnn.Close();
                        }
                    }
                    else MessageBox.Show("Khách hàng không tồn tại");
                }
                else
                    MessageBox.Show("Nhân viên này không tồn tại");
            }
            else
            {
                bool kiemtrasohoadon = kiemtratrungkhoa("tblDondathang", txtSoHD.Text, "sSohoadon");

                if (kiemtrasohoadon)
                    MessageBox.Show("Số hóa đơn đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    bool kiemtramanv = false;
                    if (manv != "")
                        kiemtramanv = true;

                    bool kiemtramakh = false;
                    if (makh != "")
                        kiemtramakh = true;

                    if (kiemtramanv)
                    {
                        if (kiemtramakh)
                        {
                            using (SqlCommand cmd = new SqlCommand("sp_Suadondathang", cnn))
                            {
                                cnn.Open();
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.AddWithValue("@sSohoadonmoi", txtSoHD.Text);
                                cmd.Parameters.AddWithValue("@sSohoadoncu", sohd);
                                cmd.Parameters.AddWithValue("@sMaNV", manv);
                                cmd.Parameters.AddWithValue("@sMaKH", makh);
                                cmd.Parameters.AddWithValue("@dNgaydathang", dtpNgaydathang.Text);
                                cmd.Parameters.AddWithValue("@dNgaygiaohang", dtpNgaygiaohang.Text);
                                cmd.Parameters.AddWithValue("@sDiachigiaohang", txtDiachigiao.Text);
                                int i = cmd.ExecuteNonQuery();
                                cnn.Close();
                            }
                        }
                        else MessageBox.Show("Khachs hang k ton tai");
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
            if (btnTimkiem.Text == "Tìm kiếm") {
                btnTimkiem.Text = "Tìm";
                txtSoHD.Text = "";
                txtSoHD.ReadOnly = false;
                cbbKhachhang.Enabled = true;
                cbbNhanvien.Enabled = true;
                txtDiachigiao.Text = "";
                txtDiachigiao.ReadOnly = false;
                dtpNgaydathang.Enabled = true;
                dtpNgaygiaohang.Enabled = true;
            }
            else
            {
                dtpNgaydathang.Value = new DateTime(dtpNgaydathang.Value.Year, dtpNgaydathang.Value.Month, dtpNgaydathang.Value.Day, 0, 0, 0);
                dtpNgaygiaohang.Value = new DateTime(dtpNgaygiaohang.Value.Year, dtpNgaygiaohang.Value.Month, dtpNgaygiaohang.Value.Day, 0, 0, 0);
                errorDondathang.Clear();
                string sql = "select sSohoadon, sTenNV, sTenKH, dNgaydathang, dNgaygiaohang, sDiachigiaohang from tblDondathang, tblNhanvien, tblKhachhang" +
                    " where tblDondathang.sMaNV = tblNhanvien.sMaNV and tblKhachhang.sMaKH = tblDondathang.sMaKH " + " ";
                if (txtSoHD.Text != "")
                {
                    sql = sql + " and sSohoadon like '%" + txtSoHD.Text + "%'";
                }
                if (cbbNhanvien.Text != "")
                {
                    sql = sql + " and sTenNV like N'%" + cbbNhanvien.Text + "%'";
                }
                if (cbbKhachhang.Text != "")
                {
                    sql = sql + " and sTenKH like N'%" + cbbKhachhang.Text + "%'";
                }
                if (dtpNgaydathang.Text != "MM/dd/yyyy")
                {
                    sql = sql + " and dNgaydathang = '" + dtpNgaydathang.Value + "'";
                }
                if (dtpNgaygiaohang.Text != "MM/dd/yyyy")
                {
                    sql = sql + " and dNgaygiaohang = '" + dtpNgaygiaohang.Value + "'";
                }
                if (txtDiachigiao.Text != "")
                {
                    sql = sql + " and sDiachigiaohang like N'%" + txtDiachigiao.Text + "%'";
                }


                using (SqlCommand cmd = new SqlCommand(sql, cnn))
                {
                    cnn.Open();
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        dgrDondathang.DataSource = table;
                    }
                    cnn.Close();
                }
                btnTimkiem.Text = "Tìm kiếm";
                txtSoHD.ReadOnly = true;
                cbbKhachhang.Enabled = false;
                cbbNhanvien.Enabled = false;
                txtDiachigiao.ReadOnly = true;
                dtpNgaydathang.Enabled = false;
                dtpNgaygiaohang.Enabled = false;
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
            dtpNgaydathang.CustomFormat = "'Ngày: 'dd', Tháng: 'MM', Năm: 'yyyy";
            dtpNgaygiaohang.CustomFormat = "'Ngày: 'dd', Tháng: 'MM', Năm: 'yyyy";
            txtSoHD.ReadOnly = true;
            txtDiachigiao.ReadOnly = true;
            cbbKhachhang.Enabled = false;
            cbbNhanvien.Enabled = false;
            cbbmarem.Enabled = false;
            txtsoluong.ReadOnly = true;
            btnTimkiem.Enabled = true;
            txtdongia.ReadOnly = true;
            txtDiachigiao.Clear();
            dtpNgaydathang.Enabled = false;
            dtpNgaygiaohang.Enabled = false;
            txtsoluong.Text = "";
            txtdongia.Text = "";
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnthemlv.Visible = false;
            btninhoadon.Enabled = false;
            btnBoqua.Visible = false;
            hien();
        }

       

        private void btnthemlv_Click(object sender, EventArgs e)
        {
            if (checkmarem) {
                Boolean nhapmoi = true;
                foreach (DataRow row1 in Dscthd.Rows)
                {

                    if (cbbmarem.Text == row1["sMaloairem"].ToString())
                    {
                        if (txtdongia.Text == row1["fGiaban"].ToString())
                        {
                            row1["fSoluongmua"] = float.Parse(txtsoluong.Text) + float.Parse(row1["fSoluongmua"].ToString());
                            nhapmoi = false;
                            errorDondathang.SetError(txtdongia, "");
                        }
                        else
                        {
                            errorDondathang.SetError(txtdongia, "Sai đơn giá!");
                            nhapmoi = false;
                        }
                    }
                }
                if (nhapmoi)
                {
                    errorDondathang.SetError(txtdongia, "");
                    DataRow row = Dscthd.NewRow();
                    row["sMaloairem"] = cbbmarem.Text;
                    row["fGiaban"] = txtdongia.Text;
                    row["fSoluongmua"] = txtsoluong.Text;
                    Dscthd.Rows.Add(row);
                    dgvctdat.DataSource = Dscthd;
                }
                txtsoluong.Text = "";
                txtdongia.Text = "";
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
                    { checkmarem = true; errorDondathang.SetError(cbbmarem, ""); }
                    else checkmarem = false;
                }
                catch { checkmarem = false; }
                finally { cnn.Close(); }



            }
            if (!checkmarem)
            {
                errorDondathang.SetError(cbbmarem, "Không tồn tại!");
            }
        }

        private void dgvctdat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try {
                int i = e.RowIndex;
                cbbmarem.Text = dgvctdat.Rows[i].Cells[0].Value.ToString();
                txtdongia.Text = dgvctdat.Rows[i].Cells[2].Value.ToString();
                txtsoluong.Text = dgvctdat.Rows[i].Cells[1].Value.ToString();
                if (btnSua.Text == "Lưu")
                {
                    btnsuachitiet.Enabled = true;
                    btnxoachitiet.Enabled = true;
                    txtsoluong.ReadOnly = false;
                    txtdongia.ReadOnly = false;
                }
                
            }
            catch { }
        }

        private void btnsuachitiet_Click(object sender, EventArgs e)
        {
            using (SqlCommand cmd = new SqlCommand("sp_Suachitietdondathang",cnn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@sohd", txtSoHD.Text);
                cmd.Parameters.AddWithValue("@loairem", cbbmarem.Text);
                cmd.Parameters.AddWithValue("@soluong",float.Parse( txtsoluong.Text));
                cmd.Parameters.AddWithValue("@giaban", float.Parse(txtdongia.Text));
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
            if (dgvctdat.Rows.Count > 2) {
                DialogResult result = MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    using (SqlCommand cmd = new SqlCommand("sp_Xoachitietdondathang",cnn))
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
                            MessageBox.Show("Đã có lỗi xảy ra!");
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
            crpdondathang baocao = new crpdondathang();
            DataTable table = new DataTable();
            using (SqlCommand cmd = new SqlCommand("sp_Indondathang", cnn))
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

        private void dtpNgaydathang_Leave(object sender, EventArgs e)
        {
            dtpNgaydathang.Value = new DateTime(dtpNgaydathang.Value.Year, dtpNgaydathang.Value.Month, dtpNgaydathang.Value.Day,0,0,0);
        }

        private void dtpNgaygiaohang_Leave(object sender, EventArgs e)
        {
            dtpNgaygiaohang.Value = new DateTime(dtpNgaygiaohang.Value.Year, dtpNgaygiaohang.Value.Month, dtpNgaygiaohang.Value.Day, 0, 0, 0);
        }

        private void cbbNhanvien_Validating(object sender, CancelEventArgs e)
        {
            if (cbbNhanvien.Text == "")
                errorDondathang.SetError(cbbNhanvien, "Bạn cần nhập họ tên nhân viên");
            else
            {
                try
                {
                    int a = int.Parse(cbbNhanvien.Text);
                    errorDondathang.SetError(cbbNhanvien, "Sai kiểu dữ liệu");
                }
                catch
                {
                    errorDondathang.SetError(cbbNhanvien, "");
                }
            }
        }

        private void cbbKhachhang_Validating(object sender, CancelEventArgs e)
        {
            if (cbbKhachhang.Text == "")
                errorDondathang.SetError(cbbKhachhang, "Bạn cần nhập họ tên khách hàng");
            else
            {
                try
                {
                    int a = int.Parse(cbbKhachhang.Text);
                    errorDondathang.SetError(cbbKhachhang, "Sai kiểu dữ liệu");
                }
                catch
                {
                    errorDondathang.SetError(cbbKhachhang, "");
                }
            }
        }
        private void goHome(String username)
        {
            FormTrangChu form = new FormTrangChu(username);
            form.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            goHome(username);
        }
    }
}
