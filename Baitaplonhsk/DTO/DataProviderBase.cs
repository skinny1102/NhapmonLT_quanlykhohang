namespace Baitaplonhsk.DTO
{
    internal class DataProviderBase
    {
        public DataTable ExecuteQuery(String query)
        {
            SqlConnection con = new SqlConnection(connectionStr);
            con.Open();
            con.Close();
        }
    }
}