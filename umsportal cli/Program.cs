using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace social_cl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME TO SOCIAL CLI");
            Console.WriteLine("Please login");
            Console.Write("Username : ");
            string username = Console.ReadLine();
            Console.Write("Password: ");
            string password = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Loading....");
            if(username == "admin" || password == "admin")
            {
                Console.WriteLine("logged in successful ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Wellcome SOCIAL CLI");
                Console.WriteLine("Username : " + username);
                Console.WriteLine("Password : " + username);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("😐 Loging failed !!!!");
            }
            //REQUESTINGI FOR LOGING
            Console.ReadKey();
        }
    }
}
