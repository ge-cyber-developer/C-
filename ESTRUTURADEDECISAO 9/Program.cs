using System;

namespace ESTRUTURADEDECISAO_9
{
    class Program 
    {
        static void Main ( string [] args)
        {
            double num1;
            double num2;
            double num3;

            Console.WriteLine("Digite um número:");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro número:");
            num2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite um número:");
            num3 = double.Parse(Console.ReadLine());

            if (num1 > num2 && num2 > num3)
            {
                Console.WriteLine(num1+","+ num2 + "," + num3 );
            }
            else if (num2>num1 && num1>num3)
            {
                Console.WriteLine(num2+","+ num1 + "," + num3);
            }
           
            else if  (num1>num3 && num3>num2)
            {
               Console.WriteLine(num1+","+ num3 + "," + num2);
            }
            else if (num3>num1 && num1>num2)
            {
               Console.WriteLine(num3+","+ num1 + "," + num2);
            }
             else if ( num3 > num2 && num2 > num1)
            {
                Console.WriteLine (num3+","+ num2 + "," + num1);
            }
            else if ( num2>num3 && num3>num1)
            {
                Console.WriteLine(num2+","+ num3 + "," + num1);
            }
            else if ( num1== num2 && num1> num3)
            {
                Console.WriteLine(num1+","+ num2 + "," + num3);
            }
            else if (num1 == num3 && num1> num2)
            {
                Console.WriteLine (num1+","+ num3 + "," + num2);
            }
            else
            {
                Console.WriteLine("Resposta inválida");
            }

        }
    }
}