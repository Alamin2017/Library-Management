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
    public partial class UpdateBooks : Form
    {
        public UpdateBooks()
        {
            InitializeComponent();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Al-Amin\Documents\Project.mdf;Integrated Security=True;Connect Timeout=30");
                connection.Open();
                if(string.IsNullOrEmpty(this.textBox1.Text)||string.IsNullOrEmpty(this.textBox2.Text)||string.IsNullOrEmpty(this.textBox3.Text)||string.IsNullOrEmpty(this.textBox4.Text)||string.IsNullOrEmpty(this.textBox5.Text) )
                {
                    MessageBox.Show("TextBox is empty","Alert",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                else
                {
                    string query = "UPDATE BookInfo set BookId='"+textBox1.Text+"',BookTitle='"+textBox2.Text+"',Author='"+textBox3.Text+"',Category='"+textBox4.Text+"',Quantity='"+textBox5.Text+"' where BookId='"+textBox1.Text+"'  ";
                    SqlCommand comma = new SqlCommand(query,connection);
                    int n = comma.ExecuteNonQuery();
                    MessageBox.Show("Update Successfully");
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
