using System;

namespace HELLO_WORLD_6
{
    class PROGRAM
    {
        static void Main ( string [] args)
        {
            int raio;
            int quadrado_do_raio;
            double pi;
            double area;
            Console.WriteLine("Digite o raio do seu círculo");
            raio = int.Parse(Console.ReadLine());
            pi=(3.14);  
            quadrado_do_raio = (raio*raio);
            area = pi* quadrado_do_raio;
            Console.WriteLine("A área do quadrado é " + area);


        }
    }
}