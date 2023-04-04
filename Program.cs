using System;

namespace UnitConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            double input;
            string fromUnit, toUnit;

            // Wprowadzenie wartości i jednostek do konwersji
            Console.WriteLine("Wprowadź wartość do konwersji:");
            input = double.Parse(Console.ReadLine());

            Console.WriteLine("Wprowadź jednostkę wejściową:");
            fromUnit = Console.ReadLine().ToLower();

            Console.WriteLine("Wprowadź jednostkę wyjściową:");
            toUnit = Console.ReadLine().ToLower();

            // Konwersja jednostek
            double output = 0;
            switch (fromUnit)
            {
                case "m":
                    if (toUnit == "cm")
                        output = input * 100;
                    else if (toUnit == "km")
                        output = input / 1000;
                    else
                        output = input;
                    break;

                case "cm":
                    if (toUnit == "m")
                        output = input / 100;
                    else if (toUnit == "km")
                        output = input / 100000;
                    else
                        output = input;
                    break;

                case "km":
                    if (toUnit == "m")
                        output = input * 1000;
                    else if (toUnit == "cm")
                        output = input * 100000;
                    else
                        output = input;
                    break;

                default:
                    Console.WriteLine("Nieznana jednostka wejściowa");
                    break;
            }

            // Wyświetlenie wyniku
            Console.WriteLine("{0} {1} = {2} {3}", input, fromUnit, output, toUnit);
        }
    }
}
