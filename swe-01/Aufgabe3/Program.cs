using System;

namespace TemperatureCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double fahrenheit, celsius;
            celsius = 0;

            fahrenheit = 9.0 / 5.0 * celsius + 32.0;
            Console.WriteLine("{0} Celsius entspricht {1} Fahrenheit", celsius, fahrenheit);

            Console.WriteLine("Celsius: ");
            celsius = Convert.ToDouble(Console.ReadLine());

            fahrenheit = 9.0 / 5.0 * celsius + 32.0;
            Console.WriteLine("Fahrenheit: {0}", fahrenheit);
        }
    }
}
