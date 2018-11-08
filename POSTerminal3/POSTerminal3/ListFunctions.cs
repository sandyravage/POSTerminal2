using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Threading;

namespace POSTerminal3
{
    class ListFunctions
    {
        public static Product[] CheckListArrayMaker(List<Product> list)
        {
            Product[] newlist = new Product[list.Count];
            for (int i = 0; i < list.Count; i++)
            {
                newlist[i] = list[i];
            }
            return newlist;
        }

        public static string DescriptionWriter(int input, List<Product> products)
        {
            input = input - 1;
            return products[input].DescriptionWriter();
        }

        public static string FinalCheckoutWriter(List<Product> ShoppingList)
        {
            string str = "";
            double sum = 0;
            foreach (var product in ShoppingList)
            {
                str += product.FinalCheckoutWriter();
                sum += product.GetQuantity() * product.GetPrice();
            }
            str += $"\nSubtotal: ${sum}" +
                $"\nTax: ${sum * .06:0.00}" +
                $"\nTotal: ${sum * .06 + sum:0.00}";
            return str;
        }

        public static void RemoveFromList(ref List<Product> ShoppingList, ref CheckedListBox checkedListBox)
        {
            if (ShoppingList.Count == 0)
            {
                MessageBox.Show("No items to remove!");
            }
            else
            {
                for (int i = 0; i < checkedListBox.Items.Count; i++)
                {
                    if (checkedListBox.GetItemChecked(i))
                    {
                        ShoppingList.RemoveAt(i);
                        checkedListBox.Items.RemoveAt(i);
                    }
                }
                MessageBox.Show("Removed item(s) from cart!");
            }
        }

        public static double GetSumOfShoppingList(List<Product> ShoppingList)
        {
            double sum = 0;
            foreach (var product in ShoppingList)
            {
                sum += product.GetQuantity() * product.GetPrice();
            }
            return sum += sum*0.06;
        }

        public static string ReceiptWriter(List<Product> ShoppingList)
        {
            string str = "";
            double sum = 0;
            foreach (var product in ShoppingList)
            {
                str += product.FinalCheckoutWriter();
                sum += product.GetQuantity() * product.GetPrice();
            }
            str += $"\nSubtotal: ${sum}" +
                $"\nTax: ${sum * .06:0.00}" +
                $"\nTotal: ${sum * .06 + sum:0.00}" +
                $"\n---Payment Info---" +
                $"\n{FinalStringPrinter()}";
            return str;
        }

        public static string FinalStringPrinter()
        {
            if (Cash.cash != 0)
            {
                return $"Payment Type: Cash" +
                    $"\nCash Paid: ${Cash.cash:0.00}" +
                    $"\nChange: ${Cash.change:0.00}";
            }
            else if (!string.IsNullOrEmpty(Credit.CardNumber))
            {
                return $"Payment Type: Credit" +
                    $"\nCard Number: {Credit.CardNumber}" +
                    $"\nExpiration Date: {Credit.ExpirationDate}" +
                    $"\nCVV: {Credit.CVV}";
            }
            else
            {
                return $"Payment Type: Check" +
                    $"\nCheck Number: {Check.CheckNumber}" +
                    $"\nAccount Number: {Check.AccountNumber}" +
                    $"\nRouting Number: {Check.RoutingNumber}";
            }
        }
            public static void ShoppingListAdder(ref List<TextBox> textBoxes, ref List<Product> shoppingList, List<Product> products)
            {
            int count = 0;
                while(count < products.Count)
                {
                    if (Regex.IsMatch(textBoxes[count].Text, @"^[0-9]+$") && textBoxes[count].Text != "0")
                    {
                        products[count].SetQuantity(int.Parse(textBoxes[count].Text));
                        shoppingList.Add(products[count]);
                    }
                    textBoxes[count].Clear();

                count++;
                }
            count = 0;
            MessageBox.Show("Added to cart!");
            return;
            }
    }
}

