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
    public partial class UpdateStudentInfo : Form
    {
        public UpdateStudentInfo()
        {
            InitializeComponent();
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
                if (string.IsNullOrEmpty(this.textBox1.Text) || string.IsNullOrEmpty(this.textBox2.Text) || string.IsNullOrEmpty(this.textBox3.Text) || string.IsNullOrEmpty(this.textBox4.Text) || string.IsNullOrEmpty(this.textBox5.Text))
                {
                    MessageBox.Show("TextBox is Empty", "alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string query = "update StudentInfo set Id='" +textBox1.Text + "', Name='" +textBox2.Text + "',Mobile='" +textBox3.Text + "',Gmail='" +textBox4.Text + "',Address='" + textBox5.Text + "' where Id='" +textBox1.Text + "' ";
                    SqlCommand comma = new SqlCommand(query, connect);
                    comma.ExecuteNonQuery();
                    MessageBox.Show("Update Successfully");

                }

            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);

            }
        }
    }
}
