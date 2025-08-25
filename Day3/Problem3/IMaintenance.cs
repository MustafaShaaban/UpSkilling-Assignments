using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3.Problem3
{
    internal interface IMaintenance : IDevice
    {
        void SelfCheck();
    }
}
