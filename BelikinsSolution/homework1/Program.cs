using System;
using System.Runtime.Remoting.Messaging;

namespace homework
{
    class Program
    {
        private const int MoreThanByte = 256;


        static void Main(string[] args)
        {
            Zadanie2();
            Console.ReadKey();

        }

        private static void Zadanie2()
        {
            Console.WriteLine("Provide 'x' value");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Provide 'y' value");
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine("Provide 'z' value");
            int z = int.Parse(Console.ReadLine());

            double result1 = Math.Sqrt((Math.Pow(x, 2) + Math.Pow(y, 2) + Math.Pow(z, 2)));
            Console.WriteLine("\r\nParallelepiped diagonal length: {0}", result1);
        }
    }
}