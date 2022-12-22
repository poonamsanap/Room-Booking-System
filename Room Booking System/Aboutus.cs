using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Room_Booking_System
{
    public partial class Aboutus : Form
    {
        public Aboutus()
        {
            InitializeComponent();
        }

        private  void textBox1_TextChanged(object sender, EventArgs e)
        {
           /* using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Text Documents|*.txt", ValidateNames = true, Multiselect = false })
            {
                if(ofd.ShowDialog() == DialogResult.OK)
                {
                    using (StreamReader sr = new StreamReader(ofd.fileName))
                    {
                        string line = sr.ReadLine();    
                    }
                }
            }
            */
           
        }

        private void Aboutus_Load(object sender, EventArgs e)
        {
           /* string path = @"C:\Users\poona\OneDrive\Desktop\dot net\test.docx";
            StreamReader sr = new StreamReader(path);
            string filedata = sr.ReadToEnd();
            textBox1.Text = filedata.ToString();
            sr.Close();
           */
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
