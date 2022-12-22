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
    public partial class rooms2 : Form
    {
        public rooms2()
        {
            InitializeComponent();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            newRoomdetails f = new newRoomdetails();
            f.roomno = "303";
            f.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            newRoomdetails f = new newRoomdetails();
            f.roomno = "301";
            f.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            newRoomdetails f = new newRoomdetails();
            f.roomno = "302";
            f.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            rooms1 a=new rooms1();
            a.Show();
            this.Hide();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

          
           // f.roomno = "select Room_no from RoomDetails not in(201,202,203,301,302,303)";
           // String roomname = Class2.newroom;

            string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\poona\OneDrive\Documents\RoomBookingSystemDatabase.mdf;Integrated Security=True;Connect Timeout=30 ";
            using (SqlConnection con = new SqlConnection(connection))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select Room_no from RoomDetails where Room_no not in(201,202,203,301,302,303)");
                cmd.Connection = con;
                 int roomname =(int) cmd.ExecuteScalar();
                newRoomdetails f = new newRoomdetails();
                f.roomno = roomname.ToString();

                f.Show();
                this.Hide();
            }


          
        }

        private void Form3_Load(object sender, EventArgs e)
        {

            try
            {
                string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\poona\OneDrive\Documents\RoomBookingSystemDatabase.mdf;Integrated Security=True;Connect Timeout=30 ";
                using (SqlConnection con = new SqlConnection(connection))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("select Image from RoomDetails where Room_no not in(201,202,203,301,302,303)");
                    cmd.Connection = con;
                    byte[] img = (byte[])cmd.ExecuteScalar();
                    MemoryStream ms = new MemoryStream(img);
                    pictureBox8.Image = Image.FromStream(ms);
              

                }
            }

            catch (Exception ex)
            {
                Console.WriteLine("Loading");
            }

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
