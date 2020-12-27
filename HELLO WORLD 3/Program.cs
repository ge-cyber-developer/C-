using System;
 
namespace HELLO_WORLD_3

{
    class Program 
    {
        static void Main ( string[] args)
        {
            Console.WriteLine("Digite um número");
            int num1;
            int num2;
            int resultado;
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro número");
            num2= int.Parse(Console.ReadLine());
            resultado = (num1+ num2);
            Console.WriteLine( "A soma dos dois números é "+ resultado);

        }
    }
}