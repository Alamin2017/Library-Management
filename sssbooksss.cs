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
    public partial class sssbooksss : Form
    {
        public sssbooksss()
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
                SqlConnection conk = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Al-Amin\Documents\Project.mdf;Integrated Security=True;Connect Timeout=30");
                conk.Open();
                if (String.IsNullOrEmpty(textBox1.Text)||(String.IsNullOrEmpty(textBox2.Text))||(String.IsNullOrEmpty(textBox3.Text))||(string.IsNullOrEmpty(textBox4.Text))||(string.IsNullOrEmpty(textBox5.Text)))
                {
                    MessageBox.Show("The textbox is Empty");
                }
                else
                {
                    String query = "insert into BookInformation(BookId,BookName,Author,Quantity,Location)values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "')";
                    SqlCommand alamin = new SqlCommand(query,conk);
                    alamin.ExecuteNonQuery();
                    MessageBox.Show("Save Successfully");

                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                    SqlConnection conk = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Al-Amin\Documents\Project.mdf;Integrated Security=True;Connect Timeout=30");
                    conk.Open();
                    String query = "select *from BookInformation"; 
                    SqlCommand alamin = new SqlCommand(query, conk);
                    alamin.ExecuteNonQuery();

                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand=alamin;
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

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Al-Amin\Documents\Project.mdf;Integrated Security=True;Connect Timeout=30");
                connection.Open();
                if (string.IsNullOrEmpty(this.textBox1.Text) || string.IsNullOrEmpty(this.textBox2.Text) || string.IsNullOrEmpty(this.textBox3.Text) || string.IsNullOrEmpty(this.textBox4.Text) || string.IsNullOrEmpty(this.textBox5.Text))
                {
                    MessageBox.Show("TextBox is empty", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string query = "UPDATE BookInformation set BookName='" + textBox2.Text + "',Author='" + textBox3.Text + "',Quantity='" + textBox4.Text + "',Location='" + textBox5.Text + "' where BookId='" + textBox1.Text + "'  ";
                    SqlCommand comma = new SqlCommand(query, connection);
                    int n = comma.ExecuteNonQuery();
                    MessageBox.Show("Update Successfully");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Al-Amin\Documents\Project.mdf;Integrated Security=True;Connect Timeout=30");
                connection.Open();
                string query = "select *from BookInformation where BookName LIKE '"+textBox2.Text+"%' ";
                SqlCommand comma = new SqlCommand(query, connection);
                comma.ExecuteNonQuery();

                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = comma;
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Al-Amin\Documents\Project.mdf;Integrated Security=True;Connect Timeout=30");
                connection.Open();
                string query = "select *from BookInformation where BookName LIKE '" + textBox2.Text + "%' ";
                SqlCommand comma = new SqlCommand(query, connection);
                comma.ExecuteNonQuery();

                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = comma;
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

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {

                SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Al-Amin\Documents\Project.mdf;Integrated Security=True;Connect Timeout=30");
                connection.Open();

                string query1 = "select count(*) from BookInformation where BookId='" + textBox1.Text + "' ";
                SqlCommand comm = new SqlCommand(query1, connection);
                comm.ExecuteNonQuery();
                SqlDataReader data = comm.ExecuteReader();
                if (data.Read())
                {
                    int c = data.GetInt32(0);
                    if (c == 1)
                    {
                        data.Close();
                        string query = "delete from BookInformation where BookId='" + textBox1.Text + "' ";
                        SqlCommand comma = new SqlCommand(query, connection);
                        comma.ExecuteNonQuery();
                        MessageBox.Show("Delete Ok");
                    }
                    else
                        MessageBox.Show("don't match ");

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Withdraw_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conk = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Al-Amin\Documents\Project.mdf;Integrated Security=True;Connect Timeout=30");
                conk.Open();
                if (string.IsNullOrEmpty(WSID.Text) || string.IsNullOrEmpty(WBI.Text) || string.IsNullOrEmpty(WQ.Text))
                {
                    MessageBox.Show("TextBox is empty", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                  
                    string alamin2 = "select count(*) from BookInformation where BookId='" + WBI.Text + "'  ";
                    SqlCommand alamin = new SqlCommand(alamin2, conk);
                    alamin.ExecuteNonQuery();



                    SqlDataReader data = alamin.ExecuteReader();

                    if (data.Read())
                    {

                        int c = data.GetInt32(0);
                        if (c == 1)
                        {
                            data.Close();

                            string qu = "update BookInformation set Quantity=Quantity-'" + WQ.Text.Trim() + "'  where BookId='" + WBI.Text.Trim() + "' ";
                            SqlCommand commapa = new SqlCommand(qu, conk);
                            commapa.ExecuteNonQuery();


                            String query = "insert into BookWTransaction(WSI,WBI,WQ,WDATE)values('" + WSID.Text + "','" + WBI.Text + "','" + WQ.Text + "','" + d1.Value + "')";
                            SqlCommand alamin5 = new SqlCommand(query, conk);
                            alamin5.ExecuteNonQuery();

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

        private void Deposit_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conk = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Al-Amin\Documents\Project.mdf;Integrated Security=True;Connect Timeout=30");
                conk.Open();
                if (string.IsNullOrEmpty(DSID.Text) || string.IsNullOrEmpty(DBI.Text) || string.IsNullOrEmpty(DQ.Text))
                {
                    MessageBox.Show("TextBox is empty", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    string alamin2 = "select count(*) from BookInformation where BookId='" + DBI.Text + "'  ";
                    SqlCommand alamin = new SqlCommand(alamin2, conk);
                    alamin.ExecuteNonQuery();



                    SqlDataReader data = alamin.ExecuteReader();

                    if (data.Read())
                    {

                        int c = data.GetInt32(0);
                        if (c == 1)
                        {
                            data.Close();

                            string qu = "update BookInformation set Quantity=Quantity +'" + DQ.Text.Trim() + "'  where BookId='" + DBI.Text.Trim() + "' ";
                            SqlCommand commapa = new SqlCommand(qu, conk);
                            commapa.ExecuteNonQuery();

                            String query = "insert into BookDTransaction(DSI,DBI,DQ,DDATE)values('" + DSID.Text + "','" + DBI.Text + "','" + DQ.Text + "','" + d2.Value + "')";
                            SqlCommand alamin5 = new SqlCommand(query, conk);
                            alamin5.ExecuteNonQuery();

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
    }
}
