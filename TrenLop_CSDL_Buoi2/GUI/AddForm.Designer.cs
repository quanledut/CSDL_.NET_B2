﻿namespace TrenLop_CSDL_Buoi2
{
    partial class AddForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.submit_Btn = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.cb_lop = new System.Windows.Forms.ComboBox();
            this.datetime_birtday = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rb_male = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.rb_female = new System.Windows.Forms.RadioButton();
            this.txt_drl = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_dht = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_MSSV = new System.Windows.Forms.TextBox();
            this.cancle_Btn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cancle_Btn);
            this.groupBox1.Controls.Add(this.submit_Btn);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.cb_lop);
            this.groupBox1.Controls.Add(this.datetime_birtday);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txt_drl);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_email);
            this.groupBox1.Controls.Add(this.txt_phone);
            this.groupBox1.Controls.Add(this.txt_address);
            this.groupBox1.Controls.Add(this.txt_name);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txt_dht);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_MSSV);
            this.groupBox1.Location = new System.Drawing.Point(46, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(663, 264);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // submit_Btn
            // 
            this.submit_Btn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.submit_Btn.Location = new System.Drawing.Point(357, 221);
            this.submit_Btn.Name = "submit_Btn";
            this.submit_Btn.Size = new System.Drawing.Size(125, 23);
            this.submit_Btn.TabIndex = 39;
            this.submit_Btn.Text = "Submit";
            this.submit_Btn.UseVisualStyleBackColor = true;
            this.submit_Btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(337, 178);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 13);
            this.label10.TabIndex = 38;
            this.label10.Text = "Lop";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // cb_lop
            // 
            this.cb_lop.FormattingEnabled = true;
            this.cb_lop.Items.AddRange(new object[] {
            "14T",
            "15T"});
            this.cb_lop.Location = new System.Drawing.Point(379, 174);
            this.cb_lop.Name = "cb_lop";
            this.cb_lop.Size = new System.Drawing.Size(173, 21);
            this.cb_lop.TabIndex = 37;
            // 
            // datetime_birtday
            // 
            this.datetime_birtday.Location = new System.Drawing.Point(69, 95);
            this.datetime_birtday.Name = "datetime_birtday";
            this.datetime_birtday.Size = new System.Drawing.Size(257, 20);
            this.datetime_birtday.TabIndex = 26;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rb_male);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.rb_female);
            this.groupBox2.Location = new System.Drawing.Point(336, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(255, 100);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // rb_male
            // 
            this.rb_male.AutoSize = true;
            this.rb_male.Location = new System.Drawing.Point(43, 49);
            this.rb_male.Name = "rb_male";
            this.rb_male.Size = new System.Drawing.Size(47, 17);
            this.rb_male.TabIndex = 18;
            this.rb_male.TabStop = true;
            this.rb_male.Text = "male";
            this.rb_male.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(-48, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Gender";
            // 
            // rb_female
            // 
            this.rb_female.AutoSize = true;
            this.rb_female.Location = new System.Drawing.Point(43, 72);
            this.rb_female.Name = "rb_female";
            this.rb_female.Size = new System.Drawing.Size(56, 17);
            this.rb_female.TabIndex = 19;
            this.rb_female.TabStop = true;
            this.rb_female.Text = "female";
            this.rb_female.UseVisualStyleBackColor = true;
            // 
            // txt_drl
            // 
            this.txt_drl.Location = new System.Drawing.Point(379, 149);
            this.txt_drl.Name = "txt_drl";
            this.txt_drl.Size = new System.Drawing.Size(173, 20);
            this.txt_drl.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(333, 152);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "DRL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(333, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "DHT";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(67, 175);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(260, 20);
            this.txt_email.TabIndex = 17;
            // 
            // txt_phone
            // 
            this.txt_phone.Location = new System.Drawing.Point(66, 149);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(260, 20);
            this.txt_phone.TabIndex = 16;
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(67, 123);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(260, 20);
            this.txt_address.TabIndex = 15;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(67, 73);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(260, 20);
            this.txt_name.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 76);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "Họ và tên";
            // 
            // txt_dht
            // 
            this.txt_dht.Location = new System.Drawing.Point(379, 123);
            this.txt_dht.Name = "txt_dht";
            this.txt_dht.Size = new System.Drawing.Size(173, 20);
            this.txt_dht.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Điện thoại";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Địa chỉ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ngày sinh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "MSSV";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thong tin Sinh vien";
            // 
            // txt_MSSV
            // 
            this.txt_MSSV.Location = new System.Drawing.Point(66, 47);
            this.txt_MSSV.Name = "txt_MSSV";
            this.txt_MSSV.Size = new System.Drawing.Size(260, 20);
            this.txt_MSSV.TabIndex = 0;
            // 
            // cancle_Btn
            // 
            this.cancle_Btn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancle_Btn.Location = new System.Drawing.Point(179, 221);
            this.cancle_Btn.Name = "cancle_Btn";
            this.cancle_Btn.Size = new System.Drawing.Size(125, 23);
            this.cancle_Btn.TabIndex = 40;
            this.cancle_Btn.Text = "Cancle";
            this.cancle_Btn.UseVisualStyleBackColor = true;
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 366);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddForm";
            this.Text = "AddForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker datetime_birtday;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rb_male;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton rb_female;
        private System.Windows.Forms.TextBox txt_drl;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_dht;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_MSSV;
        private System.Windows.Forms.ComboBox cb_lop;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button submit_Btn;
        private System.Windows.Forms.Button cancle_Btn;
    }
}