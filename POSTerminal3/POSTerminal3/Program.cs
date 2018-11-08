using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace POSTerminal3
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static List<Product> products = new List<Product>();
        public static List<Product> shoppingList = new List<Product>();
        public static string fileName = @"C:\Users\TEVERTS\source\repos\POSTerminal3\products.txt";
       
        [STAThread]
        static void Main()
        {
            ListAdder(FileReader(fileName), ref products);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
            
        }

        public static string[] FileReader(string fileName)
        {
            using (StreamReader reader = new StreamReader(fileName))
            {
                string text = reader.ReadToEnd();
                string[] textarr = text.Split(',');
                return textarr;
            }
        }

        public static void ListAdder(string[] textarr, ref List<Product> Products)
        {
            for (int i = 0; i < textarr.Length; i += 4)
            {
                Products.Add(new Product(textarr[i], textarr[i + 1], textarr[i + 2], double.Parse(textarr[i + 3])));
            }
        }

    }
}
