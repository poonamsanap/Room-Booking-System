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
    public partial class Allrooms1 : Form
    {
        public Allrooms1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please Login to book this room");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please Login to book this room");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please Login to book this room");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
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

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please Login to book this room");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserLogin l = new UserLogin();
            l.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Home h=new Home();
            h.Show();
            this.Hide();
        }

        private void Allrooms1_Load(object sender, EventArgs e)
        {
           
        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            moreRooms1 m = new moreRooms1();
            m.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
