using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string op;
            op = "0";
            Console.WriteLine("/---MENU---/\n\n Escolha uma opção:\n\n 1 - opção 1\n 2 - opção 2\n Q - Sair!");
            while (op.ToUpper() != "Q")
            {
                Console.WriteLine("Deseja continuar");
                op = Console.ReadLine();
                if (op.Length < 2)
                {
                    switch (op)
                    {
                        case "1":
                            Console.WriteLine("Voce escolheu a opção 1 ");
                            break;
                        case "2":
                            Console.WriteLine("Voce escolheu a opção 2 ");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Voce digitou uma opcao invalida");
                    op = "i";
                }
            }
        }
    }
}
