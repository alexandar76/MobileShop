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
    public partial class AddSupplier : Form
    {
        public AddSupplier()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["abc"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into adsupplier(NICNumber,Name,Ph_Number,Email,Home_Address,Date) Values((@NICNumber,@Name,@Ph_Number,@Email,@Home_Address,@Date)", con);
                    cmd.Parameters.AddWithValue("@NICNumber", textcnic.Text);
                    cmd.Parameters.AddWithValue("@Name", txtname.Text);
                    cmd.Parameters.AddWithValue("@Ph_Number", txtph.Text);
                    cmd.Parameters.AddWithValue("@Email", txtemail.Text);
                    cmd.Parameters.AddWithValue("@Home_Address", textadress.Text);
                    cmd.Parameters.AddWithValue("@Date", this.dateTimePicker1.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    label7.ForeColor = System.Drawing.Color.Green;
                    label7.Text = "New Supplier Record Insert Successfully....";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                dateTimePicker1.Text = "";
                txtph.Text = "";
                textadress.Text = "";

                txtemail.Text = "";
                textcnic.Text = "";
                txtname.Text = "";

                txtph.Text = "";
                label7.ForeColor = System.Drawing.Color.Red;
                label7.Text = "Please Enter the New Record ....";
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
                SqlDataAdapter sda = new SqlDataAdapter("select * from adsupplier Where Name like '%" + textBox1.Text + "%'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception)
            {
                MessageBox.Show("Please search through Supplier name");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string cs = ConfigurationManager.ConnectionStrings["abc"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);

                SqlDataAdapter sda = new SqlDataAdapter("select * from  adsupplier", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception f)
            {
                MessageBox.Show(f.Message);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            ShopDetail obj1 = new ShopDetail();
            obj1.ShowDialog();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}
