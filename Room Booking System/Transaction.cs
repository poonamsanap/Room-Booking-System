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
    public partial class Transaction : Form
    {
        public string roomno{ get; set; }
        public string amount { get; set; }

        public Transaction()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }
        public bool isEmpty()
        {
            if (txtamount.Text.Equals(String.Empty) || txtcardno.Text.Equals(String.Empty) || txtcvv.Text.Equals(string.Empty)|| txtname.Text.Equals(string.Empty)|| txtroomno.Text.Equals(string.Empty) || comboBox1.Text.Equals(string.Empty) || comboBox2.Text.Equals(string.Empty) || comboBox3.Text.Equals(string.Empty))
                return true;
            else
                return false;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (isEmpty())
            {
                MessageBox.Show("ALl fields are mandatory");
            }
            else
            {

                string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\poona\OneDrive\Documents\RoomBookingSystemDatabase.mdf;Integrated Security=True;Connect Timeout=30 ";
                using (SqlConnection con = new SqlConnection(connection))


                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    // cmd.Parameters.AddWithValue("@roomno", txtroomno.Text);
                    cmd.Parameters.AddWithValue("@cardno", txtcardno.Text);
                    cmd.Parameters.AddWithValue("@name", txtname.Text);
                    cmd.Parameters.AddWithValue("@cardtype", comboBox3.Text);
                    cmd.Parameters.AddWithValue("@cvv", txtcvv.Text);
                    cmd.Parameters.AddWithValue("@Expiry_date", (comboBox1.Text + "" + comboBox2.Text));
                    cmd.Parameters.AddWithValue("@totalamount", txtamount.Text);

                    cmd.CommandText = "insert into Transactions(Card_no,Cardholder_name,Card_type,CVV,Expiry_date,Amount)values(@cardno,@name,@cardtype,@cvv,@Expiry_date,@totalamount)";
                    cmd.ExecuteNonQuery();

                    cmd.Parameters.AddWithValue("@roomno", Class2.roomno);
                    cmd.Parameters.AddWithValue("@fromdate", Class2.fromdate);
                    cmd.Parameters.AddWithValue("@todate", Class2.todate);
                    cmd.Parameters.AddWithValue("@persons", Class2.persons);
                    cmd.Parameters.AddWithValue("@amount", Class2.totalamount);
                    cmd.Parameters.AddWithValue("@personid", Class2.userid ) ;

                    cmd.CommandText = "insert into Bookings(Room_no,From_date,To_date,Total_adults,Amount,PersonId)values(@roomno,@fromdate,@todate,@persons,@amount,@personid)";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(" Transaction Successfull.Your Booking is Confirmed");
                }




                BookingSlip b = new BookingSlip();
                b.roomno = txtroomno.Text;
                b.amount = txtamount.Text;
                b.Show();
                this.Hide();
            }       
           
        }

        private void Transaction_Load(object sender, EventArgs e)
        {
            txtroomno.Text = roomno;
            txtamount.Text= amount; 
        }

        private void txtcardno_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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
