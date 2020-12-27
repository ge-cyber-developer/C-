using System;

namespace ESTRUTURADEDECISAO_4
{
    class Program 
    {
        static void Main (string [] args)
        {
            Console.WriteLine("Digite uma letra");
            string letra;
            letra  = Console.ReadLine().ToLower ();
            //string lowerletra = letra.ToLower(); = você criou uma string que diz que ela é equivalente a string letra porém, na versão minúscula 
            //Console.WriteLine(lowerletra); = aqui você pede para que a string (lowerletra) seja impressa

            if ( letra == "a" || letra == "e"|| letra =="i" || letra == "o" || letra =="u")
            {
              Console.WriteLine ("A letra " + letra + " é vogal");
              // Console.WriteLine ("A letra " + lowerletra + " é vogal"); = repare que aqui você não usa a string (letra), mais sim a string (lowerletra). Nesse caso a sua reposta seria a string (letra) em sua versão minúscula (lowerletra).
            }
            else 
            {
                Console.WriteLine("A letra "+ letra + " é uma consoante");
            }
        }
    }
}
