using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace CA250325CS
{
    internal class Aluno : Pessoa
    {
        public int rm;
        public string cursos;
        public string periodo;

        public void mostrarDados()
        {
            Console.WriteLine("\nRM: {0}\nCursos: {1}\nPeriodo: {2}", rm, cursos, periodo);
        }
    }
}