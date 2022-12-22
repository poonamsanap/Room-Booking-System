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
    public partial class ForgotPassword : Form
    {
        public ForgotPassword()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\poona\OneDrive\Documents\RoomBookingSystemDatabase.mdf;Integrated Security=True;Connect Timeout=30 ";
            using (SqlConnection con = new SqlConnection(connection))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.Parameters.AddWithValue("@username", txtusername.Text);
                cmd.Parameters.AddWithValue("@email", txtemail.Text);
                cmd.CommandText = " select * from Usertable where username=@username and email=@email";
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Now you can enter your New password ");
                    txtnewpassword.Enabled = true;
                    txtconfirmpassword.Enabled = true;
                }
                else
                {
                    MessageBox.Show("username and Email not matched.Please check!");
                    txtnewpassword.Enabled = false;
                    txtconfirmpassword.Enabled = false;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\poona\OneDrive\Documents\RoomBookingSystemDatabase.mdf;Integrated Security=True;Connect Timeout=30 ";
            using (SqlConnection con = new SqlConnection(connection))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.Parameters.AddWithValue("newpassword", txtnewpassword.Text);
                cmd.Parameters.AddWithValue("confirmapssword", txtconfirmpassword.Text);

                cmd.Parameters.AddWithValue("@username", txtusername.Text);

                cmd.CommandText = "update Usertable set password=@newpassword where username=@username";
                int rowaffected = cmd.ExecuteNonQuery();

                if (rowaffected > 0)
                {
                    MessageBox.Show("Password Updated Successfully");
                }
                else
                {
                    MessageBox.Show("Password not updated");
                }

            }
        }

        private void button5_Click(object sender, EventArgs e)
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

        private void button6_Click(object sender, EventArgs e)
        {
            UserLogin l = new UserLogin();
            l.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ForgotPassword_Load(object sender, EventArgs e)
        {

        }
    }
}
