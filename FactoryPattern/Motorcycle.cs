using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class Motorcycle : IVehicles
    {
        public string Color { get; set; }
        public bool HasHandBreaks { get; set; }

        public void Drive()
        {
            Console.WriteLine("Doing a wheelie on a motorcycle");
        }

    }
}
