using System;

namespace ChemNumberGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int minValue = 0;
            int maxValue = 0;
            int decimalPlaces = 0;
            Console.WriteLine("Hello World!");

            try
            {

                Console.WriteLine("Please enter desired number minimum value:");
                minValue = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Please enter desired number maximum value:");
                maxValue = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Please enter the desired number of decimal places: ");
                decimalPlaces = Int32.Parse(Console.ReadLine());

                //Choice made here to correct user input
                if (minValue > maxValue)
                {
                    int tmp = minValue;
                    minValue = maxValue;
                    maxValue = tmp;
                }
            }
            catch(FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }

            double result = minValue + (rnd.NextDouble() * (maxValue - minValue));

            result = Math.Round(result, decimalPlaces);

            Console.WriteLine("The random number is: " + result.ToString());

        }
    }
}
