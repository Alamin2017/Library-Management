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
    public partial class AddBooks : Form
    {
        public AddBooks()
        {
            InitializeComponent();
        }

        private void AddBooks_Load(object sender, EventArgs e)
        {

        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Al-Amin\Documents\Project.mdf;Integrated Security=True;Connect Timeout=30");
                connect.Open();
                if (string.IsNullOrEmpty(this.B1.Text) || string.IsNullOrEmpty(this.textBox2.Text) || string.IsNullOrEmpty(this.textBox3.Text) || string.IsNullOrEmpty(this.textBox4.Text) || string.IsNullOrEmpty(this.textBoxBQuantity.Text))
                {
                    MessageBox.Show("TextBox is empty", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string query = "INSERT INTO BookInfo (BookId,BookTitle,Author,Category,Quantity) values('"+B1.Text +"','"+textBox2.Text +"','"+textBox3.Text +"','"+textBox4.Text +"','"+textBoxBQuantity.Text +"')";
                    SqlCommand comma = new SqlCommand(query, connect);
                   int n=comma.ExecuteNonQuery();
                    MessageBox.Show("Saved Successfully");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
