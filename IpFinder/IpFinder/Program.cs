using System;
using MaxMind.Db;
using MaxMind.GeoIP2;

namespace IP_to_LOCATION
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("\r\n█░░░█ █▀▀█ ░▀░ ▀▀█▀▀ ▀▀█▀▀ █▀▀ █▀▀▄ 　 █▀▀▄ █░░█ \r\n█▄█▄█ █▄▄▀ ▀█▀ ░░█░░ ░░█░░ █▀▀ █░░█ 　 █▀▀▄ █▄▄█ \r\n░▀░▀░ ▀░▀▀ ▀▀▀ ░░▀░░ ░░▀░░ ▀▀▀ ▀░░▀ 　 ▀▀▀░ ▄▄▄█ \r\n\r\n█▀▀ █▀▀█ █░█ █▀▀█ █▀▀█ ▀▀█▀▀ █▀▀ █▀▀ █░░█ █▀▀█ █░░█ █▀▀█ █▀▀█ █▀▀▄ ░▀░ █░░█ ░▀░ █▀▄▀█ \r\n▀▀█ █░░█ █▀▄ █▄▄▀ █▄▄█ ░░█░░ █▀▀ ▀▀█ █▀▀█ █▄▄█ █▄▄█ █▄▄▀ █▄▄█ █░░█ ▀█▀ █▄▄█ ▀█▀ █░▀░█ \r\n▀▀▀ ▀▀▀▀ ▀░▀ ▀░▀▀ ▀░░▀ ░░▀░░ ▀▀▀ ▀▀▀ ▀░░▀ ▀░░▀ ▄▄▄█ ▀░▀▀ ▀░░▀ ▀░░▀ ▀▀▀ ▄▄▄█ ▀▀▀ ▀░░░▀");
            Console.WriteLine("WELCOME TO IP_to_LOCATION");
            





            while(true){
                IpFinder();
                Console.WriteLine("Again? yes/no");
                string restartApp = Console.ReadLine();
                if(restartApp.ToLower() != "yes")
                {
                    break;
                }

            }
            

            Console.ReadLine();
        }
        static void IpFinder()
        {
            Console.Write("Enter an IP address: ");
            string ipAddress = Console.ReadLine();

            try
            {
                
                using (var reader = new DatabaseReader(@"data\GeoLite2-City.mmdb"))
                {
                    //IP'den konumu sorgula
                    var city = reader.City(ipAddress);

                    Console.WriteLine("IP Address: " + ipAddress);
                    Console.WriteLine("City: " + city.City.Name);
                    Console.WriteLine("State/Province: " + city.MostSpecificSubdivision.Name);
                    Console.WriteLine("Country: " + city.Country.Name);
                    Console.WriteLine("Latitude: " + city.Location.Latitude);
                    Console.WriteLine("Longitude: " + city.Location.Longitude);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }

        }


    }
}
