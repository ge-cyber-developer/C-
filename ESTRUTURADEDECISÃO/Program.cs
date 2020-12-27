using System;

namespace ESTRUTURADEDECISÃO
{
    class Program 
    {
        static void Main (string [] args)
        {
           int num1;
           int num2;
           Console.WriteLine("Digite um número: ");
           num1 = int.Parse(Console.ReadLine());
           Console.WriteLine("Digite mais um número: ");
           num2 = int.Parse ( Console.ReadLine());
           if( num1 > num2 )
           {
               Console.WriteLine( num1 +" é maior que "+ num2);
           }
           else
           {
               Console.WriteLine( num2 +" é maior que "+ num1);
           } 

        }
    }
}