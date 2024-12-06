using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    class DBConnection
    {
        public SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-SHU8E1BC\DBS_SAMEER;Initial Catalog=Prisoners_DATA;Integrated Security=SSPI;User ID=sa;Password= ");
        public SqlCommand cmd = new SqlCommand();

        public DBConnection()
        { }
        public void Inserts(string query) // insert / update / delete
        {
            conn.Open();
            cmd.CommandText = query;
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public DataTable Select(string query) // select query
        {
            conn.Open();
            cmd.CommandText = query;
            cmd.Connection = conn;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
    }
}
