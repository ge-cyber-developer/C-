using System;

namespace ESTRUTURADEDECISAO_7
{
    class Program
    {
       static void Main ( string [] args)
       {
           int num1;
           int num2;
           Console.WriteLine("Digite um número:");
           num1 = int.Parse(Console.ReadLine());
           Console.WriteLine("Digite outra número:");
           num2 = int.Parse(Console.ReadLine());
           if( num1 > num2)
           {
               Console.WriteLine(num1 + " é maior que "+ num2);
           }     
           else if ( num1 == num2)
           {
               Console.WriteLine(num1 +" é igual a " + num2);
           }
           else 
           {
               Console.WriteLine ( num2 + " é maior que " + num1);
           }
       }
    }
}