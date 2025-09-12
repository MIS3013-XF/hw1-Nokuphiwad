// HW1b Grade

// Your Name: Nokuphiwa Dlamini
// Did you seek help ? If yes, specify the helper or web link here: no

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1b_Grade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double one = 0.15;
            const double two = 0.25;
            const double three = 0.25;
            const double hw = 0.20;
            const double part = 0.15;

            Console.WriteLine("What is you name");
            string Name = Console.ReadLine();

            Console.WriteLine("What is your last name?");
            string lastname = Console.ReadLine();

            Console.WriteLine("What is your student id?");
            string id = Console.ReadLine();

            Console.WriteLine("What is your overalll percentage grade for homeworks?");
            double homework = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is your overalll percentage grade for participations?");
            double participation = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is your overalll percentage grade for exam 1?");
            double exam1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is your overalll percentage grade for exam 2?");
            double exam2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is your overalll percentage grade for exam 3?");
            double exam3 = Convert.ToDouble(Console.ReadLine());

            double homeworktotal = hw * homework;
            double participationtotal = part * participation;
            double exam1total = one * exam1;
            double exam2total = two * exam2;
            double exam3total = three * exam3;
            double total = homeworktotal + participationtotal + exam1total + exam2total + exam3total;

            Console.WriteLine(Name +" "+ lastname + " " + "(" + id + ")" + " " +  "your final grade is"  + " "+ total + "%");
            
        }
    }
}
