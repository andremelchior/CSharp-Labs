using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp003
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int menor;
            int maior;
            int op = 1;

            Console.WriteLine("Digite um valor ");
            a = int.Parse(Console.ReadLine());
            maior = a;
            menor = a;

            while (op != 0) {

                Console.WriteLine("Digite outro valor ");
                a = int.Parse(Console.ReadLine());

                if (a > maior)
                {
                  maior = a;
                }
                if (a < menor)
                {
                  menor = a;
                }
                if (maior == menor)
                {
                    Console.WriteLine("Os números são Iguais!");
                }
                else
                {

                    Console.WriteLine("O maior número � " + maior);
                    Console.WriteLine("O menor número � " + menor);
                    Console.WriteLine("Digite 0 para finalizar o programa ou 1 para continuar");
                    op = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Finalizando o programa...");
            Console.ReadKey();
        }
    }
}
