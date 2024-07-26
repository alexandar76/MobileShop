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
    public partial class OwnerLogin : Form
    {
        public OwnerLogin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Please provide UserName and Password");
                return;
            }
            try
            {
                //Create SqlConnection
                string cs = ConfigurationManager.ConnectionStrings["abc"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);

                SqlCommand cmd = new SqlCommand("Select * from owner_login where username=@username and Password=@password", con);
                cmd.Parameters.AddWithValue("@username", textBox1.Text);
                cmd.Parameters.AddWithValue("@password", textBox2.Text);
                con.Open();
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapt.Fill(ds);
                con.Close();

                int count = ds.Tables[0].Rows.Count;
                //If count is equal to 1, than show frmMain form
                if (count == 1)
                {

                    this.Hide();
                    OwnerPanel f1 = new OwnerPanel();
                    f1.Show();
                }
                else
                {
                    MessageBox.Show("Login Failed!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            ShopDetail obj2 = new ShopDetail();
            obj2.ShowDialog();
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void changepassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            UpdateOwnerPassword obj3 = new UpdateOwnerPassword();
            obj3.ShowDialog();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
        }
    }
}
