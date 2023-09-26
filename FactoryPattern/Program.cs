namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What type of vehicle do you want to make? Car or Motorcycle?!?");
            string userInput = Console.ReadLine();

          
            IVehicles myVehicle = VehicleFactory.CreateVehicle(userInput);

            myVehicle.Drive();
       
                    
            Console.WriteLine("Lets make another vehicle");
            userInput = Console.ReadLine();


            
            IVehicles myVehicle2 = VehicleFactory.CreateVehicle(userInput);
            myVehicle2.Drive();


        }
        
    }
}
