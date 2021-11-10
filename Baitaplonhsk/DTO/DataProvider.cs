using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitaplonhsk.DTO
{
    class DataProvider
    {
        public string connectionStr = "Data Source=DESKTOP-TLD7PI9\\SQLEXPRESS;Initial Catalog=quanlyxuatnhapkho;Integrated Security=True";
        public DataTable ExecuteQuery(string query)
        {
            DataTable data = new DataTable();
            using ( SqlConnection con = new SqlConnection(connectionStr))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                con.Close();
            }    
            return data;
        }
    }
}
