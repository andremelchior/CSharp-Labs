using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_POO
{
    internal class NotaFiscal
    {
        public double numero;
        public Cliente Cliente;
        public Fornecedor Fornecedor;
        public Produto produto;

        public void criaNotaFiscal(Cliente cliente, Fornecedor fornecedor)
        {
            Cliente = cliente;
            Fornecedor = fornecedor;
        }

        public void adicionaProduto(Produto produto)
        {
            this.produto = produto;
        }
    }
}
