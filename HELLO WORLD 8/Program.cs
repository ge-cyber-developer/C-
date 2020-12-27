using System;

namespace HELLO_WORLD_8
{
    class Program 
    {
        static void Main(string [] args)
        {
            double ganho_por_hora;
            double horas_trabalhadas;
            double salario;
            Console.WriteLine ("Digite quanto você ganha por hora");
            ganho_por_hora= double.Parse( Console.ReadLine());
            Console.WriteLine("Digite o número de horas trabalhadas por mês");
            horas_trabalhadas= double.Parse ( Console.ReadLine ());
            salario= (ganho_por_hora* horas_trabalhadas);
            Console.WriteLine("O seu sálario por mês é de R$ "+ salario);
       

        }
    }
}