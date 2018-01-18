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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Al-Amin\Documents\Project.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();
                string query = "select COUNT(*) from REGISTRATION where NAME='" + textBox1.Text + "' and PASS='" + textBox2.Text + "'";
                SqlCommand comm = new SqlCommand(query, con);
                comm.ExecuteNonQuery();
                SqlDataReader data = comm.ExecuteReader();
               // con.Close();
                if (data.Read())
                {
                    int c = data.GetInt32(0);
                    if (c == 1)
                    {
                        LIBRARY obj = new LIBRARY();
                        obj.Show();
                    }
                    else
                        MessageBox.Show("Username and password is not correct","alert",MessageBoxButtons.OK,MessageBoxIcon.Error);

                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
