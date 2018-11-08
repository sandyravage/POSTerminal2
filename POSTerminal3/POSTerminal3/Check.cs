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
    public partial class Check : Form
    {
        public static string CheckNumber;
        public static string AccountNumber;
        public static string RoutingNumber;

        public Check()
        {
            InitializeComponent();
        }

        private void Return_Click(object sender, EventArgs e)
        {
            CheckNumber = "";
            AccountNumber = "";
            RoutingNumber = "";
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(ThreadProc));
            t.Start();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CheckChecker())
            {
                MessageBox.Show("Thank you for your payment.");
                System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(ThreadProc2));
                t.Start();
                this.Close();
            }
        }

        public bool CheckChecker()
        {
            string subnumber = textBox5.Text;
            string subaccount = textBox6.Text;
            string subrouting = textBox2.Text;
            int count = 0;
            if (!Regex.IsMatch(subnumber, @"^[0-9]+$"))
            {
                MessageBox.Show("Invalid check number!");
                textBox5.Clear();
                count++;
            }
            if (!Regex.IsMatch(subaccount, @"^[0-9]+$"))
            {
                MessageBox.Show("Invalid account number!");
                textBox6.Clear();
                count++;
            }
            if (!Regex.IsMatch(subrouting, @"^[0-9]+"))
            {
                MessageBox.Show("Invalid routing number!");
                textBox2.Clear();
                count++;
            }
            if (count > 0)
            {
                return false;
            }
            CheckNumber = subnumber;
            AccountNumber = subaccount;
            RoutingNumber = subrouting;
            return true;
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
