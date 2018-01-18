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
    public partial class DeleteStudentInfo : Form
    {
        public DeleteStudentInfo()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonView_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Al-Amin\Documents\Project.mdf;Integrated Security=True;Connect Timeout=30");
            connection.Open();
            string query = "select *from StudentInfo";
            SqlCommand comma = new SqlCommand(query,connection);
            comma.ExecuteNonQuery();

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = comma;
            DataTable dt = new DataTable();
            da.Fill(dt);
            BindingSource bsource = new BindingSource();
            bsource.DataSource = dt;
            dataGridView1.DataSource = bsource;

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
          
            try
            {

                SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Al-Amin\Documents\Project.mdf;Integrated Security=True;Connect Timeout=30");
                connection.Open();

                string query1 = "select count(*) from StudentInfo where Id='" + textBox1.Text + "' ";
                SqlCommand comm = new SqlCommand(query1, connection);
                comm.ExecuteNonQuery();

                SqlDataReader data = comm.ExecuteReader();
                // con.Close();
                if (data.Read())
                {
                    int c = data.GetInt32(0);
                    if (c == 1)
                    {
                        data.Close();
                        string query = "delete from StudentInfo where Id='" + textBox1.Text + "' ";
                        SqlCommand comma = new SqlCommand(query, connection);
                        comma.ExecuteNonQuery();
                        MessageBox.Show("Successfully delete");
                    }
                    else
                        MessageBox.Show("don't match ");

                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
 
        }
    }
}
