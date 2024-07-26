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
    public partial class UserAccount : Form
    {
        public UserAccount()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string cs = ConfigurationManager.ConnectionStrings["abc"].ConnectionString;
                using (SqlConnection con = new SqlConnection(cs))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into User_Account(Name,User_Type,Email,ph_num) Values(@Name,@User_Type,@Email,@Ph_num)", con);
                    cmd.Parameters.AddWithValue("@Name", textname.Text);
                    cmd.Parameters.AddWithValue("@User_Type", comboBox1.Text);
                    cmd.Parameters.AddWithValue("Ph_num", textph.Text);
                    cmd.Parameters.AddWithValue("@Email", textemail.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    label4.ForeColor = System.Drawing.Color.Green;
                    label4.Text = "Your Record is  successfully Upload....";
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void UserAccount_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'shopDataSet.User_Account' table. You can move, or remove it, as needed.
            //this.user_AccountTableAdapter.Fill(this.shopDataSet.User_Account);

        }

        private void record_Click(object sender, EventArgs e)
        {
            try
            {
                string cs = ConfigurationManager.ConnectionStrings["abc"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);
                SqlDataAdapter sda = new SqlDataAdapter("select * from User_Account Where Name like '%" + textBox1.Text + "%' OR User_Type like '%" + textBox1.Text + "%'", con);
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

        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Visible = false;
            ShopDetail obj1 = new ShopDetail();
            obj1.ShowDialog();
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textname.Text = "";
            comboBox1.Text = "";
            textph.Text = "";
            textemail.Text = "";
        }
    }
}
