﻿using System;
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
    public partial class UpdatePassword : Form
    {
        public UpdatePassword()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string cs = ConfigurationManager.ConnectionStrings["abc"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);
                SqlDataAdapter sda = new SqlDataAdapter("select password from login Where password='" + textBox1.Text + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count.ToString() == "1")
                {
                    if (textBox2.Text == textBox3.Text)
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("UPDATE login SET password='" + textBox3.Text + "' where password = '" + textBox1.Text + "'", con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        label1.ForeColor = System.Drawing.Color.Green;
                        label1.Text = "Your Password Is Successfully Updated....";
                    }                  
                }
                else
                {
                    label1.ForeColor = System.Drawing.Color.Red;
                    label1.Text = "Your Password Is Not Update Please Try Again....";
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 obj1 = new Form1();
            obj1.ShowDialog();
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}
