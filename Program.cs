// See https://aka.ms/new-console-template for more information


namespace ClassExercise {
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
    }
    class Program {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            car1.Make = "Toyota";
            car1.Model = "Yaris";
            car1.Year = 2008;
            Console.WriteLine($"Your car is a {car1.Make} {car1.Model}");
        }
    }

}
