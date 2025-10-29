using Projeto.Domain.EnTidads;
using Projeto.Domain.Interface;
using Projeto.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Aplication.Service
{
    public class AlunoService : IAlunoService


    {
        private readonly IAlunoRepository _alunoRepository;

        public AlunoService(IAlunoRepository alunoRepository)
        {
            _alunoRepository = alunoRepository;
        }

        public void Adicionar(Aluno aluno)
        {
            Aluno buscaAluno = _alunoRepository.ObterPorCPF(aluno.CPF);

            if (buscaAluno != null)
            {
                throw new Exception("Já Existe um aluno cadastrado com esse CPF");
            }

            Aluno BuscaAlunoMatricula = _alunoRepository.ObterPorRA(aluno.RA);
            _alunoRepository.Adicionar(aluno);

            if (buscaAluno != null)
            {
                throw new Exception("já existe um aluno cadastrado com esse RA");
            }
        }

        public void Atualizar(Aluno aluno)
        {
            Aluno buscaALuno = _alunoRepository.ObterPorID(aluno.IDaluno);
            if (buscaALuno == null)
            {
                throw new Exception("Aluno não existe");
            }

            buscaALuno = _alunoRepository.ObterPorCPF(aluno.CPF);

            if(buscaALuno != null && buscaALuno.IDaluno != aluno.IDaluno)
            {
                throw new Exception("já existe um Aluno" + " Cadastrado com esse CPF");
            }

            _alunoRepository.Atualizar(aluno);




        }

        public void Deletar(int IDaluno)
        {

            Aluno buscaAluno = _alunoRepository.ObterPorID(IDaluno);
            if(buscaAluno == null)
            {
                throw new Exception("Aluno não encontrado");
            }


            _alunoRepository.Deletar(IDaluno);
        }

        public Aluno ObterPorCPF(string CPF)
        {
            return _alunoRepository.ObterPorCPF(CPF);
        }

        public Aluno ObterPorID(int IDaluno)
        {
            return _alunoRepository.ObterPorID(IDaluno);
        }

        public Aluno ObterPorRA(string RA)
        {
            return _alunoRepository.ObterPorRA(RA); 
        }

        public List<Aluno> ObterTodos()
        {
            throw new NotImplementedException();
        }
    }
}
