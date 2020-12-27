using System;

namespace ESTRUTURADEDECISAO_5
{
    class Program 
    {
        static void Main( string [] args)
        {
            double nota1;
            double nota2;
            double resultado; 
            Console.WriteLine ("Digite a primeira nota:");
            nota1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a segunda nota:");
            nota2 = double.Parse(Console.ReadLine());
            resultado = ((nota1 + nota2)/2);
            if (resultado == 10)
            {
                Console.WriteLine("Aprovado com Destinção");
            }
            else if (resultado == 7 || resultado > 7 )
            {
                Console.WriteLine("Aprovado");
            }
            else
            {
                Console.WriteLine("Reprovado");
            }
        }
    }
}
