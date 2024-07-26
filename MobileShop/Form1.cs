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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Please provide username and password");
                return;
            }
            else
            {
                try
                {
                    string cs = ConfigurationManager.ConnectionStrings["abc"].ConnectionString;
                    SqlConnection con = new SqlConnection(cs);

                    SqlCommand cmd = new SqlCommand("Select * from login where username=@username and password=@password", con);
                    cmd.Parameters.AddWithValue("@username", textBox1.Text);
                    cmd.Parameters.AddWithValue("@password", textBox2.Text);
                    con.Open();
                    SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adapt.Fill(ds);
                    con.Close();

                    int count = ds.Tables[0].Rows.Count;
                    if (count == 1)
                    {
                        this.Hide();
                        ShopDetail obj2 = new ShopDetail();
                        obj2.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Login failed");
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void changepassword_Click(object sender, EventArgs e)
        {
            UpdatePassword obj1 = new UpdatePassword();
            obj1.ShowDialog();
        }
    }
}
