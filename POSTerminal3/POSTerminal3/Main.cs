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

namespace POSTerminal3
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\TEVERTS\source\repos\POSTerminal3\POSTerminal3\Resources\Welcome.wav");
            player.Play();
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(ThreadProc));
            t.Start();
            this.Close();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        public static void ThreadProc()
        {
            Application.Run(new StoreMain());
        }
    }
}
