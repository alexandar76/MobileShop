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
    public partial class BankSN : Form
    {
        public BankSN()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                string cs = ConfigurationManager.ConnectionStrings["abc"].ConnectionString;
                using (SqlConnection con = new SqlConnection(cs))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("isnert into bank2(Name,Shop,Bnk_ac_num,Account_title,Amount,S_R) Values(@Name,@Shop,@Bnk_ac_num,@Account_title,@Amount,S_R)", con);
                    cmd.Parameters.AddWithValue("Name", textname.Text);
                    cmd.Parameters.AddWithValue("@Shop", textBox1.Text);
                    cmd.Parameters.AddWithValue("@Bnk_ac-num", textBox2.Text);
                    cmd.Parameters.AddWithValue("@Account", textBox3.Text);
                    cmd.Parameters.AddWithValue("@Amount", textBox4.Text);
                    cmd.Parameters.AddWithValue("@S_R", textBox5.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    label1.ForeColor = System.Drawing.Color.Green;
                    label1.Text = "Your Record is  successfully Upload....";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please Insert Values As Required");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textname.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                string cs = ConfigurationManager.ConnectionStrings["abc"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);
                SqlDataAdapter sda = new SqlDataAdapter("select * from bank2 Where   Name like '%" + textBox8.Text + "%' OR  Date like '%" + textBox8.Text + "%' OR Bnk_ac_num like  '" + textBox8.Text + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
