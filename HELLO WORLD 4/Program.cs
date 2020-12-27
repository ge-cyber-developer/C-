using System;

namespace HELLO_WORLD_4
{
    class Program
    {
        static void Main ( string [] args)
        {
            int nota1;
            int nota2;
            int nota3;
            int nota4;
            int resultado;
            Console.WriteLine("Digite sua nota do 1º semestre");
            nota1 = int.Parse (Console.ReadLine());
            Console.WriteLine ("Digite sua nota do 2º semestre");
            nota2 =  int.Parse(Console.ReadLine());
            Console.WriteLine ("Digite sua nota do 3º semstre");
            nota3 = int.Parse (Console.ReadLine());
            Console.WriteLine ("Digite sua nota do 4º semestre");
            nota4 = int.Parse ( Console.ReadLine());
            resultado = ( (nota1 + nota2 + nota3 + nota4) / 4 );
            Console.WriteLine ("A sua média é " + resultado);
            
            

        }
    }
}