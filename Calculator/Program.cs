using Calculator.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int num01;
            int num02;
            Calculation obj = new Calculation();

            //New Logic.
            Console.WriteLine("Enter the First value to be divided");
            num01 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the Secound value to divided by");
            num02 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The Result is: " + obj.Divide(num01, num02));
            Console.ReadLine();

            // Logic For Addition.
            Console.WriteLine("Enter the First value to be Added");
            num01 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the Secound value to Added ");
            num02 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The Result is: " + obj.Add(num01, num02));
            Console.ReadLine();

            // Losic For substraction.
            Console.WriteLine("Enter the First value to be Subtacted");
            num01 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the Secound value to Subtracted");
            num02 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The Result is: " + obj.Subtract(num01, num02));
            Console.ReadLine();

            // Logic For multiplication.
            Console.WriteLine("Enter the First value to be Multiplied");
            num01 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the Secound value to Multiplied ");
            num02 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The Result is: " + obj.Multiply(num01, num02));
            Console.ReadLine();




            //OLd Logic.
            //Console.WriteLine("Enter the First value to be divided");
            //num01 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("enter the Secound value to divided by");
            //num02 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("The Result is: " + (num01 / num02));
            //Console.ReadLine();

            //// Logic For Addition.
            //Console.WriteLine("Enter the First value to be Added");
            //num01 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("enter the Secound value to Added ");
            //num02 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("The Result is: " + (num01 + num02));
            //Console.ReadLine();

            //// Losic For substraction.
            //Console.WriteLine("Enter the First value to be Subtacted");
            //num01 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("enter the Secound value to Subtracted");
            //num02 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("The Result is: " + (num01 - num02));
            ////Console.ReadLine();

            //// Logic For multiplication.
            //Console.WriteLine("Enter the First value to be Multiplied");
            //num01 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("enter the Secound value to Multiplied ");
            //num02 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("The Result is: " + (num01 * num02));
            //Console.ReadLine();

        }
    }
}
