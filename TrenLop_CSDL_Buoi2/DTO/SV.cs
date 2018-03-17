using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrenLop_CSDL_Buoi2
{
    
    public class SV
    {
        private string MSSV;
        private string NameSV;
        private string Address;
        private string Birthday;
        private string Mobile;
        private string Email;
        private string IDLop;

        //private DateTime Birthday;
        private float DHT;
        private int DRL;
        private bool Gender;
        public SV()
        {

        }
        public string mssv
        {
            get => MSSV;
            set => MSSV = value;
        }
        public string namesv
        {
            get => NameSV;
            set => NameSV = value;
        }
        public string birthday
        {
            get => Birthday;
            set => Birthday = value;
        }
        public bool gender
        {
            get => Gender;
            set => Gender = value;
        }
        public string address
        {
            get => Address;
            set => Address = value;
        }
        public string mobile
        {
            get => Mobile;
            set => Mobile = value;
        }
        public string email
        {
            get => Email;
            set => Email = value;
        }
        public float dht
        {
            get => DHT;
            set => DHT = value;
        }
        public int drl
        {
            get => DRL;
            set => DRL = value;
        }
        public string idlop
        {
            get => IDLop;
            set => IDLop = value;
        }
        
        public SV(string MSSV, string NameSV, string BirthDay,bool Gender, string Address, string Mobile, string Email, float DHT,int DRL, string IDLop)
        {
            this.MSSV = MSSV;
            this.NameSV = NameSV;
            this.Birthday = BirthDay;
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
