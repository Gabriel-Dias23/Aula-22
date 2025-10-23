using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

  namespace Projeto.Domain.EnTidads
{
    public class Aluno
    {
        public Aluno(int IDaluno, string nome, string cPF, string rA, string eMAIL)
        {
            this.IDaluno = IDaluno;
            this.nome = nome;
            this.CPF = cPF;
            this.RA = RA;
            this.email = email;
        }

        public int IDaluno { get; private set; }
        public string nome { get; private set; }
        public string CPF { get;  private set; }
        public string RA { get; private set; }
        public string email { get; private set; }
    }
}




