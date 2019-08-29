/*Create a Visual C# Windows Console Application, name it SumOf3, that will prompt the user to enter 
 * 3 different numbers (1 is a valid input and so is 5.5).  Add all 3 numbers together and output 
 * the result displaying 3 decimal places.  Calculate a second value, where you multiply the sum of 
 * the 3 numbers by a constant value of 7.777 (hint: make a constant variable that is type double).
 * 
 * 
 */

using System;

namespace SumOf3
{
    class Program
    {
        static void Main(string[] args)
        {
            // declare variables
            double N1, N2, N3,Total1, Total2;
            const double  C = 7.777;//declare a constant
            string Msg1, Msg2, N1S, N2S, N3S;

            //inputs
            Console.WriteLine("This program will add up 3 numbers of your choice. Then it will multiply the sum of these numbers by a constant value of 7.777 and display the value");

            Console.WriteLine("Enter your first number between 1 - 1000 (decimal values are ok too)");
            N1S = Console.ReadLine();
            Console.WriteLine("Enter your second number between 1 - 1000 (decimal values are ok too)");
            N2S = Console.ReadLine();
            Console.WriteLine("Enter your third number between 1 - 1000 (decimal values are ok too)");
            N3S = Console.ReadLine();

            //process
            //convert string to double
            N1 = Convert.ToDouble(N1S);
            N2 = Convert.ToDouble(N2S);
            N3 = Convert.ToDouble(N3S);

            //do calculations
            Total1 = N1 + N2 + N3;
            Total2 = Total1 * C;
            Msg1 = "The total of your three numbers is " + Total1;
            Msg2 = "The total multiplied by constant 7.777 is " + Total2;

            //output

            Console.WriteLine(Msg1);
            Console.WriteLine(Msg2);
            Console.ReadKey();//Stopping point so the application doesn't close
        }
    }
}
