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
    public partial class StoreMain : Form
    {
        public StoreMain()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(ThreadProc2));
            t.Start();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Cart_Click(object sender, EventArgs e)
        {
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(ThreadProc));
            t.Start();
            this.Close();
        }

        public static void ThreadProc2()
        {
            Application.Run(new ProductList());
        }

        public static void ThreadProc()
        {
            Application.Run(new Cart());
        }
    }
}
