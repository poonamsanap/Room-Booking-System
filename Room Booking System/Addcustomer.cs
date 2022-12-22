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
    public partial class Addcustomer : Form
    {
        public Addcustomer()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AdminData a=new AdminData();
            a.Show();   
            this.Hide();    
        }
        public bool isEmpty()
        {
            if (txtusername.Text == "" || txtpassword.Text == "" || txtfullname.Text == "" || txtaddress.Text == ""
                     || txtcontactno.Text == "" || txtemail.Text == "" || comboBox1.Text == "" || dateTimePicker1.Text == "" || txtcity.Text == "")
                return true;
            else
                return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\poona\OneDrive\Documents\RoomBookingSystemDatabase.mdf;Integrated Security=True;Connect Timeout=30 ";
            using (SqlConnection con = new SqlConnection(connection))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.Parameters.AddWithValue("@username", txtusername.Text);
                cmd.Parameters.AddWithValue("@password", txtpassword.Text);
                cmd.Parameters.AddWithValue("@fullname", txtfullname.Text);
                cmd.Parameters.AddWithValue("@address", txtaddress.Text);
                cmd.Parameters.AddWithValue("@contactno", txtcontactno.Text);
                cmd.Parameters.AddWithValue("@email", txtemail.Text);
                cmd.Parameters.AddWithValue("@gender", comboBox1.Text);
                cmd.Parameters.AddWithValue("@dob", dateTimePicker1.Text);
                cmd.Parameters.AddWithValue("@city", txtcity.Text);
                if (!isEmpty())
                {
                    if (txtpassword.Text == txtconfirmpassword.Text)
                    {

                        cmd.CommandText = "insert into Usertable(Name,Email,Gender,DOB,Username,Password,Address,City,contactno)values(@fullname,@email,@gender,@dob,@username,@password,@address,@city,@contactno)";
                        int rowaffected = cmd.ExecuteNonQuery();
                        if (rowaffected > 0)
                        {
                            MessageBox.Show("Registration successfull");
                            txtusername.Text = " ";
                            txtpassword.Text = "";
                            txtfullname.Text = "";
                            txtaddress.Text = "";
                            txtcontactno.Text = "";
                            txtemail.Text = "";
                            comboBox1.Text = "";
                            txtconfirmpassword.Text = " ";
                            // dateTimePicker1.Text=" ";
                            txtcity.Text = " ";




                        }
                        else
                        {
                            MessageBox.Show("Registration failed");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Password and confirm password must be same");
                    }


                }
                else
                {
                    MessageBox.Show("All Field are Compulsory");
                }


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
             this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UserLogin l=new UserLogin();
            l.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            AdminData a = new AdminData();
            a.Show();
            this.Hide();
        }

        private void Addcustomer_Load(object sender, EventArgs e)
        {

        }
    }
}
