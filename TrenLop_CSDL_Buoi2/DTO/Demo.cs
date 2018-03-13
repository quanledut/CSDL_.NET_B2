using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrenLop_CSDL_Buoi2
{
    class Demo
    {
        private string Name { get; set; }
        private string Address{get;set;}
        public Demo(string Name, string Address)
        {
            this.Name = Name;
            this.Address = Address;
        }
       /*public string name {
            get => this.Name;
            set => this.Name = value;
        }
        public string address
        {
            get => this.Address;
            set => this.Address = value;
        }*/
    }
}