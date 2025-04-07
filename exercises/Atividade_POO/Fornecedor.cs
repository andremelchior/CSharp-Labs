using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_POO
{
    internal class Fornecedor : Pessoa
    {
        public string cnpj;
        public string razaosocial;

        public void criaFornecedor(string nome, string cnpj)
        {
            this.nome = nome;
            this.cnpj = cnpj;
        }
    }
}
