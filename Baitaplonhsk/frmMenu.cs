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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhanvien frm = new frmNhanvien();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mặtHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLoairem f1 = new frmLoairem();
            f1.MdiParent = this;
            f1.Show();
        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhacungcap f1 = new frmNhacungcap();
            f1.MdiParent = this;
            f1.Show();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKhachhang f1 = new frmKhachhang();
            f1.MdiParent = this;
            f1.Show();
        }

        private void đơnĐặtHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDondathang f1 = new frmDondathang();
            f1.MdiParent = this;
            f1.Show();
        }

        private void đơnNhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDonnhaphang f1 = new frmDonnhaphang();
            f1.MdiParent = this;
            f1.Show();
        }
    }
}
