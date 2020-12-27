using System;

namespace ESTRUTURADEDECISAO_6
{
    class Program 
    {
        static void Main ( string [] args)
        {
            double num1;
            double num2;
            double num3;
            Console.WriteLine("Digite um número:");
            num1 =  int.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro número:");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite mais um número:");
            num3 = int.Parse(Console.ReadLine());
            if (num1 > num2 && num1 < num3)
            {
                Console.WriteLine("O número "+ num3+ " é maior que o número "+num1+ " e o número "+ num2);
            }
            else if (num2 > num3 && num1 < num3 )
            {
                Console.WriteLine("O número "+ num2+ " é maior do que o número "+num3+" e o número "+ num1);
            }
            else if (num1 < num3 && num1 < num2)
            {
                Console.WriteLine("O número "+num3+ " é maior que o número " + num2+ " e o número "+num1);
            }
            else
            {
                Console.WriteLine("O número "+num2+ " é maior que o número " + num1+ " e o número "+num3);
            }
        }
    }
}