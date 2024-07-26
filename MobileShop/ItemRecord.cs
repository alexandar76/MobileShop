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
    public partial class ItemRecord : Form
    {
        public ItemRecord()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string cs = ConfigurationManager.ConnectionStrings["abc"].ConnectionString;
                using (SqlConnection connection = new SqlConnection(cs))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("insert into Purchase_Order(Date,Catagories,Item_Name,Purchase_Price,Company_Name,Party_name,Quantity,pTotal_amount,Sale_Price,sTotal_amount,Bill_number,Colour,IMEI,Descripation) Values(@Date,@Catagories,@Item_Name,@Purchase_Price,@Company_Name,@Party_name,@Quantity,@pTotal_amount,@Sale_Price,@sTotal_amount,@Bill_number,@Colour,@IMEI,@Descripation)", connection);
                    cmd.Parameters.AddWithValue("@Date", this.dateTimePicker1.Text);
                    cmd.Parameters.AddWithValue("@Catagories", comboBox2.Text);
                    cmd.Parameters.AddWithValue("@Item_Name", comboBox4.Text);

                    cmd.Parameters.AddWithValue("@Purchase_Price", txtpurchase.Text);
                    cmd.Parameters.AddWithValue("@Company_Name", comboBox1.Text);
                    cmd.Parameters.AddWithValue("@Party_Name", comboBox3.Text);
                    cmd.Parameters.AddWithValue("@Quantity", quntty.Text);
                    cmd.Parameters.AddWithValue("@pTotal_amount", textBox2.Text);
                    cmd.Parameters.AddWithValue("@Sale_Price", textBox1.Text);
                    cmd.Parameters.AddWithValue("@sTotal_amount", textBox3.Text);
                    cmd.Parameters.AddWithValue("@Bill_number", txtcatagories.Text);
                    cmd.Parameters.AddWithValue("@Colour", comboBox5.Text);
                    cmd.Parameters.AddWithValue("@IMEI", txtitemname.Text);
                    cmd.Parameters.AddWithValue("@Descripation", textBox5.Text);



                    cmd.ExecuteNonQuery();
                    connection.Close();

                    label2.ForeColor = System.Drawing.Color.Green;


                    label2.Text = "SAVE....";




                    try
                    {
                        if (!string.IsNullOrEmpty(textBox2.Text) && !string.IsNullOrEmpty(textBox4.Text))
                        {
                            textBox4.Text = (Convert.ToDouble(textBox4.Text) + Convert.ToDouble(textBox2.Text)).ToString();
                        }
                    }
                    catch (Exception f)
                    {
                        MessageBox.Show(f.Message);
                    }





                    comboBox1.Text = "";
                    txtitemname.Text = "";
                    txtpurchase.Text = "";


                    quntty.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    comboBox4.Text = "";
                    comboBox5.Text = "";
                    textBox5.Text = "";
                    textBox1.Text = "";

                }
            }
            catch (Exception f)
            {
                MessageBox.Show(f.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string cs = ConfigurationManager.ConnectionStrings["abc"].ConnectionString;
                using (SqlConnection connection = new SqlConnection(cs))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("insert into leger(Date,Bill_number,Amount,Party_name,Given_amount,Remaining_amont) Values(@Date,@Bill_number,@Amount,@Party_name,@Given_amount,@Remaining_amont)", connection);
                    cmd.Parameters.AddWithValue("@Date", dateTimePicker1.Text);
                    cmd.Parameters.AddWithValue("@Bill_number", txtcatagories.Text);
                    cmd.Parameters.AddWithValue("@Amount", textBox4.Text);

                    cmd.Parameters.AddWithValue("@Party_name", comboBox3.Text);
                    cmd.Parameters.AddWithValue("@Given_amount", textBox6.Text);
                    cmd.Parameters.AddWithValue("@Remaining_amont", textBox7.Text);




                    cmd.ExecuteNonQuery();
                    connection.Close();

                    label2.ForeColor = System.Drawing.Color.Green;


                    label2.Text = "SAVE....";
                }
            }
            catch (Exception f)
            {
                MessageBox.Show(f.Message);
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(textBox4.Text) && !string.IsNullOrEmpty(textBox6.Text))
                {
                    textBox7.Text = (Convert.ToDouble(textBox4.Text) - Convert.ToDouble(textBox6.Text)).ToString();
                }
            }
            catch (Exception f)
            {
                MessageBox.Show(f.Message);
            }
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            ShopDetail obj1 = new ShopDetail();
            obj1.ShowDialog();
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}
