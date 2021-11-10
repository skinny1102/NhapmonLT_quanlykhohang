using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baitaplonhsk
{
    public partial class FormTrangChu : Form
    {
        public String username;
        public FormTrangChu()
        {
            InitializeComponent();
        }
        public FormTrangChu(String user)
        {
            InitializeComponent();
            this.username = user;
        }

        private void addUser_Click(object sender, EventArgs e)
        {
            if (username != "admin")
            {
                const string message = "Bạn phải đăng nhập bằng quyền admin";
                const string caption = "Chưa đủ quyền";
                MessageBox.Show(message, caption, MessageBoxButtons.OK);
            }
            else
            {
                FormCapTaiKhoan form = new FormCapTaiKhoan(username);
                form.Show();
                this.Hide();
            }
            
        }

        private void blockUser_Click(object sender, EventArgs e)
        {
            if (username != "admin")
            {
                const string message = "Bạn phải đăng nhập bằng quyền admin";
                const string caption = "Chưa đủ quyền";
                MessageBox.Show(message, caption, MessageBoxButtons.OK);
            }
            else
            {
                FormKhoaTaiKhoan formKhoaTaiKhoan = new FormKhoaTaiKhoan(username);
                formKhoaTaiKhoan.Show();
                this.Hide();
            }
          
        }

        private void changePassword_Click(object sender, EventArgs e)
        {
            FormDoiMatKhau formDoimatkhau = new FormDoiMatKhau(username);
            formDoimatkhau.Show();
            this.Hide();
        }

        private void qlNcc_Click(object sender, EventArgs e)
        {
            frmNhacungcap f = new frmNhacungcap(username);
            f.Show();
            this.Hide();
        }

        private void quảnLýĐơnĐặtHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void donnhaphang_Click(object sender, EventArgs e)
        {
            frmDonnhaphang f = new frmDonnhaphang(username);
            f.Show();
            this.Hide();
        }

        private void loạiSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLoairem f = new frmLoairem();
            f.Show();
            this.Hide();
        }

        private void đơnĐặtHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
             frmDondathang f = new frmDondathang(username);
            f.Show();
            this.Hide();
        }

        private void logOut_Click(object sender, EventArgs e)
        {
            frmNhanvien f = new frmNhanvien(username);
            f.Show();
            this.Hide();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDangNhap f = new FormDangNhap();
            f.Show();
            this.Close();
        }
    }
}
