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
    public partial class FinalCheckout : Form
    {
        public FinalCheckout()
        {
            InitializeComponent();
            this.richTextBox1.Text = ListFunctions.FinalCheckoutWriter(Program.shoppingList);
        }

        private void Return_Click(object sender, EventArgs e)
        {
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(ThreadProc));
            t.Start();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(ThreadProc2));
            t.Start();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(ThreadProc3));
            t.Start();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(ThreadProc4));
            t.Start();
            this.Close();
        }

        public static void ThreadProc()
        {
            Application.Run(new Cart());
        }
        public static void ThreadProc2()
        {
            Application.Run(new Cash());
        }
        public static void ThreadProc3()
        {
            Application.Run(new Credit());
        }
        public static void ThreadProc4()
        {
            Application.Run(new Check());
        }
    }
}
