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
    public partial class moreRooms1 : Form
    {
        public moreRooms1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please Login to book this room");
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please Login to book this room");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please Login to book this room");
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please Login to book this room");
        }

        private void Form2_Load(object sender, EventArgs e)
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
                    // pictureBox2.Image = Image.FromStream(ms);

                }
            }

            catch(Exception ex)
            {
                Console.WriteLine("Loading");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            UserLogin l = new UserLogin();
            l.Show();
            this.Hide();
        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Allrooms1 a = new Allrooms1();
            a.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
