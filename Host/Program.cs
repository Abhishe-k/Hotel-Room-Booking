using HotelBookingService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;

using System.Threading.Tasks;

namespace Host
{
    class Program
    {
        static void Main(string[] args)
        {
            Type t = typeof(Service1);
            Uri http = new Uri("http://localhost:8000/Service1");
            ServiceHost sh = new ServiceHost(t,http);
            sh.Open();
            Console.WriteLine("Published");
            Console.WriteLine("Press any Key to close ");
            Console.ReadKey();
            sh.Close();
        }
    }
}
