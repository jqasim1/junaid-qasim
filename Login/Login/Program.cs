using System;

namespace Login
{
    class MainClass
    {
        static string username;
        static string password;

        public static void Main(string[] args)
        {
            Register();
            Login();
        }

        public static void Register()
        {
            Console.WriteLine("Please create a username");
            username = Console.ReadLine();
            Console.WriteLine("Please create a password");
            password = Console.ReadLine();
            Console.WriteLine("Registration Complete!");
            Console.WriteLine("-----------------------------------");

        }

        public static void Login()
        {
                Console.WriteLine("Please enter your username");
                if (username == Console.ReadLine())
                {
                    Console.WriteLine("Please enter your password");
                    if (password == Console.ReadLine())
                    {
                        Console.WriteLine("Login completed. Welcome back!");
                    }
                    else
                    {
                        Console.WriteLine("Wrong password");
                    }
                }
                else
                {
                    Console.WriteLine("Wrong username");
                }
        }
    }
}
