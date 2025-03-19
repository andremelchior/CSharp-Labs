using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace introductionOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa aluno = new Pessoa(); //instancia é a criação de um objeto
            Pessoa aluno1 = new Pessoa(); //instancia

            aluno.nome = "tio patinhas";
            aluno.altura = 1.70;
            aluno.peso = 90;

            aluno1.nome = "pato donald";

            Console.WriteLine("Aluno: {0}", aluno1.nome);
        }
    }
}
