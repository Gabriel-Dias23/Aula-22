using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

  namespace Projeto.Domain.EnTidads
{
    public class Curso
    {
        public Curso(int IDCurso, string nome, string NomeCordenador , bool Ativo)
        {
            this.IDCurso = IDCurso;
            this.nome = nome;
            this.NomeCordenador = NomeCordenador;
            this.Ativo = Ativo;
        }

        public int IDCurso { get; private set; }
        public string nome { get; private set; }
        public string NomeCordenador { get;  private set; }
        public bool Ativo { get; private set; }
        
    }
}




