using System;

namespace HW1.Conditions.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            double operand1 = 120d;
            double operand2 = 10d;
            string sign;

            Console.WriteLine("The numbers: {0} and {1}", operand1, operand2);
            while (true)
            {
                Console.WriteLine("Enter the operation to do (+,-,*,/)->   (x to exit)");
                sign = Console.ReadLine();

                switch (sign)
                {
                    case "+":
                        Console.WriteLine("Result {0}", operand1 + operand2);
                        break;
                    case "-":
                        Console.WriteLine("Result {0}", operand1 - operand2);
                        break;
                    case "*":
                        Console.WriteLine("Result {0}", operand1 * operand2);
                        break;
                    case "/":
                        if (operand2 == 0)
                            Console.WriteLine("Division is impossible");
                        else
                            Console.WriteLine("Result {0}", operand1 / operand2);
                        break;
                    case "x":
                        return;
                    default:
                        Console.WriteLine("Invalid Operation!");
                        break;
                }
            }
        }
    }
}
