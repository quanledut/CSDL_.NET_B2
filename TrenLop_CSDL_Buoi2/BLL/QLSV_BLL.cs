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
        List<SV> myList;
        QLSV_DAL dal = new QLSV_DAL();
        public List<SV> showDB()
        {
            if(myList!=null) myList.Clear();
            myList = dal.getList();
            return myList;
        }
      
        public void Add(SV mySV)
        {
            string MSSV = mySV.mssv;
            string NameSV = mySV.namesv;
            string BirthDay = mySV.birthday;
            bool Gender = mySV.gender;
            string Address = mySV.address;
            string Mobile = mySV.mobile;
            string Email = mySV.email;
            float DHT = mySV.dht;
            int DRL = mySV.drl;
            string IDLop = mySV.idlop;
            dal.Add( MSSV,  NameSV,  BirthDay,  Gender,  Address,  Mobile,  Email,  DHT,  DRL, IDLop);
        }
        public string get_IDLop(string Lop)
        {
            return dal.get_IDLop(Lop);
        }
        public SV get_SV_by_MSSV(string mssv)
        {
            return dal.getSV(dal.select_SV(mssv));
        }
        public void deleteByMSSV(string mssv)
        {
            dal.delete(mssv);
        }
        
    }
}
