namespace Excercise1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Running, Program!");

        Car car = new Car("Toyota", 2023, 35000.99F);
        car.PrintCarDetails();

        Console.ReadKey();
    }
}

