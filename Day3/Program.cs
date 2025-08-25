using Day3.Problem1;
using Day3.Problem2;
using Day3.Problem3;
using Day3.Problem4;
using Day3.Problem5;
using Day3.Problem6;

namespace Day3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Problem 1
            Console.WriteLine("==================\n Problem 1: \n==================");
            SimplePrinter printer = new SimplePrinter();
            printer.Print("Invoice.pdf");
            Console.WriteLine("");
            #endregion

            #region Problem 2
            Console.WriteLine("==================\n Problem 2: \n==================");
            SmartDevice smartDevice = new SmartDevice();
            smartDevice.Print("Report.docx");
            smartDevice.Scan("Photo.jpg");
            smartDevice.Fax("Contract.pdf", "+1234567890");
            Console.WriteLine("");
            #endregion

            #region Problem 3
            Console.WriteLine("==================\n Problem 3: \n==================");
            IMaintenance serviceMachine = new ServiceMachine();
            serviceMachine.PowerOn();
            serviceMachine.SelfCheck();
            Console.WriteLine("");
            #endregion

            #region Problem 4
            Console.WriteLine("==================\n Problem 4: \n==================");
            //SecurePrinter securePrinter = new SecurePrinter();
            //securePrinter.PrintDocument("ConfidentialReport.pdf");
            Problem4.IPrinter securePrinter = new SecurePrinter();
            securePrinter.PrintDocument("ConfidentialReport.pdf");

            Console.WriteLine("");
            #endregion

            #region Problem 5
            Console.WriteLine("==================\n Problem 5: \n==================");
            Copier copier = new Copier("Xerox123");
            copier.ShowModelInfo();
            copier.Start();
            Console.WriteLine("");
            #endregion

            #region Problem 6
            Console.WriteLine("==================\n Problem 6: \n==================");
            SmartCopier smartCopier = new SmartCopier("Canon456");
            smartCopier.ShowModelInfo();
            smartCopier.PowerOn();
            smartCopier.SelfCheck();
            smartCopier.Print("Document1.pdf");
            smartCopier.Scan("Image1.jpg");

            IFax smartCopier2 = new SmartCopier("Canon500");
            smartCopier2.Fax("Contract2.pdf", "+0987654321");
            Console.WriteLine("");

            #endregion
        }
    }
}
