using System;

namespace HELLO_WORLD_5
{
    class Program 
    {
        static void Main (string []args)
        {
            int metro;
            int centimetro;
            Console.WriteLine("Digite o valor em metros");
            metro = int.Parse(Console.ReadLine());
            centimetro = (metro * 100);
            Console.WriteLine ("O valor em centímetros é " + centimetro +"cm");
            
        }
    }
}