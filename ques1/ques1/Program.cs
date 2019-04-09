/*Name: Rajveer Kaur
task 1 = ques1*/ 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ques1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------------------------------------------------------------------");
            Console.WriteLine("-------------This program can give the result of base^exponent----------------");
            Console.WriteLine("------------------------------------------------------------------------------");

            //obtaining base value in double variable
            Console.WriteLine("Enter the value of the base: ");
            double bottom = double.Parse(Console.ReadLine());

            //obtaining exponent value in integer variable
            Console.WriteLine("Enter the value of the exponent: ");
            int expo = int.Parse(Console.ReadLine());

            
            //displaying result and message           
            Console.WriteLine($"{bottom}^{expo} = {bottom*expo}");
            Console.ReadLine();
        }
    }
}
