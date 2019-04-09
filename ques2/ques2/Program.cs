/*NAME:RAJVEER KAUR
 TASK :ques 2 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ques2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("-----This program will give the sum total of 5 prices-------");
            Console.WriteLine("------------------------------------------------------------");
            double total = 0;//initialising double variable
            for (int i = 1; i <= 5; i++)
            { Console.WriteLine($"Enter the price of item {i}: ");
                total += double.Parse(Console.ReadLine());
                //displaying the total of all items
            }
            //representing the message and total
            Console.WriteLine($"The total of those items is ${total}");
            Console.ReadLine();
        }
    }
}
