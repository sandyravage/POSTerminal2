using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Text.RegularExpressions;

namespace POSTerminal3
{
    public partial class ProductList : Form
    {
        private static int clicks1 = 0;
        private static int clicks2 = 0;
        private static int clicks3 = 0;
        private static int clicks4 = 0;
        private static int clicks5 = 0;
        private static int clicks6 = 0;
        private static int clicks7 = 0;
        private static int clicks8 = 0;
        private static int clicks9 = 0;
        private static int clicks10 = 0;
        private static int clicks11 = 0;
        private static int clicks12 = 0;
        private static int clicks13 = 0;
        private static int clicks14 = 0;
        public static List<TextBox> textboxes = new List<TextBox>();

        public ProductList()
        {
            InitializeComponent();
            TextBoxAdder();
           
        }

        private void TextBoxAdder()
        {
            textboxes.Add(textBox16);
            textboxes.Add(textBox17);
            textboxes.Add(textBox18);
            textboxes.Add(textBox19);
            textboxes.Add(textBox20);
            textboxes.Add(textBox21);
            textboxes.Add(textBox22);
            textboxes.Add(textBox23);
            textboxes.Add(textBox24);
            textboxes.Add(textBox25);
            textboxes.Add(textBox26);
            textboxes.Add(textBox27);
            textboxes.Add(textBox28);
            textboxes.Add(textBox29);
        }

