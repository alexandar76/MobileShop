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
    public partial class BillRecord : Form
    {
        public BillRecord()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string cs = ConfigurationManager.ConnectionStrings["abc"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);
                SqlDataAdapter sda = new SqlDataAdapter("select * from invoice_t", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
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
                SqlDataAdapter sda = new SqlDataAdapter("select * from invoice_t Where invoice_number like '" + textBox1.Text + "%'OR Customer_Name like '%" + textBox1.Text + "%'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception)
            {
                MessageBox.Show("Please Search through invoice_number OR Date OR Customer Namae");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                string cs = ConfigurationManager.ConnectionStrings["abc"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);
                SqlDataAdapter sda = new SqlDataAdapter("select * from invoice_t Where Date BETWEEN '" + dateTimePicker1.Value + "' AND '" + dateTimePicker2.Value + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception)
            {
                MessageBox.Show("Please Search through invoice_number OR Date OR Customer Namae");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {


            int sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dataGridView1.Rows[i].Cells[6].Value);
            }
            textBox2.Text = sum.ToString();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter();
            SqlCommandBuilder scb = new SqlCommandBuilder(sda);
            DataTable dt = new DataTable();
            sda.Update(dt);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                ShopDetail brg = new ShopDetail();
                brg.Show();
            }
            catch (Exception f)
            {
                MessageBox.Show(f.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ShopDetail obj2 = new ShopDetail();
            obj2.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
