using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
           Pessoa fulano_1, fulano_2;

            fulano_1 = new Pessoa();
            fulano_2 = new Pessoa();

         Console.WriteLine("Dados da primeira pessoa:");
         Console.Write("Nome:");
         fulano_1.Nome = Console.ReadLine();
         Console.Write("Idade:");
         fulano_1.Idade = int.Parse(Console.ReadLine());
         

         Console.WriteLine("Dados da segunda pessoa:");
         Console.Write("Nome:");
         fulano_2.Nome = Console.ReadLine();
         Console.Write("Idade:");
         fulano_2.Idade = int.Parse(Console.ReadLine());

            if ( fulano_1.Idade > fulano_2.Idade)
            {
                Console.WriteLine("Pessoa mais velha:"+ fulano_1.Nome);
            }
            else
            {
                Console.WriteLine("Pessoa mais velha:" + fulano_2.Nome);
            }
        }
        

      
        
    }
}
