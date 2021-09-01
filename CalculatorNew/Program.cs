using CalculatorNew.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorNew
{
    class Program
    {
        static bool saveNumber = false;
        static double answer = 0;
        static void Main(string[] args)
        {
            double firstNum, secondNum;
            while (true)
            {
                if (saveNumber == false)
                {
                    Console.Clear();
                    Console.WriteLine("Enter the first number:");
                    firstNum = ConvertNumber(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("First number:" + answer);
                    firstNum = answer;
                }
                Console.WriteLine("Enter the second number:");
                secondNum = ConvertNumber(Console.ReadLine());
                Calculator calculator = new Calculator(firstNum, secondNum);
                calculator.PrintCommands();
                answer = calculator.Operation(ConvertNumber(Console.ReadLine()));
                Console.WriteLine("Answer: " + answer + "\n------------------------");
                calculator.EndPrintCommands(out saveNumber);
            }
        }
        private static double ConvertNumber(string number)
        {
            if (double.TryParse(number.Replace(".",","), out double newNum))
                return newNum;
            return 0;
        }
    }
}