        private void Return_Click(object sender, EventArgs e)
        {
          
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(ThreadProc));
            t.Start();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clicks1++;
            SoundPlayer player = PlayerMaker.MakeSoundPlayer("1");
            if(clicks1 > 2)
            {
                clicks1 = 1;
            }
            switch(clicks1)
            {
                case 1:
                    player.Play();
                    break;
                case 2:
                    player.Stop();
                    break;
                default:
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clicks2++;
            SoundPlayer player = PlayerMaker.MakeSoundPlayer("2");
            if (clicks2 > 2)
            {
                clicks2 = 1;
            }
            switch (clicks2)
            {
                case 1:
                    player.Play();
                    break;
                case 2:
                    player.Stop();
                    break;
                default:
                    break;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            clicks3++;
            SoundPlayer player = PlayerMaker.MakeSoundPlayer("3");
            if (clicks3 > 2)
            {
                clicks3 = 1;
            }
            switch (clicks3)
            {
                case 1:
                    player.Play();
                    break;
                case 2:
                    player.Stop();
                    break;
                default:
                    break;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            clicks4++;
            SoundPlayer player = PlayerMaker.MakeSoundPlayer("4");
            if (clicks4 > 2)
            {
                clicks4 = 1;
            }
            switch (clicks4)
            {
                case 1:
                    player.Play();
                    break;
                case 2:
                    player.Stop();
                    break;
                default:
                    break;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            clicks5++;
            SoundPlayer player = PlayerMaker.MakeSoundPlayer("5");
            if (clicks5 > 2)
            {
                clicks5 = 1;
            }
            switch (clicks5)
            {
                case 1:
                    player.Play();
                    break;
                case 2:
                    player.Stop();
                    break;
                default:
                    break;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            clicks6++;
            SoundPlayer player = PlayerMaker.MakeSoundPlayer("6");
            if (clicks6 > 2)
            {
                clicks6 = 1;
            }
            switch (clicks6)
            {
                case 1:
                    player.Play();
                    break;
                case 2:
                    player.Stop();
                    break;
                default:
                    break;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            clicks7++;
            SoundPlayer player = PlayerMaker.MakeSoundPlayer("7");
            if (clicks7 > 2)
            {
                clicks7 = 1;
            }
            switch (clicks7)
            {
                case 1:
                    player.Play();
                    break;
                case 2:
                    player.Stop();
                    break;
                default:
                    break;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            clicks8++;
            SoundPlayer player = PlayerMaker.MakeSoundPlayer("8");
            if (clicks8 > 2)
            {
                clicks8 = 1;
            }
            switch (clicks8)
            {
                case 1:
                    player.Play();
                    break;
                case 2:
                    player.Stop();
                    break;
                default:
                    break;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            clicks9++;
            SoundPlayer player = PlayerMaker.MakeSoundPlayer("9");
            if (clicks9 > 2)
            {
                clicks9 = 1;
            }
            switch (clicks9)
            {
                case 1:
                    player.Play();
                    break;
                case 2:
                    player.Stop();
                    break;
                default:
                    break;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            clicks10++;
            SoundPlayer player = PlayerMaker.MakeSoundPlayer("10");
            if (clicks10 > 2)
            {
                clicks10 = 1;
            }
            switch (clicks10)
            {
                case 1:
                    player.Play();
                    break;
                case 2:
                    player.Stop();
                    break;
                default:
                    break;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            clicks11++;
            SoundPlayer player = PlayerMaker.MakeSoundPlayer("11");
            if (clicks11 > 2)
            {
                clicks11 = 1;
            }
            switch (clicks11)
            {
                case 1:
                    player.Play();
                    break;
                case 2:
                    player.Stop();
                    break;
                default:
                    break;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            clicks12++;
            SoundPlayer player = PlayerMaker.MakeSoundPlayer("12");
            if (clicks12 > 2)
            {
                clicks12 = 1;
            }
            switch (clicks12)
            {
                case 1:
                    player.Play();
                    break;
                case 2:
                    player.Stop();
                    break;
                default:
                    break;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            clicks13++;
            SoundPlayer player = PlayerMaker.MakeSoundPlayer("13");
            if (clicks13 > 2)
            {
                clicks13 = 1;
            }
            switch (clicks13)
            {
                case 1:
                    player.Play();
                    break;
                case 2:
                    player.Stop();
                    break;
                default:
                    break;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            clicks14++;
            SoundPlayer player = PlayerMaker.MakeSoundPlayer("14");
            if (clicks14 > 2)
            {
                clicks14 = 1;
            }
            switch (clicks14)
            {
                case 1:
                    player.Play();
                    break;
                case 2:
                    player.Stop();
                    break;
                default:
                    break;
            }
        }
        
        private bool TextBoxChecker(ref List<TextBox> textBoxes, ref List<Product> shoppingList, List<Product> products)
        {
            int count = 0;
            foreach(var textbox in textBoxes)
            {
                if (string.IsNullOrWhiteSpace(textbox.Text))
                {
                    continue;
                }
                else if (!Regex.IsMatch(textbox.Text, @"^[0-9]+$") || textbox.Text == "0" )
                {
                    textbox.Clear();
                    count++;
                }
            }
            if(count > 0)
            {
                count = 0;
                MessageBox.Show("Invalid Entries! Please try again.");
                return false;
            }
            count = 0;
            return true;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textboxes.Clear();
            TextBoxAdder();
            if(TextBoxChecker(ref textboxes,ref Program.shoppingList, Program.products))
            {
         
               ListFunctions.ShoppingListAdder(ref textboxes, ref Program.shoppingList, Program.products);
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ListFunctions.DescriptionWriter(1, Program.products));
        }

        private void button17_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ListFunctions.DescriptionWriter(2, Program.products));
        }

        private void button18_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ListFunctions.DescriptionWriter(3, Program.products));
        }

        private void button19_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ListFunctions.DescriptionWriter(4, Program.products));
        }

        private void button20_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ListFunctions.DescriptionWriter(5, Program.products));
        }

        private void button21_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ListFunctions.DescriptionWriter(6, Program.products));
        }

        private void button22_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ListFunctions.DescriptionWriter(7, Program.products));
        }

        private void button23_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ListFunctions.DescriptionWriter(8, Program.products));
        }

        private void button24_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ListFunctions.DescriptionWriter(9, Program.products));
        }

        private void button25_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ListFunctions.DescriptionWriter(10, Program.products));
        }

        private void button26_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ListFunctions.DescriptionWriter(11, Program.products));
        }

        private void button27_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ListFunctions.DescriptionWriter(12, Program.products));
        }

        private void button28_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ListFunctions.DescriptionWriter(13, Program.products));
        }

        private void button29_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ListFunctions.DescriptionWriter(14, Program.products));
        }

        public static void ThreadProc()
        {
            Application.Run(new StoreMain());
        }

    }
}