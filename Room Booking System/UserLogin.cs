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
    public partial class UserLogin : Form
    {
        public UserLogin()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\poona\OneDrive\Documents\RoomBookingSystemDatabase.mdf;Integrated Security=True;Connect Timeout=30 ";
            using (SqlConnection con = new SqlConnection(connection))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con; cmd.Parameters.AddWithValue("@username", txtusername.Text);
                cmd.Parameters.AddWithValue("@password", txtpassword.Text);
                cmd.CommandText = " select * from Usertable where username=@username and password=@password";
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Login Successfull");
                    Class2.username = dr[5].ToString();
                    Class2.password = dr[6].ToString(); 
                    if (txtusername.Text =="poonam")
                    {
                      AdminData a =new AdminData();
                        a.Show();
                        this.Hide();
                    }
                    else
                    {
                        rooms1 r = new rooms1();
                        r.Show();
                        this.Hide();
                    }

                    
                }
                else
                {
                    MessageBox.Show("username and password not matched");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotPassword f = new ForgotPassword();
            f.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
           
        }

        private void UserLogin_Load(object sender, EventArgs e)
        {
            txtpassword.UseSystemPasswordChar = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtpassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtpassword.UseSystemPasswordChar = true;
            }
        }
    }
}