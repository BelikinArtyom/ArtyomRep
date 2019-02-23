using System;

namespace Authentification
{
    class Program
    {
        static void Main()
        {
            int counter = 0;
            string login;
            string password;

            do
            {
                Console.WriteLine("Please provide login");
                login = Console.ReadLine();

                Console.WriteLine("Please provide password");
                password = Console.ReadLine();

                if (login != ("Admin") && password != ("qwerty"))
                {
                    Console.WriteLine("Incorrect credentials");
                    }
                else
                {
                    Console.WriteLine("Greetins Admin");
                    Console.ReadKey();
                    break;
                }

                counter++;
            }
            while (counter < 3);

            if (counter == 3)
            {
                Console.WriteLine("You have exceeded maximum number of attempts");
                Console.ReadKey();
            }

        }
    }
}
