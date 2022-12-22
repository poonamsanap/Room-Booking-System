using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Room_Booking_System
{
    public partial class AdminData : Form
    {
        public AdminData()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Aboutus a= new Aboutus();
            a.Show();
            this.Hide();
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
           rooms1 f=new rooms1();
            f.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(addnew.Text=="USER")
            {
                Addcustomer r= new Addcustomer(); 
                r.Show();
                this.Hide();
            }

            if(addnew.Text=="ROOM")
            {
                Addroom a=new Addroom();
                a.Show();
                this.Hide();
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(reports.Text== "CUSTOMER REPORT")
            {
                  CustomerReport r= new CustomerReport();
                   r.Show();
                this.Hide();
            }
            if(reports.Text == "ROOM REPORT")
                {
                 RoomReports r=new RoomReports();
                r.Show();
                this.Hide();

            }
            if(reports.Text == "BOOKING REPORT")
               { 
                BookingReport r=new BookingReport();
                r.Show();
                this.Hide();

            }
            if (reports.Text == "TRANSACTION REPORT")
            {
               TransactionReports r = new TransactionReports();
                r.Show();
                this.Hide();

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ForgotPassword forgotPassword = new ForgotPassword();
            forgotPassword.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            UserLogin userLogin = new UserLogin();
            userLogin.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Close();
        }
    }
}
