using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baitaplonhsk
{
    public partial class FormDoiMatKhau : Form
    {
        String username;
        public FormDoiMatKhau()
        {
            InitializeComponent();
        }
        public FormDoiMatKhau(String user)
        {
            InitializeComponent();
            this.username = user;
        }
        public SqlConnection openSQL()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["quanlyxuatnhapkho2"].ConnectionString;
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            return con;
        }
        public int check()
        {

            if (string.IsNullOrEmpty(oldPassword.Text))
            {
                return 1;
            }
            if (string.IsNullOrEmpty(newPassword.Text))
            {
                return 2;
            }
            if (string.IsNullOrEmpty(confirmPassword.Text))
            {
                return 3;
            }
            if (newPassword.Text.Trim() != confirmPassword.Text.Trim())
            {
                return 4;
            }
            return 0;
        }
        private void goHome()
        {
            FormTrangChu form = new FormTrangChu(username);
            form.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            switch (check())
            {
                case 0:
                    domakhau();
                    break;
                case 1:
                    const string message = "Mật khẩu trông";
                    const string caption = "";
                    MessageBox.Show(message, caption, MessageBoxButtons.OK);
                    break;
                case 2:

                    MessageBox.Show("Hãy nhập mật khẩu mới", "Thông báo", MessageBoxButtons.OK);
                    break;
                case 3:

                    MessageBox.Show("Hãy Nhập mật khẩu cũ ", "Thông báo", MessageBoxButtons.OK);
                    break;
                case 4:

                    MessageBox.Show("Cofirm Password không chính xác", "Thông báo", MessageBoxButtons.OK);
                    break;

            }

        }
        private void domakhau()
        {
            SqlConnection connect = openSQL();
            using (SqlCommand command = connect.CreateCommand())
            {
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "[dbo].[SP_CapNhatMK]";
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", oldPassword.Text.Trim());
                command.Parameters.AddWithValue("@newPass", newPassword.Text.Trim());
                command.ExecuteNonQuery();
                connect.Close();
                const string message = "Đổi mật khẩu thành công";
                const string caption = "Đổi mật khẩu";
                MessageBox.Show(message, caption, MessageBoxButtons.OK);
            }
            goHome();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            goHome();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            goHome();
        }
    }
}
