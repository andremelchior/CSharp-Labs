using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_POO
{
    internal class Cliente : Pessoa
    {
        public string cpf;
        public string rg;

        public Cliente(string cpf, string nome)
        {
            this.cpf = cpf;
            this.nome = nome;
        }
    }
}
