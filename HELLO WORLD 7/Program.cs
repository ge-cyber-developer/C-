using System;

namespace HELLO_WORLD_7
{
    class Program 
    {
        static void Main ( string [] args)
        {
            double raio;
            double pi;
            double dobro_do_raio;
            double dobro_da_area;
            Console.WriteLine("Digite o valor do raio ");
            raio = double.Parse(Console.ReadLine());
            dobro_do_raio = (raio * raio);
            pi =  (3.14);
            dobro_da_area = (2* pi * dobro_do_raio);
            Console.WriteLine("O dobro da área é "+ dobro_da_area);

        }
    }
}