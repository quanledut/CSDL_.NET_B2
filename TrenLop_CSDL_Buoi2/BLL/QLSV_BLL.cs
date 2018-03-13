using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrenLop_CSDL_Buoi2
{
    class QLSV_BLL
    {
        
        QLSV_DAL dal = new QLSV_DAL();
        public List<SV> showDB()
        {
            return dal.getList();
        }
        public void Add(string MSSV, string NameSV, string BirthDay, string Gender, string Address, string Mobile, string Email, float DHT, int DRL, string IDLop)
        {
             dal.Add( MSSV,  NameSV,  BirthDay,  Gender,  Address,  Mobile,  Email,  DHT,  DRL,  IDLop);
        }
        
    }
}
