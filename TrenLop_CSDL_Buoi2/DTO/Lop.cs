using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrenLop_CSDL_Buoi2
{
    class Lop
    {
        private string IDLop,TenLop;
        public Lop()
        {

        }
        public Lop(string IDLop,string TenLop)
        {
            this.IDLop = IDLop;
            this.TenLop = TenLop;
        }
        public string IDLOP
        {
            get => this.IDLop;
            set => this.IDLop = value;
        }
        public string TENLOP
        {
            get => this.TenLop;
            set => this.TenLop = value;
        }
    }
}
