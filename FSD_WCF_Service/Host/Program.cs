using System;
using System.ServiceModel;
using FSD_WCF_Service;

namespace Host
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost sh = new ServiceHost(typeof(Service1)))
            {
                sh.Open();
                Console.WriteLine("Service is Runnning......");
                Console.ReadKey();
            }
        }
    }
}
