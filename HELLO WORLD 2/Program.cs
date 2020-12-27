using System ;
 
 namespace HELLO_WORLD 
 {
     class Program 

     {
          static void Main ( string [] args)
          {  
              Console.WriteLine(" Digite um número");
              int num;
              num = int.Parse (Console.ReadLine());
              Console.WriteLine( "O número que você digitou foi " + num );
          }
     }
 }