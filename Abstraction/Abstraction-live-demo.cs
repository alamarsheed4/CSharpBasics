namespace VehicleConfigurationSystem
{
    abstract class Vehicle
    {
        public string? FuelType {get;set;}
        public int? Capacity {get;set;}
        public abstract void Start();
        public abstract void Engine();

        public void ShowDetails()
        {
            Console.WriteLine($"Fuel Type: {FuelType}");
            Console.WriteLine($"Capacity: {Capacity} Passengers" );
        }
    }

    class Car : Vehicle
    {
        public override void Start()
        {
            Console.WriteLine("Car is Starting with a key ignition");
        }

        public override void Engine()
        {
            Console.WriteLine("Car Engine is a 4-cylinder petrol engine.");
        }
    }
    class Bike : Vehicle
    {
         public override void Start()
        {
            Console.WriteLine("Bike is Starting with a self-start or kick-start.");
        }

        public override void Engine()
        {
            Console.WriteLine("Bike Engine is a 2-stroke diesel engine.");
        }
    }
    class Program
    {
        public static void Main()
        {
            Vehicle  car = new Car();
            car.FuelType = "Petrol";
            car.Capacity = 5;
            car.ShowDetails();
            car.Start();
            car.Engine();

        }

    }
}