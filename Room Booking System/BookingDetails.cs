using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Room_Booking_System
{
    public partial class BookingDetails : Form
    {
        public string roomno { get; set; }
        public string roomtype { get; set; }
        public string amount { get; set; }  
        public BookingDetails()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
        public bool isEmpty()
        {
            if (txtroomno.Text == "" || dateTimePicker2.Text == "" || dateTimePicker1.Text == "" || txtroomtype.Text == ""
                     || txtamount.Text == "" || txtid.Text == "" || txtpersons.Text == "" )
                return true;
            else
                return false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\poona\OneDrive\Documents\RoomBookingSystemDatabase.mdf;Integrated Security=True;Connect Timeout=30 ";
           

               
                if (isEmpty())
                {
                    MessageBox.Show("please fill all the details");
                }

            if (!isEmpty()) 
                {
                Transaction b = new Transaction();
                b.roomno = txtroomno.Text;

                b.amount = txtamount.Text;


                b.Show();
                this.Hide();

                //using (SqlConnection con = new SqlConnection(connection))
                //{

                //    con.Open();
                //    SqlCommand cmd = new SqlCommand();
                //    cmd.Connection = con;
                //    cmd.Parameters.AddWithValue("@roomno", txtroomno.Text);
                //    cmd.Parameters.AddWithValue("@fromdate", dateTimePicker2.Text);
                //    cmd.Parameters.AddWithValue("@todate", dateTimePicker1.Text);
                //    cmd.Parameters.AddWithValue("@persons", txtpersons.Text);
                //    cmd.Parameters.AddWithValue("@amount", txtamount.Text);
                //    cmd.Parameters.AddWithValue("@personid", txtid.Text);

                //    cmd.CommandText = "insert into Bookings(Room_no,From_date,To_date,Total_adults,Amount,PersonId)values(@roomno,@fromdate,@todate,@persons,@amount,@personid)";
                //    cmd.ExecuteNonQuery();

                //    Transaction b = new Transaction();
                //    b.roomno = txtroomno.Text;

                //    b.amount = txtamount.Text;


                //    b.Show();
                //    this.Hide();
                //}

                Class2.roomno=txtroomno.Text ;
                Class2.roomtype=txtroomtype.Text ;
                Class2.totalamount= txtamount.Text ;
                Class2.fromdate=dateTimePicker2.Text;
                Class2.todate=dateTimePicker1.Text;
                Class2.persons=txtpersons.Text  ;
                Class2.userid=txtid.Text  ;
                
            }
             
    }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BookingDetails_Load(object sender, EventArgs e)
        {
            txtroomno.Text = roomno;
            txtroomtype.Text = roomtype;
            txtamount.Text = amount;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtpersons_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            newRoomdetails f = new newRoomdetails();
            f.Show();
            this.Hide();
        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
          

        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {

           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Class2.username == "poonam" && Class2.password == "poonam")
            {
                AdminData a = new AdminData();
                a.Show();
                this.Hide();
            }

            else
            {
                Home h = new Home();
                h.Show();
                this.Hide();

            }
        }

        private void linkLabel1_LinkClicked_2(object sender, LinkLabelLinkClickedEventArgs e)
        {
            newRoomdetails n=new newRoomdetails();
            n.Show();
            this.Hide();
        }
    }
}