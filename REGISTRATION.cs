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
    public partial class REGISTRATION : Form
    {
        public REGISTRATION()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {

                SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Al-Amin\Documents\Project.mdf;Integrated Security=True;Connect Timeout=30");
                connect.Open();
                if (string.IsNullOrEmpty(this.textBox1.Text) || string.IsNullOrEmpty(this.textBox2.Text))
                {
                    MessageBox.Show("TextBox is Empty");
                }
                else
                {
                    string query = " INSERT INTO REGISTRATION (NAME,PASS) values ('" + textBox1.Text + "','" + textBox2.Text + "')";
                    SqlCommand comma = new SqlCommand(query, connect);
                    comma.ExecuteNonQuery();
                    MessageBox.Show("REGISTRATION OK", "sucess", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
             
            }
            catch(Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
         
      

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
          
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Al-Amin\Documents\Project.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();
                string query = "select COUNT(*) from REGISTRATION where  PASS='" + textBox2.Text + "'";
                SqlCommand comm = new SqlCommand(query, con);
                comm.ExecuteNonQuery();
                SqlDataReader data = comm.ExecuteReader();
                // con.Close();
                if (data.Read())
                {
                    int c = data.GetInt32(0);
                    if (c == 1)
                    {                   
                        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Al-Amin\Documents\Project.mdf;Integrated Security=True;Connect Timeout=30");
                        connect.Open();
                        string querw = " delete from  REGISTRATION where PASS='" + textBox2.Text + "' ";
                        SqlCommand comma = new SqlCommand(querw, connect);
                        comma.ExecuteNonQuery();
                        MessageBox.Show("delete","Sucess");
  
                    }
                    else
                        MessageBox.Show("password is not match", "alert", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }

            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void REGISTRATION_Load(object sender, EventArgs e)
        {

        }
    }
}
