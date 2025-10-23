using Projeto.Domain.EnTidads;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Domain.Repository
{
  public interface IAlunoRepository
    {

        public void Adicionar(Aluno aluno);
        public void Atualizar(Aluno aluno);
        void Deletar(int IDaluno);

        public List<Aluno> ObterTodos();

        public Aluno ObterPorID(int IDaluno);
        public Aluno ObterPorCPF(String CPF);
        public Aluno ObterPorRA(String RA);
    }
}
