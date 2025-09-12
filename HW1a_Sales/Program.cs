// HW1a Sales Total

// Your Name:
// Did you seek help ? If yes, specify the helper or web link here: 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1a_Sales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double TAX_RATE = 0.085;


            Console.WriteLine("What is the product name of the item you are purchasing");
            string productName = Console.ReadLine();

            Console.WriteLine("How many" + productName + "s do you want to buy");
            int quantity = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is the price for each" + productName + "?");
            double price = Convert.ToDouble(Console.ReadLine());   

            double subtotal = quantity * price;
            double salesTax = subtotal * TAX_RATE;
            double total = subtotal + salesTax;

            Console.WriteLine("Your subtotal for your bill is " + subtotal.ToString("C2"));
            Console.WriteLine("You sales tax for your bill is " + total.ToString("C2"));
            Console.WriteLine("Your total for your bill is " + total.ToString("C2"));



        }
    }
}
