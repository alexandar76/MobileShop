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
    public partial class UpdatePurchase : Form
    {
        public UpdatePurchase()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string cs = ConfigurationManager.ConnectionStrings["abc"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Purchase_Order SET Item_Name = '" + textBox6.Text + "', Purchase_Price = '" + textBox11.Text + "', Company_Name = '" + textBox2.Text + "', Catagories = '" + textBox7.Text + "', Quantity = '" + textBox8.Text + "', pTotal_amount = '" + textBox9.Text + "', Sale_Price = '" + textBox10.Text + "', sTotal_amount = '" + textBox3.Text + "', IMEI = '" + textBox5.Text + "' where Id = '" + textBox4.Text + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();

                label2.ForeColor = System.Drawing.Color.Green;
                label2.Text = "Your Record is  successfully Upload....";
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
                string cs = ConfigurationManager.ConnectionStrings["abc"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select * from Purchase_Order", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string cs = ConfigurationManager.ConnectionStrings["abc"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);
                SqlDataAdapter sda = new SqlDataAdapter("select * from Purchase_Order Where Item_Name like '%" + textBox1.Text + "%'OR Company_Name like '%" + textBox1.Text + "%'", con);

                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception f)
            {
                MessageBox.Show(f.Message);
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(textBox11.Text) && !string.IsNullOrEmpty(textBox8.Text))
                {
                    textBox9.Text = (Convert.ToDouble(textBox11.Text) * Convert.ToDouble(textBox8.Text)).ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please Insert Value In Digits");
            }
            try
            {
                if (!string.IsNullOrEmpty(textBox8.Text) && !string.IsNullOrEmpty(textBox10.Text))
                {
                    textBox3.Text = (Convert.ToDouble(textBox8.Text) * Convert.ToDouble(textBox10.Text)).ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please Insert Value In Digits");
            }
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(textBox10.Text) && !string.IsNullOrEmpty(textBox8.Text))
                {
                    textBox3.Text = (Convert.ToDouble(textBox10.Text) * Convert.ToDouble(textBox8.Text)).ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please Insert Value In Digits");
            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox4.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox6.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            textBox7.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBox11.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            textBox8.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            textBox9.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
            textBox10.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[10].Value.ToString();
            textBox5.Text = dataGridView1.SelectedRows[0].Cells[13].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            OwnerPanel obj1 = new OwnerPanel();
            obj1.ShowDialog();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}
