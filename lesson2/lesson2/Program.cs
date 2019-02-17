using System;

namespace Calculator
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Provide first operand");
            double firstOp = double.Parse(Console.ReadLine());

            Console.WriteLine("Provide second operand");
            double secondOp = double.Parse(Console.ReadLine());

            Console.WriteLine("Choose operation to perform");
            string symbol = Console.ReadLine();

            switch (symbol)
            {
                case "+":
                {
                    double sum = firstOp + secondOp;
                    Console.WriteLine("Result of sum: {0}", sum);
                    break;

                }
                case "-":
                {
                    double substract = firstOp - secondOp;
                    Console.WriteLine("Result of substraction: {0}", substract);
                    break;
                }
                case "/":
                {
                    double div = firstOp / secondOp;
                    Console.WriteLine("Result of division: {0}", div);
                    break;
                }
                case "*":
                {
                    double multi = firstOp * secondOp;
                    Console.WriteLine("Result of multiplication: {0}", multi);
                    break;
                }
                case "^":
                {
                    double exp = Math.Pow(firstOp, secondOp);
                    Console.WriteLine("Result of exponentiating: {0}", exp);
                    break;
                }
                default:
                {
                    Console.WriteLine("Please select one of the available operations");
                    break;
                }
            }
            Console.ReadKey();
        }

    }
}
