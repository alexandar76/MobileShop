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
    public partial class PaymentRecord : Form
    {
        public PaymentRecord()
        {
            InitializeComponent();
        }
     
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string cs = ConfigurationManager.ConnectionStrings["abc"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);
                SqlDataAdapter sda = new SqlDataAdapter("select * from Payment_Record", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch
            { }
            try
            {
                int sum = 0;
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    if (dataGridView1.Rows[i].Cells[6].Value != null)
                    {
                        sum += Convert.ToInt32(dataGridView1.Rows[i].Cells[6].Value.ToString());


                    }
                }
                textBox2.Text = sum.ToString();
            }
            catch (Exception f)
            {
                MessageBox.Show(f.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string cs = ConfigurationManager.ConnectionStrings["abc"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);
                SqlDataAdapter sda = new SqlDataAdapter("select * from Payment_Record Where invoice_number like '" + textBox1.Text + "'OR customer_name like '%" + textBox1.Text + "%'", con);

                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception)
            {
                MessageBox.Show("Please search through Customer Name OR INvoice Number");
            }
            try
            {
                int sum = 0;
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    if (dataGridView1.Rows[i].Cells[6].Value != null)
                    {
                        sum += Convert.ToInt32(dataGridView1.Rows[i].Cells[6].Value.ToString());


                    }
                }
                textBox2.Text = sum.ToString();
            }
            catch (Exception f)
            {
                MessageBox.Show(f.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter();
                DataTable dt = new DataTable();
                SqlCommandBuilder scb = new SqlCommandBuilder(sda);
                sda.Update(dt);

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

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Invoice obj2 = new Invoice();
            obj2.ShowDialog();
        }
    }
}
