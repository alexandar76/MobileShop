using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace MobileShop
{
    public partial class Banking : Form
    {
        SqlDataAdapter sda;
        DataTable dt;
        public Banking()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                string cs = ConfigurationManager.ConnectionStrings["abc"].ConnectionString;
                using (SqlConnection con = new SqlConnection(cs))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into Banking(Date,Day,Amount) Values(@Date,@Day,@Amount)", con);
                    cmd.Parameters.AddWithValue("@Date", dateTimePicker2.Text);
                    cmd.Parameters.AddWithValue("Day", comboBox4.Text);
                    cmd.Parameters.AddWithValue("Amount", comboBox3.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    label13.ForeColor = System.Drawing.Color.Green;
                    label13.Text = "Your Record is  successfully Upload....";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            comboBox3.Text = "";
            label13.ForeColor = System.Drawing.Color.Red;
            label13.Text = "Please Enter the New Record ....";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    string cs = ConfigurationManager.ConnectionStrings["abc"].ConnectionString;
            //    SqlConnection con = new SqlConnection(cs);
            //    SqlDataAdapter sda = new SqlDataAdapter("select * from Banking Where Date like '%" + textBox1.Text + "%'OR Day like '%" + textBox1.Text + "%'", con);
            //    //"select * from Payment_Record Where invoice_number like '" + textBox1.Text + "'OR customer_name like '%" + textBox1.Text + "%'", con
            //    DataTable dt = new DataTable();
            //    sda.Fill(dt);
            //    dataGridView1.DataSource = dt;
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["abc"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            SqlDataAdapter sda = new SqlDataAdapter("select * from Banking", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string cs = ConfigurationManager.ConnectionStrings["abc"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);
                SqlDataAdapter sda = new SqlDataAdapter("select * from Banking Where Date like '%" + textBox1.Text + "%'OR Day like '%" + textBox1.Text + "%'", con);
                //"select * from Payment_Record Where invoice_number like '" + textBox1.Text + "'OR customer_name like '%" + textBox1.Text + "%'", con
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {

                int sum = 0;
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    if (dataGridView1.Rows[i].Cells[3].Value != null)
                    {
                        sum += Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value.ToString());


                    }
                }
                MessageBox.Show(sum.ToString());
            }
            catch (Exception f)
            {
                MessageBox.Show(f.Message);
            }
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            ShopDetail obj1 = new ShopDetail();
            obj1.ShowDialog();
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}
