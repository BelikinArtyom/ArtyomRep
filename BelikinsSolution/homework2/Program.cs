using System;
using System.ComponentModel;
using System.Runtime.Remoting.Messaging;

namespace homework
{
    class Program
    {
        private const int MoreThanByte = 256;


        static void Main(string[] args)
        {
            Zadanie3();
            Console.ReadKey();

        }

        private static void Zadanie3()
        {
            Console.WriteLine("Provide first string");
            string string1 = string.Format(Console.ReadLine()).ToLower();

            Console.WriteLine("Provide second string");
            string string2 = string.Format(Console.ReadLine()).ToLower();

            Console.WriteLine("Provide third string");
            string string3 = string.Format(Console.ReadLine()).ToLower();

            bool firstStringStartsWithString2 = string1.StartsWith(string2);
            Console.WriteLine("First string starts from second string: {0}", firstStringStartsWithString2);

            bool firstStringEndsWithString3 = string1.EndsWith(string3);
            Console.WriteLine("First string ends with third string: {0}", firstStringEndsWithString3);
        }
    }
}