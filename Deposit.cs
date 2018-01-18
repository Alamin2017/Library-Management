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
    public partial class Deposit : Form
    {
        public Deposit()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conk = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Al-Amin\Documents\Project.mdf;Integrated Security=True;Connect Timeout=30");
                conk.Open();
                if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(B2.Text) || string.IsNullOrEmpty(textBoxDQuantity.Text))
                {
                    MessageBox.Show("TextBox is empty", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                 
                    string alamin2 = "select count(*) from BookInfo,StudentInfo where BookId='" + B2.Text + "' and Id='"+textBox1.Text+"'";
                    SqlCommand alamin = new SqlCommand(alamin2, conk);
                    alamin.ExecuteNonQuery();



                    SqlDataReader data = alamin.ExecuteReader();

                    if (data.Read())
                    {

                        int c = data.GetInt32(0);
                        if (c == 1)
                        {
                            data.Close();

                            string qu = "update BookInfo set Quantity=Quantity + '" + textBoxDQuantity.Text.Trim() + "'  where BookId='" + B2.Text.Trim() + "' ";
                            SqlCommand commapa = new SqlCommand(qu, conk);
                            commapa.ExecuteNonQuery();
                            MessageBox.Show("OK");
                        }
                        else
                            MessageBox.Show("dont match", "alert", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void B2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
