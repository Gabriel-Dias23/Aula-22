using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Domain.Entidades
{
    public class Matricula
    {
        public Matricula(int IDAluno, int IDCurso, int DataMatricula, bool Ativo)
        {
            this.IDCurso = IDCurso;
            this.IDAluno = IDAluno;
            this.DataMatricula = DataMatricula;
            this.Ativo = Ativo;
        }

        public int IDCurso { get; private set; }
        public int IDAluno { get; private set; }
        public int DataMatricula { get; private set; }
        public bool Ativo { get; private set; }
    }
}
