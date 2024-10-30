using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashApp
{
    public partial class Form1 : Form
    {
        private String Items;
        private double discount, payment, price, change, ConvDiscount, DiscuntPrice, amount, quantity, result;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void ComputeBT_Click(object sender, EventArgs e)
        {
            string invalidMessage = "Please complete your data.";
            string inputErrorMessage = "Input error: Please enter valid numeric values.";
            Items = ItemsTB.Text;

            if (!double.TryParse(PriceTB.Text, out price))
            {
                MessageBox.Show(inputErrorMessage);
                return;
            }

            if (!double.TryParse(QuantityTB.Text, out quantity))
            {
                MessageBox.Show(inputErrorMessage);
                return;
            }

            if (!double.TryParse(DiscuntTB.Text, out discount))
            {
                MessageBox.Show(inputErrorMessage);
                return;
            }

            if (string.IsNullOrWhiteSpace(Items))
            {
                MessageBox.Show(invalidMessage);
                return;
            }

            ConvDiscount = discount * 0.01;
            DiscuntPrice = price - (price * ConvDiscount);
            amount = DiscuntPrice * quantity;
            AmountLB.Text = amount.ToString("F2");
        }

        private void SumbitBT_Click(object sender, EventArgs e)
        {
            string invalidpament = "MAG BAYAD KA!!";
            string invalidamount = "KULOANG PAGBAYAD MO";
            string inputErrorMessage = "Input error: Please enter valid numeric values.";
            if (!double.TryParse(PaymentTB.Text, out payment))
            {
                MessageBox.Show(inputErrorMessage);
                return;
            }

            if (string.IsNullOrWhiteSpace(price.ToString()))
            {
                MessageBox.Show(invalidpament);
                return;
            }
            payment = double.Parse(PaymentTB.Text);
            change = payment - amount;
            if (change < 0)
            {
                MessageBox.Show(invalidamount);
                return;
            }

            ChangeLB.Text = change.ToString("F2");
        }
    }
}
