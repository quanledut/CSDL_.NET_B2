using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrenLop_CSDL_Buoi2
{
    class QLSV_DAL
    {
        private DataHelpper dh = new DataHelpper();
        private List<SV> ListSV = new List<SV>();
        private SV mySV;
        private string query;


        //  private DataTable dtb;
        public List<SV> getList()
        {
            
            DataTable dt = new DataTable();
            query = "SELECT * FROM SV";
            dt = dh.DB_Select(query);
           foreach(DataRow i in dt.Rows)
            {
                ListSV.Add(getSV(i));
            }
            return ListSV;
        }
        public SV getSV(DataRow dt)
        {
            return new SV(dt["MSSV"].ToString(), dt["NameSV"].ToString(), dt["BirthDay"].ToString(), (bool)dt["Gender"], dt["Address"].ToString(), dt["Mobile"].ToString(), dt["Email"].ToString(), float.Parse(dt["DHT"].ToString()),Convert.ToInt32(dt["DRL"]),dt["IDLop"].ToString());
        }
        public void Add(string MSSV, string NameSV, string BirthDay, string Gender, string Address, string Mobile, string Email, float DHT, int DRL, string IDLop)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO SV VALUES (@mssv,@nameSV,@birthday,@gender,@address,@mobile,@email,@dht,@drl,@idlop)";
            cmd.Parameters.Add("@mssv", SqlDbType.NVarChar);
            cmd.Parameters.Add("@nameSV", SqlDbType.NVarChar);
            cmd.Parameters.Add("@birthday", SqlDbType.NVarChar);
            cmd.Parameters.Add("@gender", SqlDbType.NVarChar);
            cmd.Parameters.Add("@address", SqlDbType.NVarChar);
            cmd.Parameters.Add("@mobile", SqlDbType.NVarChar);
            cmd.Parameters.Add("@email", SqlDbType.NVarChar);
            cmd.Parameters.Add("@dht", SqlDbType.Float);
            cmd.Parameters.Add("@drl", SqlDbType.Int);
            cmd.Parameters.Add("@idlop", SqlDbType.NVarChar);

            cmd.Parameters["@mssv"].Value = MSSV;
            cmd.Parameters["@nameSV"].Value = NameSV;
            cmd.Parameters["@birthday"].Value = BirthDay;
            cmd.Parameters["@gender"].Value = Gender;
            cmd.Parameters["@address"].Value = Address;
            cmd.Parameters["@mobile"].Value = Mobile;
            cmd.Parameters["@email"].Value = Email;
            cmd.Parameters["@dht"].Value = DHT;
            cmd.Parameters["@drl"].Value = DRL;
            cmd.Parameters["@idlop"].Value = IDLop;

            
            dh.DB_ExecuteNonQuery(cmd);
        }
    }
}
