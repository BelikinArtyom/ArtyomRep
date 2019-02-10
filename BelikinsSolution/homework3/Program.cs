using System;
using System.ComponentModel;
using System.Runtime.Remoting.Messaging;


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

            string str = "Index of ";
            string str1 = " in ";
            string str2 = ": ";
            Console.WriteLine(str + symbol + str1+ resultOfConcat + str2 + result);

        }
    }
}