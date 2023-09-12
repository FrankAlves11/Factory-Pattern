using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class VehicleFactory
    {
        public IVehicles CreateVehicle(string userInput)
        {
            switch (userInput.ToLower())
            {
                case "car":
                    return new Car() { Color = "Black", IsDriveable = true };
                    break;
                case "motorcycle":
                    return new Motorcycle();                 
                default:
                    return new Car();


            }
        }
    }
}
