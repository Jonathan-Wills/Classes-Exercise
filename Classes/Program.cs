namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Make = "Buick";
            myCar.Model = "Regal";
            myCar.Year = 1996;

            var carList = new List<Car>() { myCar};

            foreach (var vehicle in carList)
            {
                Console.WriteLine($"{vehicle.Make} {vehicle.Model} {vehicle.Year}")
            }
        }
    }
}