using System;

namespace HW1.Conditions.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string enteredStr;
            double enteredNum;
            while (true)
            {
                Console.WriteLine("Enter the number ->  (x to exit)");
                enteredStr = Console.ReadLine();

                if (enteredStr == "x")
                    break;

                if (Double.TryParse(enteredStr, out enteredNum))
                    ShowInterval(enteredNum);
            }
        }

        static void ShowInterval(double num)
        {
            if (num > 0 && num < 15)
                Console.WriteLine("Number is in interval [0, 14]");
            else if (num >= 15 && num < 35)
                Console.WriteLine("Number is in interval [15, 35]");
            else if (num >= 35 && num < 50)
                Console.WriteLine("Number is in interval [35, 50]");
            else if (num >= 50 && num < 100)
                Console.WriteLine("Number is in interval [50, 100]");
            else
                Console.WriteLine("Number is not in given intervals");
        }
    }
}
