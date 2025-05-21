using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace introductionOOP
{
    internal class Pessoa
    {
        public string nome;
        public string email;
        public int idade;
        public string cpf;
        public double altura;
        public double peso;
        public string etnia;

        public void mostraNome()
        {
            Console.WriteLine("\nNome: {0}", nome);
        }
    }
}
