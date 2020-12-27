using System;

namespace HELLO_WORLD_9
{
    class Program
    {
        static void Main ( string [] args)
        {
            double Fahrenheit;
            double Celsius;
            Console.WriteLine ("Digite a temperatura em Fahrenheit");
            Fahrenheit = double.Parse(Console.ReadLine());
            Celsius = ((5* (Fahrenheit - 32 )) / 9);
            Console.WriteLine("A temperatura em Celsius é " + Celsius);

            
        }
    }
}
