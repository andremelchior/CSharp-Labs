using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, result;
            result = 0;
            int op;

            Console.WriteLine("Calculadora Simples");
            Console.WriteLine(" --------------------");
            Console.WriteLine("| (1) SOMA           |");
            Console.WriteLine("| (2) SUBTRACAO      |");
            Console.WriteLine("| (3) MULTIPLICACAO  |");
            Console.WriteLine("| (4) DIVISAO        |");
            Console.WriteLine(" --------------------");

            op = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o primeiro número: ");
            n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            n2 = double.Parse(Console.ReadLine());


            switch (op) {
                case 1:
                    result = n1 + n2;
                    break;
                case 2:
                    result = n1 - n2;
                    break;
                case 3:
                    result = n1 * n2;
                    break;
                case 4:
                    result = n1 / n2;
                    break;
                default:
                    Console.WriteLine("Erro! Operação inválida.");
                    break;
            }

            Console.WriteLine("\nO resultado é: {0}", result);
            Console.WriteLine("\nPressione qualquer tecla para sair.");

            Console.ReadKey();
        }
    }
}
