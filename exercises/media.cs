using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace media
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, n3, media;

            Console.WriteLine("Digite a primeira nota: ");
            n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a segunda nota: ");
            n2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a terceira nota: ");
            n3 = double.Parse(Console.ReadLine());
            media = (n1 + n2 + n3) / 3;

            Console.WriteLine("\nA média entre as notas {0}, {1} e {2} é: {3}. ", n1, n2, n3, media);

            Console.ReadKey();

        }
    }
}
