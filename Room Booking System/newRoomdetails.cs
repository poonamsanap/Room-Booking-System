using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Room_Booking_System
{
    public partial class newRoomdetails : Form
    { public string roomno { get; set; }
        public newRoomdetails()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\poona\OneDrive\Documents\RoomBookingSystemDatabase.mdf;Integrated Security=True;Connect Timeout=30 ";
            using (SqlConnection con = new SqlConnection(connection))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.Parameters.AddWithValue("@roomno", txtroomno.Text);

                cmd.CommandText = "select * from Bookings where Room_no=@roomno";
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Room is Already Booked please try other");
                }
                else
                {
                    BookingDetails b = new BookingDetails();
                    b.roomno = txtroomno.Text;
                    b.roomtype = txtroomtype.Text;
                    b.amount = txtamount.Text;

                    b.Show();
                    this.Hide();
                }
            }

             
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            try
            {
                txtroomno.Text = roomno;
                string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\poona\OneDrive\Documents\RoomBookingSystemDatabase.mdf;Integrated Security=True;Connect Timeout=30 ";
                using (SqlConnection con = new SqlConnection(connection))
                {
                    con.Open();


                    SqlCommand cmd = new SqlCommand("select Image,Room_type,Capacity,Amount,Bed_quantity from RoomDetails where Room_no=@roomno");
                    cmd.Connection = con;
                    cmd.Parameters.AddWithValue("@roomno", txtroomno.Text);
                    //cmd.Parameters.AddWithValue("@roomno", Class2.newroom);

                    byte[] img = (byte[])cmd.ExecuteScalar();
                    MemoryStream ms = new MemoryStream(img);
                    pictureBox1.Image = Image.FromStream(ms);
                    cmd.ExecuteNonQuery();
                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {

                        sdr.Read();


                        txtroomtype.Text = sdr["Room_type"].ToString();
                        txtperson.Text = sdr["Capacity"].ToString();
                        txtamount.Text = sdr["Amount"].ToString();
                        txtbeds.Text = sdr["Bed_quantity"].ToString();

                    }
                }
            

            }
            catch(Exception ex)
            {
                Console.WriteLine("Booking slip generated");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            rooms2 a = new rooms2();
            a.Show();
            this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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
    }
}
