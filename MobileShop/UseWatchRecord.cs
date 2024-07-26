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
    public partial class UseWatchRecord : Form
    {
        public UseWatchRecord()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string cs = ConfigurationManager.ConnectionStrings["abc"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);
                SqlDataAdapter sda = new SqlDataAdapter("select Item_Name,Sale_Price,Quantity,sTotal_amount,Catagories,Colour,Company_Name,IMEI from Purchase_Order Where Item_Name like '%" + textBox1.Text + "%'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int sum = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    sum += Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value);
                }
                label2.Text = sum.ToString();
            }
            catch (Exception f)
            {
                MessageBox.Show(f.Message);
            }
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Visible = false;
            ShopDetail obj2 = new ShopDetail();
            obj2.ShowDialog();
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}
