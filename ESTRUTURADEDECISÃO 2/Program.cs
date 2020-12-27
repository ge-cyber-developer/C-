using System;

namespace ESTRUTURADEDECISÃO
{
    class Program 
    {
        static void Main ( string [] args )
        {
            double num;
            Console.WriteLine ("Digite um número: ");
            num = double.Parse(Console.ReadLine());
            if(num > 0)
            {
              Console.WriteLine("O número "+ num + " é positivo");
            }
            else 
            {
                Console.WriteLine("O número " + num + " é negativo");
            }
        }
    }
}
