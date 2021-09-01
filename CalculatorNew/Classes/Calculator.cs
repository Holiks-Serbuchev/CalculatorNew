using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorNew.Classes
{
    public class Calculator
    {
        List<string> commands = new List<string>() { "Select option:", "1. Addition", "2. Subtraction", "3. Multiplication", "4. Division" };
        double firstNum, secondNum = 0;
        public Calculator(double firstValue, double secondValue)
        {
            firstNum = firstValue;
            secondNum = secondValue;
        }
        public double Operation(double operation)
        {
            double result = 0;
            if (operation == 1)
                result = firstNum + secondNum;
            else if (operation == 2)
                result = firstNum - secondNum;
            else if (operation == 3)
                result = firstNum * secondNum;
            else if (operation == 4)
                result = firstNum / secondNum;
            else
                Console.WriteLine("Incorrect value!");
            return result;
        }
        public void PrintCommands()
        {
            foreach (var item in commands)
                Console.WriteLine(item);
        }
        public void EndPrintCommands(out bool saveNumber)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            bool check = false;
            Console.WriteLine("1. Continue the program and clear the values");
            Console.WriteLine("2. Continue working with number");
            Console.WriteLine("3. Exit");
            string value = Console.ReadLine();
            if (value == "3")
                Environment.Exit(1);
            else if (value == "2")
                check = true;
            saveNumber = check;
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
