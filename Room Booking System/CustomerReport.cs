using ClosedXML.Excel;
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
    public partial class CustomerReport : Form
    {
        public CustomerReport()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CustomerReport_Load(object sender, EventArgs e)
        {
            string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\poona\OneDrive\Documents\RoomBookingSystemDatabase.mdf;Integrated Security=True;Connect Timeout=30 ";
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            //string str= "select User_id,Name,City,DOB,Email,contactno from Usertable";
            string str = "select u.Name,u.City,u.DOB,u.Email,u.contactno,b.Room_no from Usertable u,Bookings b where u.Username=b.PersonId";


            SqlDataAdapter da = new SqlDataAdapter(str,con);
            DataTable dt = new DataTable(); 
            da.Fill(dt);
            dataGridView1.DataSource= dt;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AdminData a = new AdminData();
            a.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.ApplicationClass XcelApp = new Microsoft.Office.Interop.Excel.ApplicationClass();
                XcelApp.Application.Workbooks.Add(Type.Missing);
                for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
                {
                    XcelApp.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        try
                        {
                            XcelApp.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();

                        }
                        catch (Exception)
                        {
                            // MessageBox.Show("File created Sucessfully");
                            Console.WriteLine("File created Sucessfully");
                            break;
                        }

                    }
                }
                XcelApp.Columns.AutoFit();
                XcelApp.Visible = true;
            }
        }
    }
}
