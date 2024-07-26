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
using MobileShop.Properties;

namespace MobileShop
{
    public partial class Invoice : Form
    {
        public Invoice()
        {
            InitializeComponent();
        }

        private List<Cartitems> shoppingcard = new List<Cartitems>();
        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                string cs = ConfigurationManager.ConnectionStrings["abc"].ConnectionString;
                using (SqlConnection con = new SqlConnection(cs))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into invoice_t(invoice_number,customer_name,product_name,Price,Quantity,total_Amount,Date) Values(@invoice_number,@customer_name,@product_name,@Price,@Quantity,@total_Amount,@Date)", con);
                    cmd.Parameters.AddWithValue("invoice_number", textBox1.Text);
                    cmd.Parameters.AddWithValue("@customer_name", comboBox1.Text);
                    cmd.Parameters.AddWithValue("@product_name", comboBox2.Text);
                    cmd.Parameters.AddWithValue("@Price", textBox2.Text);
                    cmd.Parameters.AddWithValue("@Quantity", textBox3.Text);
                    cmd.Parameters.AddWithValue("@total_Amount", textBox4.Text);
                    cmd.Parameters.AddWithValue("@Date", DateTime.Now);
                    cmd.ExecuteNonQuery();
                    con.Close();

                    con.Open();
                    SqlCommand cod = new SqlCommand("UPDATE Purchase_Order SET sTotal_amount='" + textBox10.Text + "'Where Id ='" + textBox12.Text + "'", con);
                    cod.ExecuteNonQuery();
                    con.Close();

                    con.Open();
                    SqlCommand cfd = new SqlCommand("UPDATE Purchase_Order SET Quantity = '" + textBox7.Text + "'    where Id = '" + textBox12.Text + "'", con);
                    cfd.ExecuteNonQuery();
                    con.Close();

                    label13.ForeColor = System.Drawing.Color.Green;
                    label13.Text = "Your Record is  successfully Upload....";
                }
            }
            catch (Exception f)
            {
                MessageBox.Show(f.Message);
            }

            try
            {
                Cartitems item = new Cartitems()
                {
                    Item_Name = comboBox2.Text,
                    Price = Convert.ToInt32(textBox2.Text.Trim()),
                    Quantity = Convert.ToInt32(textBox3.Text.Trim()),
                    Total_Amount = Convert.ToInt32(textBox4.Text.Trim()),
                };
                shoppingcard.Add(item);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = shoppingcard;
                decimal totalamo = shoppingcard.Sum(x => x.Total_Amount);
                textBox5.Text = totalamo.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Please Put All Values ");
            }

            comboBox2.Text = "";
            textBox2.Text = "";
            textBox6.Text = "";
            textBox10.Text = "";
            textBox14.Text = "";
            textBox15.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox7.Text = "";
            textBox11.Text = "";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string cs = ConfigurationManager.ConnectionStrings["abc"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);
                SqlDataAdapter sda = new SqlDataAdapter("select * from adsuplier Where Name= '" + comboBox1.Text + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)

            {
                MessageBox.Show(ex.Message);
            }
            string cs0 = ConfigurationManager.ConnectionStrings["abc"].ConnectionString;
            SqlConnection con1 = new SqlConnection(cs0);
            con1.Open();
            SqlCommand cmd = new SqlCommand("SELECT SUM(Remaining_Payment) as total from Payment_Record where customer_name='"+comboBox1.Text+"'", con1);
            object result = cmd.ExecuteScalar();
            if (result != null)
            {
                textBox16.Text = result.ToString();
            }
            else
            {
                label20.ForeColor = System.Drawing.Color.Green;
                label20.Text = "no previous record....";
            }
            con1.Close();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(textBox5.Text) && !string.IsNullOrEmpty(textBox8.Text))
                {
                    textBox9.Text = (Convert.ToDouble(textBox5) - Convert.ToDouble(textBox8.Text)).ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please Insert Value In Digits");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                string cs = ConfigurationManager.ConnectionStrings["abc"].ConnectionString;
                using (SqlConnection con = new SqlConnection(cs))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into Payment_Record(invoice_number,date,customer_name,Total_Amount,Customer_Payment,Remaining_Payment) Values(@invoice_number,@date,@customer_name,@Total_Amount,@Customer_Payment,@Remaining_Payment)", con);
                    cmd.Parameters.AddWithValue("@invoice_number", textBox1.Text);
                    cmd.Parameters.AddWithValue("@date", DateTime.Now);
                    cmd.Parameters.AddWithValue("@customer_name", comboBox1.Text);
                    cmd.Parameters.AddWithValue("@Total_Amount", textBox5.Text);
                    cmd.Parameters.AddWithValue("@Customer_Payment", textBox8.Text);
                    cmd.Parameters.AddWithValue("@Remaining_Payment", textBox9.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    label6.ForeColor = System.Drawing.Color.Green;
                    label6.Text = "Your Record is  successfully Upload....";

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Invoice Number,Date,Customer Name,Total Payment, Customer Payment, Remaining Payment ");
            }
        }

        private void comboBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string cs = ConfigurationManager.ConnectionStrings["abc"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);
                SqlDataAdapter sda = new SqlDataAdapter("select * from Purchase_Order Where Item_Name like'" + comboBox2.Text + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {
                    textBox2.Text = row["Sale_Price"].ToString();
                    textBox6.Text = row["Quantity"].ToString();
                    textBox10.Text = row["sTotal_amount"].ToString();
                    textBox12.Text = row["Id"].ToString();
                    textBox14.Text = row["IMEI"].ToString();
                    textBox15.Text = row["Catagories"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(textBox2.Text) && !string.IsNullOrEmpty(textBox3.Text))
                {
                    textBox4.Text = (Convert.ToDouble(textBox2.Text) * Convert.ToDouble(textBox3.Text)).ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please Insert Value In Digits");
            }
            try
            {
                if (!string.IsNullOrEmpty(textBox2.Text) && !string.IsNullOrEmpty(textBox3.Text))
                {
                    textBox7.Text = (Convert.ToDouble(textBox6.Text) - Convert.ToDouble(textBox3.Text)).ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please Insert Value In Digits");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                label13.ForeColor = System.Drawing.Color.Red;

                label13.Text = "Please Enter the New Record....";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox7.Text = "";
                textBox11.Text = "";
            }
            catch (Exception f)
            {
                MessageBox.Show(f.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Invoice iv = new Invoice();
            iv.ShowDialog();
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            BillRecord obj2 = new BillRecord();
            obj2.ShowDialog();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            PaymentRecord obj3 = new PaymentRecord();
            obj3.ShowDialog();
        }
    }
}
