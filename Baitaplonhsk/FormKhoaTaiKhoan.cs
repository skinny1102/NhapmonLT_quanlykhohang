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
    public partial class FormKhoaTaiKhoan : Form
    {
        public String username;
        public FormKhoaTaiKhoan()
        {
            
            InitializeComponent();
          

        }
        public FormKhoaTaiKhoan(String user)
        {

            InitializeComponent();
            this.username = user;
        }
        public void comboxTaiKhoan()
        {

            SqlConnection connection = openSQL();
            using (SqlCommand command = connection.CreateCommand())
            {
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "[dbo].[selectUserNotFlag]";
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                    while (reader.Read())
                        cbbuser.Items.Add(reader[0].ToString());
            }
            connection.Close();
        }
        public SqlConnection openSQL()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["quanlyxuatnhapkho2"].ConnectionString;
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            return con;
        }

        public Boolean check()
        {

            if (string.IsNullOrEmpty(cbbuser.Text))
            {
                return false;
            }
            return true;
        }
        private void goHome(String username)
        {
            FormTrangChu form = new FormTrangChu(username);
            form.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = openSQL();
            if (!check())
            {
                const string message = "Vui lòng chọn tài khoản";
                const string caption = "Khóa tài khoản";
                MessageBox.Show(message, caption, MessageBoxButtons.OK);
                cbbuser.Focus();
                con.Close();
            }
            else
            {
                using (SqlCommand command = con.CreateCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "[dbo].[flagging]";
                    command.Parameters.AddWithValue("@username", cbbuser.Text);
                    command.ExecuteNonQuery();
                    con.Close();
                    const string message = "Khóa tài khoản thành công!";
                    const string caption = "Khóa tài khoản";
                    MessageBox.Show(message, caption, MessageBoxButtons.OK);
                }
                goHome(username);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            goHome(username);
        }

        private void FormKhoaTaiKhoan_Load(object sender, EventArgs e)
        {
            comboxTaiKhoan();
        }
    }
}
