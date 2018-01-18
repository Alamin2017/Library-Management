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
using Outlook = Microsoft.Office.Interop.Outlook;

namespace OutlookMail
{
    public partial class OutlookMail : Form
    {
        public OutlookMail()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {

                Outlook._Application _app = new Outlook.Application();
                Outlook.MailItem mail = (Outlook.MailItem)_app.CreateItem(Outlook.OlItemType.olMailItem);
                mail.To = txtTo.Text;
                mail.Subject = txtSubject.Text;
                mail.Body = txtMessage.Text;
                mail.Importance = Outlook.OlImportance.olImportanceNormal;
                ((Outlook.MailItem)mail).Send();
                MessageBox.Show("Your Message has been Successfully sent", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Al-Amin\Documents\practice.mdf;Integrated Security=True;Connect Timeout=30");
            connection.Open();
            TimeSpan ts = DateTime.Today.Subtract(d2.Value);

            if ((ts).TotalDays > 180)
            {
                MessageBox.Show("Please send the message ");
            }
            else
            {
                MessageBox.Show("Time is not over");
            }
        }

        private void d2_ValueChanged(object sender, EventArgs e)
        {
          

        }

        private void Search_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Al-Amin\Documents\Project.mdf;Integrated Security=True;Connect Timeout=30");
                connection.Open();
                
          //      string query = "select  Gmail from StudentInfo where Id='" + textBox1.Text + "' ";
            //    SqlCommand comma = new SqlCommand(query, connection);
              //  comma.ExecuteNonQuery();



                string query1 = "select  WDATE,Gmail from BookWTransaction,StudentInfo where WSI='" +textBox1.Text + "' and Id='"+textBox1.Text+"' ";
                SqlCommand comma1 = new SqlCommand(query1, connection);
                comma1.ExecuteNonQuery();

                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = comma1;
                DataTable dt = new DataTable();
                da.Fill(dt);
                BindingSource bsource = new BindingSource();
                bsource.DataSource = dt;
                dataGridView1.DataSource = bsource;

             
            

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
