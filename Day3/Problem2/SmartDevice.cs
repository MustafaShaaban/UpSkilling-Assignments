using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3.Problem2
{
    internal class SmartDevice : IPrinter, IScanner, IFax
    {
        public void Print(string doc)
        {
            Console.WriteLine($"Printing: {doc}");
        }

        public void Scan(string doc)
        {
            Console.WriteLine($"Scanning: {doc}");
        }

        public void Fax(string doc, string number)
        {
            Console.WriteLine($"Sending Fax: {doc} to number: {number}");
        }
    }
}
