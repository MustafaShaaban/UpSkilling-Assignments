using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3.Problem5
{
    internal abstract class OfficeMachine
    {
        private string modelName;

        protected OfficeMachine(string modelName)
        {
            this.modelName = modelName;
        }

        public void ShowModelInfo()
        {
            Console.WriteLine($"Model Info: {modelName}");
        }

        public abstract void Start();
    }
}
