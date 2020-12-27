using System;

namespace ESTRUTURADEDECISAO_8
{
    class Program 
    {
        static void Main ( string [] args)
        {
            double produto1;
            double produto2;
            double produto3;
            Console.WriteLine("Digite o preço do primeiro produto");
            produto1 = double.Parse ( Console.ReadLine());
            Console.WriteLine ("Digite o preço do segundo produto:");
            produto2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o preço do terceiro produto:");
            produto3 = double.Parse(Console.ReadLine());
            if(produto1 > produto2 && produto2 > produto3)
            {
                Console.WriteLine ("O terceiro produto é o mais barato");   
            }
                 else if ( produto2 > produto1 && produto1 > produto3)
            {
                Console.WriteLine("O terceiro produto é o produto mais barato");
            }
          
            else if( produto3 > produto1 && produto1 > produto2)
            {
                Console.WriteLine("O segundo produto é o produto mais barato");
            }
            else if ( produto1 > produto3 && produto3 > produto2)
            {
                Console.WriteLine("O segundo produto é o produto mais barato");
            }
            else if ( produto2 > produto3 && produto3 > produto1 )
            {
                Console.WriteLine("O primeiro produto, é o mais barato");
            }
            else if (produto3 > produto2 && produto2 > produto1)
            {
                Console.WriteLine("O primeiro produto é o mais barato");
            }
           
            else
            {
                Console.WriteLine("Os produtos tem todos o mesmo valor");
            }
        }
    }
}