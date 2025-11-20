using Projeto.Domain.Entidades;
using Projeto.Domain.EnTidads;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Domain.Interface
{
    public interface IMatriculaRepository
    {
        public void Adicionar(Matricula matricula);
        public void Atualizar(Matricula matricula);
       public void Deletar(int IDmatricula);
        public List<Matricula> ObterTodosPorCurso(int idCurso);
        public Matricula ObterPorID(int IDmatricula);
        public Matricula ObterPorIDPorIdAluno(int idAluno, int idCurso);
        List<Matricula> ObterTodosPorCurso();
        Curso ObterPorID();
    }
}
