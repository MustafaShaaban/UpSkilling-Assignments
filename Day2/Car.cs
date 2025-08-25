using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    internal class Car
    {
        public string? Make { get; set; }
        public string? Model { get; set; }
        public int Year { get; set; }
        public int Mileage { get; private set; }
        public int Age { get => DateTime.Now.Year - Year; }

        public void Drive(int distance)
        {
            if (distance > 0)
            {
                Mileage += distance;
            }
            else
            {
                Console.WriteLine("Distance must be positive.");
            }
        }


    }
}
