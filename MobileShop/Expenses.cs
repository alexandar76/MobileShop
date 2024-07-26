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
    public partial class Expenses : Form
    {
        public Expenses()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["abc"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into expen(Expenses_Title,Descripation,Amount,Date) Values(@Expenses_Title,@Descripation,@Amount,@Date", con);
                cmd.Parameters.AddWithValue("@Expenses_Title", comboBox1.Text);
                cmd.Parameters.AddWithValue("@Descripation", textBox2.Text);
                cmd.Parameters.AddWithValue("@Amount", textBox1.Text);
                cmd.Parameters.AddWithValue("@Date", textBox4.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                label2.ForeColor = System.Drawing.Color.Green;
                label2.Text = "Saved...";
                textBox4.Text = "";
                comboBox1.Text = "";
                textBox1.Text = "";
                textBox2.Text = "";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                string cs = ConfigurationManager.ConnectionStrings["abc"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);
                SqlDataAdapter sda = new SqlDataAdapter("select * from expen Where Expenses_Title like '%" + textBox3.Text + "%'OR Amount like '%" + textBox3.Text + "%' OR Date like '%" + textBox3.Text + "%'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception)
            {
                MessageBox.Show("Please search through Expenses_Title OR Amount");
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
