using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

  namespace Projeto.Domain.EnTidads
{
    internal class Aluno
    {
        public Aluno(string nome, string cPF, string rA, string eMAIL)
        {
            this.nome = nome;
            CPF = cPF;
            RA = rA;
            EMAIL = eMAIL;
        }

        public string nome { get; private set; }
        public string CPF { get;  private set; }
        public string RA { get; private set; }
        public string EMAIL { get; private set; }
    }
}




