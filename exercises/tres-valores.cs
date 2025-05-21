using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp001
{
    class Program
    {
        static void Main(string[] args)
        {
            string a;
            string b;
            string c;
            int num1;
            int num2;
            int num3;
            int soma;

            Console.WriteLine("Digite um número:");
            a = Console.ReadLine();
            num1 = int.Parse(a);
            Console.WriteLine("Digite o segundo número:");
            b = Console.ReadLine();
            num2 = int.Parse(b);
            Console.WriteLine("Digite o terceiro número:");
            c = Console.ReadLine();
            num3 = int.Parse(c);

            soma = num1 + num2 + num3;

            if (soma == 100)
            {
                Console.WriteLine("A soma é: " + soma);
                Console.WriteLine("O valor é igual a 100");
            }
            else if (soma > 100)
            {
                Console.WriteLine("A soma é: " + soma);
                Console.WriteLine("O valor é maior que 100");
            }
            else
            {
                Console.WriteLine("A soma é: " + soma);
                Console.WriteLine("O valor é menor que 100");
            }
            Console.WriteLine("Aperte qualquer tecla para sair");
            Console.ReadKey();
        }
    }
}
