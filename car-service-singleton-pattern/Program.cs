using car_service_singleton_pattern;

internal class Program
{
    private static void Main(string[] args)
    {
        CarService carService1 = CarService.GetCarService();
        CarService carService2 = CarService.GetCarService();
        carService1.Cars.Add("Dacia");
        Console.WriteLine(carService2.Cars[0]);
    }
}