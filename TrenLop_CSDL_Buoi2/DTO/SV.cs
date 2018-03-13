using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrenLop_CSDL_Buoi2
{
    
    class SV
    {
        public string MSSV { get; set; }
        public string NameSV { get; set; }
        public string Address { get; set; }
        public string Birthday { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string IDLop { get; set; }

        //private DateTime Birthday;
        public float DHT { get; set; }
        public int DRL { get; set; }
        public bool Gender { get; set; }
        public SV()
        {

        }
        public SV(string MSSV, string NameSV, string BirthDay,bool Gender, string Address, string Mobile, string Email, float DHT,int DRL, string IDLop)
        {
            this.MSSV = MSSV;
            this.NameSV = NameSV;
            this.Birthday = Birthday;
            this.Gender = Gender;
            this.Address = Address;
            this.Mobile = Mobile;
            this.Email = Email;
            this.DHT = DHT;
            this.DRL = DRL;
            this.IDLop = IDLop;
        }
        public string show()
        {
            return string.Join(" ", this.MSSV, this.NameSV, this.Address, this.Mobile);
        }
    }
}
