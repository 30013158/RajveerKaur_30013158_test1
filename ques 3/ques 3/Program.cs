/*Name : Rajveer Kaur
 Task :ques3(b)*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ques_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------------------------------------------------------------");
            Console.WriteLine("----------Can you solve the following algebraic expression: ------------");
            Console.WriteLine("----------------  2(x - 3) + x = 12  -----------------------------------");
            Console.WriteLine("------------------------------------------------------------------------");

            /* 2(x-3) + x = 12
               2x - 6 + x = 12
               3x - 6 = 12
               3x - 6 + 6 = 12 + 6
               3x = 18
               3x/3 = 18/3
                x = 6
            */

            //initialising x with correct solutiion
            int x = 6;
            
            //obtaining the guess of user
            Console.Write("Enter your guess at the value of x : ");
            int guess = int.Parse(Console.ReadLine());


            //using conditional if statement to check the guess
            if (guess == x)
            { Console.WriteLine("Genious man ! you have got the correct answer"); }
            else
            { Console.WriteLine("Sorry that guess is incorrect"); }
            Console.ReadLine();
        }
    }
}
