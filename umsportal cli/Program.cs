using System;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
