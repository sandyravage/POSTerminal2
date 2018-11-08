using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace POSTerminal3
{
    public partial class Credit : Form
    {
        public static string CardNumber;
        public static string ExpirationDate;
        public static string CVV;
        
        public Credit()
        {
            InitializeComponent();
        }

        private void Return_Click(object sender, EventArgs e)
        {
            CardNumber = "";
            ExpirationDate = "";
            CVV = "";
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(ThreadProc));
            t.Start();
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CreditCardChecker())
            {
                MessageBox.Show("Thank you for your payment.");
                System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(ThreadProc2));
                t.Start();
                this.Close();
            }
        }

        public bool CreditCardChecker()
        {
            string subcard = $"{textBox5.Text}-{textBox6.Text}-{textBox9.Text}-{textBox10.Text}";
            string subdate = $"{textBox1.Text}/{textBox11.Text}";
            string subcvv = textBox4.Text;
            int count = 0;
            if(!Regex.IsMatch(subcard,@"^[0-9]{4}[-][0-9]{4}[-][0-9]{4}[-][0-9]{4}$"))
            {
                MessageBox.Show("Invalid card number!");
                textBox5.Clear();
                textBox6.Clear();
                textBox9.Clear();
                textBox10.Clear();
                count++;
            }
            if(!Regex.IsMatch(subdate, @"^[0-9]{2}[/][0-9]{4}$"))
            {
                MessageBox.Show("Invalid expiration date!");
                textBox1.Clear();
                textBox11.Clear();
                count++;
            }
            if(!Regex.IsMatch(subcvv, @"^[0-9]{3}$"))
            {
                MessageBox.Show("Invalid CVV!");
                textBox4.Clear();
                count++;
            }
            if (count > 0)
            {
                return false;
            }
            CardNumber = subcard;
            ExpirationDate = subdate;
            CVV = subcvv;
            return true;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        public static void ThreadProc()
        {
            Application.Run(new FinalCheckout());
        }

        public static void ThreadProc2()
        {
            Application.Run(new Final());
        }
    }
}
