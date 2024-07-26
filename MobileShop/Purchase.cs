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
    public partial class Purchase : Form
    {
        public Purchase()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string cs = ConfigurationManager.ConnectionStrings["abc"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);
                SqlDataAdapter sda = new SqlDataAdapter("select * from Purchase_Order", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                int sum = 0;
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    if (dataGridView1.Rows[i].Cells[8].Value != null)
                    {
                        sum += Convert.ToInt32(dataGridView1.Rows[i].Cells[8].Value.ToString());


                    }
                }
                textBox2.Text = sum.ToString();
            }
            catch (Exception f)
            {
                MessageBox.Show(f.Message);
            }
            try
            {
                int sum = 0;
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    if (dataGridView1.Rows[i].Cells[10].Value != null)
                    {
                        sum += Convert.ToInt32(dataGridView1.Rows[i].Cells[10].Value.ToString());


                    }
                }
                textBox3.Text = sum.ToString();
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
                SqlDataAdapter sda = new SqlDataAdapter("select * from Purchase_Order Where  Party_Name like '%" + textBox1.Text + "%' OR Bill_number like '" + textBox1.Text + "' OR Item_Name like '%" + textBox1.Text + "%' OR Company_Name like '%" + textBox1.Text + "%'", con);

                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception f)
            {
                MessageBox.Show(f.Message);
            }
            try
            {
                int sum = 0;
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    if (dataGridView1.Rows[i].Cells[8].Value != null)
                    {
                        sum += Convert.ToInt32(dataGridView1.Rows[i].Cells[8].Value.ToString());


                    }
                }
                textBox2.Text = sum.ToString();
            }
            catch (Exception f)
            {
                MessageBox.Show(f.Message);
            }
            try
            {
                int sum = 0;
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    if (dataGridView1.Rows[i].Cells[10].Value != null)
                    {
                        sum += Convert.ToInt32(dataGridView1.Rows[i].Cells[10].Value.ToString());


                    }
                }
                textBox3.Text = sum.ToString();
            }
            catch (Exception f)
            {
                MessageBox.Show(f.Message);
            }
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            OwnerPanel obj1 = new OwnerPanel();
            obj1.ShowDialog();
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }

}
