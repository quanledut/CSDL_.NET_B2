using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrenLop_CSDL_Buoi2
{
    public partial class AddForm : Form
    {
        QLSV_BLL bll = new QLSV_BLL();
        public delegate SV getData();
        public getData get;
        public AddForm()
        {
            InitializeComponent();
            get = new getData(get_data);
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
        public SV get_data()
        {
            DateTime d;
            d = datetime_birtday.Value;
            string date = String.Format("{0:yyyy-MM-d}", d);
            string MSSV = txt_MSSV.Text;
            string name = txt_name.Text;
            string address = txt_address.Text;
            string phone = txt_phone.Text;
            string email = txt_email.Text;
            float dht = float.Parse(txt_dht.Text);
            int drl = int.Parse(txt_drl.Text);
            bool gender;
            if (rb_male.Checked) gender = true;
            else gender = false;

            // idlop replace by tenlop
            string idlop = cb_lop.SelectedItem.ToString();
            SV mySV = new SV(MSSV, name, date, gender, address, phone, email, dht, drl, idlop);
            return mySV;
        }
    }
}
