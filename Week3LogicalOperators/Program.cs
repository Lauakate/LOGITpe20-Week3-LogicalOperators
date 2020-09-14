using System;

namespace Week3LogicalOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Login form
             * login: admin
             * password: pass1234
            */
            string login;
            string password;
            Console.WriteLine("Login: ");
            login = Console.ReadLine();
            Console.WriteLine("Password: ");
            password = Console.ReadLine();

            if ((login == "admin") && (password == "pass1234"))
            {
                Console.WriteLine("Welcome");
            }
            else if ((login == "admin") && (password != "pass1234"))
            {
                Console.WriteLine("Invalid password");
            }
            else if ((login != "admin") && (password == "pass1234"))
            {
                Console.WriteLine("Invalid username");
            }
            else
            {
                Console.WriteLine("Invalid credentials");
            }



            



        }
    }
}
