using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3.Problem4
{
    internal class SecurePrinter : IPrinter
    {
        void IPrinter.PrintDocument(string doc)
        {
            Console.WriteLine($"[SecurePrinter] Printing confidential document: {doc}");
        }
    }
}
