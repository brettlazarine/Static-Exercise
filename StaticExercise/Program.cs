namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(TempConverter.CelsiusToFahrenheit(50));
            Console.WriteLine(TempConverter.FahrenheitToCelsius(50));

            Console.WriteLine("**********");

            var c1 = new CarLot();
            Console.WriteLine(CarLot.numberOfCars);
            var c2 = new CarLot();
            Console.WriteLine(CarLot.numberOfCars);
            var c3 = new CarLot();
            Console.WriteLine(CarLot.numberOfCars);
        }
    }
}
