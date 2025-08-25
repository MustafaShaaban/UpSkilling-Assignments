using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3.Problem5
{
    internal class Copier : OfficeMachine
    {
        public Copier(string modelName) : base(modelName)
        {
            Console.WriteLine($"Copier Model: {modelName} is ready to use.");
        }

        public override void Start()
        {
            Console.WriteLine("Copier is starting up...");
        }
    }
}
