using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSTerminal3
{
    public partial class Cash : Form
    {
        public static double cash;
        public static double change;
        public static double sum;
        public Cash()
        {
            InitializeComponent();
            textBox2.Text = $"Enter cash amount > ${ListFunctions.GetSumOfShoppingList(Program.shoppingList):0.00}";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void FinalTransaction()
        {
            sum = ListFunctions.GetSumOfShoppingList(Program.shoppingList);
            if (double.TryParse(textBox1.Text, out cash) && cash > sum)
            {
                change = cash - sum; //add new form and finish this method
                MessageBox.Show("Thank you for your payment.");
                System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(ThreadProc2));
                t.Start();
                this.Close();
            }
            else
            {
                textBox1.Clear();
                MessageBox.Show("Invalid entry! Please try again.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FinalTransaction();
        }

        private void Return_Click(object sender, EventArgs e)
        {
            cash = 0;
            change = 0;
            sum = 0;
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(ThreadProc));
            t.Start();
            this.Close();
        }

        public static void ThreadProc()
        {
            Application.Run(new FinalCheckout());
        }

        public static void ThreadProc2()
        {
            Application.Run(new Final());
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
