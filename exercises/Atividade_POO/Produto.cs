using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_POO
{
    internal class Produto
    {
        public string descricao;
        public double valor;

        public double criaProduto(string descricao, double valor)
        {
            this.descricao = descricao;

            return valor;
        }

        public void criaProduto()
        {
            Console.WriteLine("Digite a descrição do produto: ");
            string descricao = Console.ReadLine();

            Console.WriteLine("Digite o valor do produto: ");
            double valor = double.Parse(Console.ReadLine());
               
            this.valor = criaProduto(descricao, valor);
        }
    }
}
