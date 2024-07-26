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
    public partial class OwnerPanel : Form
    {
        public OwnerPanel()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Banking obj1 = new Banking();
            obj1.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            ItemRecord obj2 = new ItemRecord();
            obj2.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            BankSN obj3 = new BankSN();
            obj3.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            UpdatePurchase obj4 = new UpdatePurchase();
            obj4.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            BillRecord obj5 = new BillRecord();
            obj5.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            PaymentRecord obj6 = new PaymentRecord();
            obj6.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Purchase obj7 = new Purchase();
            obj7.ShowDialog();
        }
    }
}
