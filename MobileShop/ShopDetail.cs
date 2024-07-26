using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileShop
{
    public partial class ShopDetail : Form
    {
        public ShopDetail()
        {
            InitializeComponent();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            ShopDetail obj1 = new ShopDetail();
            obj1.ShowDialog();
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void ShopDetail_Load(object sender, EventArgs e)
        {
            label7.Text = DateTime.Now.ToLongTimeString();
            label8.Text = DateTime.Now.ToLongDateString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserAccount obj2 = new UserAccount();
            obj2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Expenses obj3 = new Expenses();
            obj3.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            UseWatchRecord obj4 = new UseWatchRecord();
            obj4.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            BillRecord obj5 = new BillRecord();
            obj5.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Legger obj6 = new Legger();
            obj6.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Invoice obj7 = new Invoice();
            obj7.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            PaymentRecord obj8 = new PaymentRecord();
            obj8.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddSupplier obj9 = new AddSupplier();
            obj9.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            OwnerLogin obj10 = new OwnerLogin();
            obj10.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            OwnerLogin obj11 = new OwnerLogin();
            obj11.ShowDialog();
        }
    }
}
