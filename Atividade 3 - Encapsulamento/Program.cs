using System;

namespace Atividade_3___Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Informar o texto do carimbo: ");
            string texto1 = Console.ReadLine();
            Console.WriteLine("Informar a cor: ");
            string cor1 = Console.ReadLine();
            Console.WriteLine("Informar a quantidade de cargas: ");
            int carga1 = Convert.ToInt32(Console.ReadLine());
            Carimbo num1 = new Carimbo(texto1);

            
            num1.carregar(cor1, carga1);
            num1.usar();

           

        }
    }
}
