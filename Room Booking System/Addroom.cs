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
    public partial class Addroom : Form
    {
        private byte[] imgbytes;

        public Addroom()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                OpenFileDialog obj = new OpenFileDialog();
                obj.Filter = "Image Files (*.jpg)|*.jpg";
                obj.FilterIndex = 1;
                DialogResult file = obj.ShowDialog();
                if (file == DialogResult.OK)
                {
                    pictureBox1.Image = System.Drawing.Image.FromFile(obj.FileName);
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    this.imgbytes = imageToByteArray(System.Drawing.Image.FromFile(obj.FileName));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Class2.newroom = txtroomno.Text;
                string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\poona\OneDrive\Documents\RoomBookingSystemDatabase.mdf;Integrated Security=True;Connect Timeout=30 ";
                using (SqlConnection con = new SqlConnection(connection))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    System.Drawing.Image ximgx = pictureBox1.Image;
                    imgbytes = imageToByteArray(ximgx);

                    cmd.Parameters.AddWithValue("@roomno", txtroomno.Text);
                    cmd.Parameters.AddWithValue("@roomtype", roomtype.Text);
                    cmd.Parameters.AddWithValue("@Bedquantity", txtbeds.Text);
                    cmd.Parameters.AddWithValue("@capacity", txtperson.Text);
                    cmd.Parameters.AddWithValue("@amount", txtamount.Text);
                    cmd.Parameters.AddWithValue("@image", imgbytes);


                    cmd.CommandText = "insert into RoomDetails (Room_no,Room_type,Bed_quantity,Capacity,Amount,Image)values(@roomno,@roomtype,@Bedquantity,@capacity,@amount,@image)";
                    int rowaffected = cmd.ExecuteNonQuery();
                    if (rowaffected > 0)
                    {
                        MessageBox.Show("Room added Successfully");
                       // txtroomno.Text = " ";
                        txtamount.Text = "";
                        txtbeds.Text = " ";
                        txtperson.Text = " ";
                        txtselect.Text = " ";
                        roomtype.Text = " ";

                        //Class2.newroom = txtroomno.Text;

                    }
                    else
                    {
                        MessageBox.Show("Room not added Please try again");
                    }



                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Something went wrong! please try again");
            }

            }

        private void Addroom_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AdminData a=new AdminData();
            a.Show();
            this.Hide();    
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AdminData a = new AdminData();
            a.Show();
            this.Hide();
        }
    }
}
