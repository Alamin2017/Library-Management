using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OutlookMail
{
    public partial class AddStudentInfo : Form
    {
        public AddStudentInfo()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Al-Amin\Documents\Project.mdf;Integrated Security=True;Connect Timeout=30");
                connect.Open();
                if (string.IsNullOrEmpty(this.textBox1.Text) || string.IsNullOrEmpty(this.textBox2.Text) || string.IsNullOrEmpty(this.textBox3.Text) || string.IsNullOrEmpty(this.textBox4.Text) || string.IsNullOrEmpty(this.textBox5.Text) )
                {
                    MessageBox.Show("TextBox is Empty", "alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string query = " INSERT INTO StudentInfo (Id,Name,Mobile,Gmail,Address) values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "') ";
                    SqlCommand comma = new SqlCommand(query, connect);
                    comma.ExecuteNonQuery();
                    MessageBox.Show("Save Successfully");
                }

            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);

            }
        }
    }
}
