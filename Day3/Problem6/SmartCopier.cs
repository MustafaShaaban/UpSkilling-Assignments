using Day3.Problem2;
using Day3.Problem3;
using Day3.Problem1;
using Day3.Problem5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3.Problem6
{
    internal class SmartCopier : OfficeMachine, Problem1.IPrinter, IScanner, IFax, IMaintenance
    {
        public SmartCopier(string modelName) : base(modelName)
        {
            Console.WriteLine($"Copier Model: {modelName}");
        }

        void IFax.Fax(string doc, string number)
        {
            Console.WriteLine($"SmartCopier faxing: {doc} to {number}");
        }

        public void PowerOn()
        {
            Console.WriteLine("SmartCopier is powered on.");
        }

        public void Print(string doc)
        {
            Console.WriteLine($"SmartCopier Printing: {doc}");
        }

        public void Scan(string doc)
        {
            Console.WriteLine($"SmartCopier scanning: {doc}");
        }

        public void SelfCheck()
        {
            Console.WriteLine("SmartCopier self-check in progress...");
        }

        public override void Start()
        {
            Console.WriteLine("SmartCopier is initializing...");
        }
    }
}
