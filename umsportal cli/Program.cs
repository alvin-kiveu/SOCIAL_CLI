using System;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MikrotikDotNet;
using System.Net.NetworkInformation;

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
                string hostName = Dns.GetHostName(); // Retrive the Name of HOST
                Console.WriteLine(hostName);
                // Get the IP
                string myIP = Dns.GetHostByName(hostName).AddressList[0].ToString();
                Console.WriteLine("IPv4 Address :" + myIP);
                    NetworkInterface[] adapters  = NetworkInterface.GetAllNetworkInterfaces();
                    foreach (NetworkInterface adapter in adapters)
                    {
                        IPInterfaceProperties adapterProperties = adapter.GetIPProperties();
                        GatewayIPAddressInformationCollection addresses = adapterProperties.GatewayAddresses;
                        if (addresses.Count >0)
                        {
                            Console.WriteLine(adapter.Description);
                            foreach (GatewayIPAddressInformation address in addresses)
                            {
                            Console.WriteLine("Default Gateway : " + address.Address.ToString());
                        }
                            Console.WriteLine();
                        }
                    }
                string resultName;
                resultName = Environment.UserDomainName;
                Console.WriteLine("PC name: " + resultName);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Success");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Would you like to login to MIKROTIK yes OR no ?");
                string ans = Console.ReadLine();
                if(ans == "yes")
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("Mikrotik Ip : ");
                    string mikrotikip = Console.ReadLine();
                    Console.Write("login : ");
                    string login  = Console.ReadLine();
                    Console.Write("Password: ");
                    string mikrotipassword = Console.ReadLine();
                    using (var conn = new MKConnection(mikrotikip, login, mikrotipassword))
                    {
                        conn.Open();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Mikrotik login Success ");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine("Git repo : https://github.com/janmohammadi/MikrotikDotNet.git");

                    }
                   
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Thank you for using our cli");
                }

                Console.ReadKey();
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
