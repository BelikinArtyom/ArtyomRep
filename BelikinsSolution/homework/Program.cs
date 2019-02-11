using System;

namespace homework
{
    class Program
    {
    static void Main(string[] args) {
        Zadanie1();
        Console.ReadKey();
    }

    private static void Zadanie1()
        {
            Console.WriteLine("Provide 'x' value");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Provide 'y' value");
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine("Provide 'z' value");
            int z = int.Parse(Console.ReadLine());

            double result1 = (x + y) * (Math.Pow(y, 2) + 1);
            Console.WriteLine("\r\nFirst expression result: {0}", result1);

            double result2 = (Math.Sqrt(y) * ((x / z) - 1));
            Console.WriteLine("\r\nSecond expression result: {0}", result2);

            double result3 = ((x * y) + (y * z)) / Math.Pow(z, 3);
            Console.WriteLine("\r\nThird expression result: {0}", result3);
        }
    }
}
