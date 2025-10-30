using Projeto.Domain.Entidades;
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
        void Deletar(int IDmatricula);
        public List<Matricula> ObterTodos();
        public Matricula ObterPorID(int IDmatricula);
        public Matricula ObterPorMatricula(int Matricula);
    }
}
