using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_DWAnalytics_Consumer
{
    class Program
    {
        static void Main(string[] args)
        {
            Service1Client DW_Analytics_Service = new Service1Client();
            Console.WriteLine(DW_Analytics_Service.WelcomeMessage("Shantel"));
            Console.ReadLine();
        }
    }
}
