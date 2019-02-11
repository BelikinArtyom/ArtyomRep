using System;

namespace homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Zadanie4();
            Console.ReadKey();
        }

        private static void Zadanie4()
        {
            Console.WriteLine("Provide first string");
            string string1 = Console.ReadLine();

            Console.WriteLine("Provide second string");
            string string2 = Console.ReadLine();

            Console.WriteLine("Provide only one symbol");
            char symbol = Char.Parse(Console.ReadLine());

            string resultOfConcat = String.Concat(string1, string2);
            Console.WriteLine("Concatination result: {0}", resultOfConcat);

            int result = resultOfConcat.LastIndexOf(symbol);

            Console.WriteLine($"Index of {symbol} in {resultOfConcat} : {result}");
        }
    }
}