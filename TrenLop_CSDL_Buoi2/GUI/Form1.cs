using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

/*namespace TrenLop_CSDL_Buoi2
{
    public partial class Form1 : Form
    {
        private DataHelpper dhp;

        public Form1()
        {
            dhp = new DataHelpper();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bt_show_Click(object sender, EventArgs e)
        {            
              this.Show_DB();                        
        }
        private void Show_DB()
        {
            string connection = @"Data Source=DESKTOP-THKH1SI\SQLSERVER;Initial Catalog=Bai1_NET;Integrated Security=True";
            string query = "SELECT SV.MSSV,NameSV,BirthDay,Gender,Address,Mobile,Email,DHT,DRL,SV.IDLop,TenLop FROM SV inner join Lop ON SV.IDLop=Lop.IDLop";
            SqlDataAdapter da = new SqlDataAdapter(query, connection);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgv.DataSource = ds.Tables[0];
        }
        private void Show_DB()
        {
            string query = "SELECT SV.MSSV,NameSV,BirthDay,Gender,Address,Mobile,Email,DHT,DRL,SV.IDLop,TenLop FROM SV inner join Lop ON SV.IDLop=Lop.IDLop";
            dgv.DataSource = dhp.DB_Select(query);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
         {
             string sortBy = comboBox1.SelectedItem.ToString();
             string connection = @"Data Source=DESKTOP-THKH1SI\SQLSERVER;Initial Catalog=Bai1_NET;Integrated Security=True";
             SqlConnection cnn = new SqlConnection(connection);
             cnn.Open();

             SqlCommand cmd = new SqlCommand();
             cmd.Connection = cnn;
             cmd.CommandText = "SELECT MSSV,NameSV,BirthDay,Gender,Address,Mobile,Email,DHT,DRL,SV.IDLop,TenLop FROM SV,Lop WHERE SV.IDLop=Lop.IDLop,SV.IDLop = @lop";
             cmd.Parameters.Add("@lop", SqlDbType.NVarChar);
             cmd.Parameters["@lop"].Value = sortBy;
             //cmd.ExecuteQuery();
             SqlDataReader r = cmd.ExecuteReader();
             cnn.Close();
            // Show_DB();
         }
        {
            string sortBy = comboBox1.SelectedItem.ToString();
            string connection = @"Data Source=DESKTOP-THKH1SI\SQLSERVER;Initial Catalog=Bai1_NET;Integrated Security=True";
            string query = "SELECT MSSV,NameSV,BirthDay,Gender,Address,Mobile,Email,DHT,DRL,SV.IDLop,TenLop FROM SV,Lop WHERE SV.IDLop=Lop.IDLop and Lop.TenLop = '"+sortBy+"'";
            //MessageBox.Show(query);
            SqlDataAdapter da = new SqlDataAdapter(query, connection);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgv.DataSource = ds.Tables[0];
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            DateTime d;
            d = datetime_birtday.Value;
            string date = String.Format("{0:yyyy-MM-d}", d);
            string MSSV = txt_MSSV.Text;
            string name = txt_name.Text;
            string address = txt_address.Text;
            string phone = txt_phone.Text;
            string email = txt_email.Text;
            double dht = double.Parse(txt_dht.Text);
            int drl = int.Parse(txt_drl.Text);
            string gender;
            if (rb_male.Checked) gender = "True";
            else gender = "False";
            string lop = txt_lop.Text;
            string connection = @"Data Source=DESKTOP-THKH1SI\SQLSERVER;Initial Catalog=Bai1_NET;Integrated Security=True";
            SqlConnection cnn = new SqlConnection(connection);
            //string query = "insert into Sinhvien values ('102151456','Tran Van D','1995-03-04','False','Da Nang','01685987848','bff@fb.com',8.7,79,'14T3')";
            //string query = "insert into Sinhvien values('" + MSSV + "','" + name + "','" + date + "','" + gender + "','" + address + "','" + phone + "','" + email + "'," + dht + "," + drl +",'"+lop+"')";
            // SqlCommand cmd = new SqlCommand(query, cnn);
            cnn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandText = "INSERT INTO Sinhvien VALUES(@mssv,@name,@birthday,@gender,@address,@phone,@email,@dht,@drl,@lop)";
            cmd.Parameters.Add("@mssv", SqlDbType.NVarChar);
            cmd.Parameters.Add("@name", SqlDbType.NVarChar);
            cmd.Parameters.Add("@birthday", SqlDbType.NVarChar);
            cmd.Parameters.Add("@gender", SqlDbType.Bit);
            cmd.Parameters.Add("@address", SqlDbType.NVarChar);
            cmd.Parameters.Add("@phone", SqlDbType.NVarChar);
            cmd.Parameters.Add("@email", SqlDbType.NVarChar);
            cmd.Parameters.Add("@dht", SqlDbType.Float);
            cmd.Parameters.Add("@drl", SqlDbType.Int);
            cmd.Parameters.Add("@lop", SqlDbType.NVarChar);

            cmd.Parameters["@mssv"].Value = MSSV;
            cmd.Parameters["@name"].Value = name;
            cmd.Parameters["@birthday"].Value = date;
            cmd.Parameters["@gender"].Value = gender;
            cmd.Parameters["@address"].Value = address;
            cmd.Parameters["@phone"].Value = phone;
            cmd.Parameters["@email"].Value = email;
            cmd.Parameters["@dht"].Value = dht;
            cmd.Parameters["@drl"].Value = drl;
            cmd.Parameters["@lop"].Value = lop;

            cmd.ExecuteNonQuery();
            cnn.Close();
            Show_DB();
        }
    }
}*/

namespace TrenLop_CSDL_Buoi2
{
    public partial class Form1 : Form
    {
       
        List<SV> myList;
        private QLSV_BLL bll = new QLSV_BLL();
        private DataHelpper dhp = new DataHelpper();
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public Form1()
        {
            dhp = new DataHelpper();
            InitializeComponent();
        }
        public void bt_show_Click(object sender, EventArgs e)
        {
            this.show();
        }

        public void show()
        {
            dgv.DataSource = null;
            dgv.DataSource = bll.showDB();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /*private void bt_add_Click(object sender, EventArgs e)
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
            string gender;
            if (rb_male.Checked) gender = "True";
            else gender = "False";
            string idlop = bll.get_IDLop(cb_lop.SelectedItem.ToString());

            bll.Add(MSSV, name, date, gender, address, phone, email, dht, drl, idlop);
        }*/
        private void bt_add_Click(object sender, EventArgs e)
        {
            SV mySV = new SV();
            AddForm addform = new AddForm();
            if(addform.ShowDialog() == DialogResult.OK)
            {
                mySV = addform.get();
                mySV.idlop = bll.get_IDLop(mySV.idlop);
                bll.Add(mySV);
            }
            this.show();
           
        }
        private void dgv_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            string mssv = dgv.SelectedRows[0].Cells["mssv"].Value.ToString();
            SV sv = new SV();
            sv = bll.get_SV_by_MSSV(mssv);
            txt_address.Text = sv.address;
            txt_name.Text = sv.namesv;
            txt_MSSV.Text = sv.mssv;
            txt_dht.Text = sv.dht.ToString();
            txt_drl.Text = sv.drl.ToString();
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            string mssv = dgv.SelectedRows[0].Cells["mssv"].Value.ToString();
            mssv = mssv.Trim();
            bll.deleteByMSSV(mssv);
            this.show();
        }

        private void bt_update_Click(object sender, EventArgs e)
        {
            string mssv = 
        }
    }
    
}