namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What type of vehicle do you want to make? Car or Motorcycle?!?");
            string userInput = Console.ReadLine();

            VehicleFactory factory = new VehicleFactory();
            IVehicles myVehicle = factory.CreateVehicle(userInput);

            myVehicle.Drive();
       
                    
            Console.WriteLine("Lets make another vehicle");
            userInput = Console.ReadLine();


            VehicleFactory factory2 = new VehicleFactory();
            IVehicles myVehicle2 = factory2.CreateVehicle(userInput);
            myVehicle2.Drive();


        }
        
    }
}
