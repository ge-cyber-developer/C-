using System;

 namespace ESTRUTURADEDECISAO_3
 {
     class Program
     {
        static void Main ( string[] args)
        {
           
            Console.WriteLine (" digite seu gênero com F ou M :");
            string genero= Console.ReadLine();

            if ( genero == "F" || genero == "f")
            {
              Console.WriteLine ("Feminino");
            }
            else if ( genero == "M" || genero == "m")
            { 
              Console.WriteLine("Masculino");
            }
            else 
            {
              Console.WriteLine( "Genêro inválido");
            }
        }
     }
 }