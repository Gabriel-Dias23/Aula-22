using Projeto.Domain.EnTidads;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Domain.Interface
{
    public interface ICursoRepository
    {
        public void Adicionar(Curso curso);
        public void Atualizar(Curso curso);
        void Deletar(int IDcurso);
        public List<Curso> ObterTodos();
        public Curso ObterPorID(int IDcurso);
     
    }
}
