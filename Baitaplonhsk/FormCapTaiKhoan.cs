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
    public partial class FormCapTaiKhoan : Form
    {
        public String username;
        public FormCapTaiKhoan()
        {
            InitializeComponent();
        }
        public FormCapTaiKhoan(String user)
        {

            InitializeComponent();
            this.username = user;
        }
        public int check()
        {
            if (string.IsNullOrEmpty(txtMaNV.Text) || string.IsNullOrEmpty(txtTenNV.Text) || string.IsNullOrEmpty(txtSdt.Text)
                || string.IsNullOrEmpty(txtCMND.Text) || string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text)
                )
            {
                return 1;
            }

            return 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String strMaNv = txtMaNV.Text;
            String strNameNv = txtTenNV.Text;
            string Ngaysinh = dateTimePicker1.Value.ToString("MM/dd/yyyy");
            int gioitinh;
            bool isChecked = radioButtonNam.Checked;
            if (isChecked)
                gioitinh = 1;
            else
                gioitinh = 0;
            String Sdt = txtSdt.Text;
            string Ngayvaolam = dateTimePicker2.Value.ToString("MM/dd/yyyy");
            String Cmnd = txtCMND.Text;
            String username = txtUsername.Text;
            String password = txtPassword.Text;
            switch (check())
            {
                case 1:
                    MessageBox.Show("Hãy nhập đầu đủ giá trị", "Thông báo", MessageBoxButtons.OK);
                    break;
                case 0:
                    SqlConnection connect = openSQL();
                    using (SqlCommand command = connect.CreateCommand())
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.CommandText = "addUser";
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@password", password);
                        command.Parameters.AddWithValue("@code", strMaNv);
                        command.Parameters.AddWithValue("@name", strNameNv);
                        command.Parameters.AddWithValue("@dob", Ngaysinh);
                        command.Parameters.AddWithValue("@gender", gioitinh);
                        command.Parameters.AddWithValue("@phoneNumber", Sdt);
                        command.Parameters.AddWithValue("@dayOne", Ngayvaolam);
                        command.Parameters.AddWithValue("@identify", Cmnd);
                        command.Parameters.AddWithValue("@flag", true);
                        command.ExecuteNonQuery();
                        connect.Close();
                        const string message = "Thêm thành công";
                        const string caption = "Thêm ";
                        MessageBox.Show(message, caption, MessageBoxButtons.OK);
                    }
                    break;

            }
        }
        public SqlConnection openSQL()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            return con;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            goHome(username);
        }
        private void goHome(String username)
        {
            FormTrangChu form = new FormTrangChu(username);
            form.Show();
            this.Hide();
        }
    }
}