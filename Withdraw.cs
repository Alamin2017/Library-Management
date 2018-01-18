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
    public partial class Withdraw : Form
    {
        private string textBoxBQuantity;
        public Withdraw()
        {
            InitializeComponent();
        }

        private void Withdraw_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conk = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Al-Amin\Documents\Project.mdf;Integrated Security=True;Connect Timeout=30");
                conk.Open();
                if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(B2.Text) || string.IsNullOrEmpty(textBoxWQuantity.Text))
                {
                    MessageBox.Show("TextBox is empty", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    /*
                    string query = "insert into Withdraw(Id,BookId,Quantity,Withdrawdate)values('" + textBox1.Text + "','" + B2.Text + "','" + textBoxWQuantity.Text + "','"+d1.Value+"')";
                    SqlCommand comma = new SqlCommand(query,conk);
                    comma.ExecuteNonQuery();
                     */ 

                 //   if(B2.Text==B1.Text)
                    string alamin2 = "select count(*) from BookInfo,StudentInfo where BookId='"+B2.Text+"' and Id='"+textBox1.Text+"' ";
                    SqlCommand alamin = new SqlCommand(alamin2, conk);
                    alamin.ExecuteNonQuery();



                    SqlDataReader data = alamin.ExecuteReader();
                
                    if (data.Read())
                    {
                       
                        int c = data.GetInt32(0);
                        if (c == 1)
                        { 
                            data.Close();
                        
                            string qu = "update BookInfo set Quantity=Quantity-'" + textBoxWQuantity.Text.Trim() + "'  where BookId='" + B2.Text.Trim() + "' ";
                            SqlCommand commapa = new SqlCommand(qu, conk);
                            commapa.ExecuteNonQuery();
                            MessageBox.Show("OK");
                        }
                        else
                            MessageBox.Show("dont match", "alert", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                
                    
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
