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

            aluno.nome = "andré";
            aluno.altura = 1.75;
            aluno.peso = 65;

            aluno1.nome = "pato donald";

            Console.WriteLine("Aluno: {0}", aluno1.nome);

            Aluno a1 = new Aluno();
            Professor pf1 = new Professor();

            pf1.nome = "Tio Patinhas";
            a1.nome = "Huguinho";

            a1.rm = 999;
            a1.cursos = "Ciência da Computação";
            a1.periodo = "Noturno";

            pf1.salario = 1.00;
            pf1.cargo = "Professor";
        }
    }
}
