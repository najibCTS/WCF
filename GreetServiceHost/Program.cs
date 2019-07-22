using System;
using System.ServiceModel;

namespace GreetServiceHost
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(GreetService.Service1)))
            {
                host.Open();

                Console.WriteLine("Service up and running at:");
                foreach (var ea in host.Description.Endpoints)
                {
                    Console.WriteLine(ea.Address);
                }

                Console.ReadLine();
                host.Close();
            }
        }
    }
}
