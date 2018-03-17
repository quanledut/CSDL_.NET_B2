using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrenLop_CSDL_Buoi2
{
    class DataHelpper
    {
        private string connection = @"Data Source=DESKTOP-THKH1SI\SQLSERVER;Initial Catalog=Bai1_NET;Integrated Security=True";
        public string Connection{
            get => connection;
            set => connection = value;
        }

        private SqlConnection cnn;
       // public string Connection { get => connection; set => connection = value; }
        SqlCommand cmd = new SqlCommand();

        public void DB_ExecuteNonQuery(SqlCommand query)
        {
            cmd = query;
            cmd.Connection = cnn;
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
        public DataTable DB_Select(string query)
        {
            SqlDataAdapter da = new SqlDataAdapter(query, connection);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0];
        }

        public DataHelpper()
        {
            cnn = new SqlConnection(connection);
           // cmd.Connection = cnn;
        }
    }
}
