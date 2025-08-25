using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3.Problem3
{
    internal class ServiceMachine : IMaintenance
    {
        public void PowerOn()
        {
            Console.WriteLine("Device is now powered on.");
        }

        public void SelfCheck()
        {
            Console.WriteLine("Running diagnostics...");
        }

        public void PowerOff()
        {
            Console.WriteLine("Device is now powered off.");
        }
    }
}
