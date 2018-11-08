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
    public partial class Cart : Form
    {
        public Cart()
        {
            InitializeComponent();
            if (Program.shoppingList.Count == 0)
            {
                this.checkedListBox1.Items.Add("Cart Empty!");
            }
            else
            {
                this.checkedListBox1.Items.AddRange(ListFunctions.CheckListArrayMaker(Program.shoppingList));
            }
        }

        private void Return_Click(object sender, EventArgs e)
        {
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(ThreadProc));
            t.Start();
            this.Close();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.Items[0].ToString() != "Cart Empty!")
            {
                System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(ThreadProc2));
                t.Start();
                this.Close();
            }
            else
            {
                MessageBox.Show("No items to checkout!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListFunctions.RemoveFromList(ref Program.shoppingList, ref checkedListBox1);
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public static void ThreadProc()
        {
            Application.Run(new StoreMain());
        }

        public static void ThreadProc2()
        {
            Application.Run(new FinalCheckout());
        }
    }
}
