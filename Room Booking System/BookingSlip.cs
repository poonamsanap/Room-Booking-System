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
    public partial class BookingSlip : Form
    {
        public string roomno { get; set;}
     
        public string amount { get; set; }
       
        public BookingSlip()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
             txtroomname.Text = roomno;
           // txtroomtype.Text = roomtype;  
         
         
            txtamount.Text = amount;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Downloaded");
           

        }

        private void txtroomname_TextChanged(object sender, EventArgs e)
        {
            string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\poona\OneDrive\Documents\RoomBookingSystemDatabase.mdf;Integrated Security=True;Connect Timeout=30 ";
            using (SqlConnection con = new SqlConnection(connection))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.Parameters.AddWithValue("@roomno", int.Parse(txtroomname.Text));
                cmd.Parameters.AddWithValue("@amount", txtamount.Text);
                cmd.CommandText = "select From_date,To_date,Total_adults from Bookings where Room_no=@roomno ";
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    txtfromdate.Text = dr.GetValue(0).ToString();
                    txttodate.Text = dr.GetValue(1).ToString();
                    txtpersons.Text = dr.GetValue(2).ToString();

                }

            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

           
        }

        private void button1_Click(object sender, EventArgs e)
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
    }
}
