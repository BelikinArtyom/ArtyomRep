using System;

namespace Authentification
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("Please provide login");
            string login = Console.ReadLine();

            Console.WriteLine("Please provide password");
            string password = Console.ReadLine();

            if (login != ("Admin") && password != ("qwerty"))
            {
                Console.WriteLine("Incorrect credentials");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Greetins Admin");
                Console.ReadKey();
            }
        }
    }
}
