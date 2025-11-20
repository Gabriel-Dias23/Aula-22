using Projeto.Domain.Entidades;
using Projeto.Domain.EnTidads;
using Projeto.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Aplication.Service
{
    public class MatriculaService : IMatriculaRepository

    {
        private readonly IMatriculaRepository _matriculaRepository;

     public MatriculaService(IMatriculaRepository matriculaRepository)
        {
            _matriculaRepository = matriculaRepository;
        }

       public void Adicionar(Matricula matricula)
        {
          
            Matricula BuscaMatricula = _matriculaRepository
             .ObterPorIDPorIdAluno(matricula.IDAluno, matricula.IDCurso);
            if (BuscaMatricula != null)
            {
                throw new Exception("Já existe uma matricula " +
                    "cadastrada neste curso .");
            }

            _matriculaRepository.Adicionar(matricula);
           
        }

        public void Atualizar(Matricula matricula)
        {
            Curso BuscaMatricula = _matriculaRepository.ObterPorID();
            if (BuscaMatricula == null)
            {
                throw new Exception("Curso não encontrado");
            }

            _matriculaRepository.Atualizar(matricula);
        }

       public void Deletar(int IDmatricula)
        {
            Matricula BuscaMatricula = _matriculaRepository
                   .ObterPorID(IDmatricula);
            if (BuscaMatricula == null)
            {
                throw new Exception("Aluno não encontrado.");
            }

            _matriculaRepository.Deletar(IDmatricula);
        }

        public Matricula ObterPorID(int IDmatricula)
        {
            return _matriculaRepository.ObterPorID(IDmatricula);
        }

        public Curso ObterPorID()
        {
            throw new NotImplementedException();
        }

        public Matricula ObterPorIDPorIdAluno(int idAluno, int idCurso)
        {
            return _matriculaRepository.ObterPorIDPorIdAluno(idCurso, idAluno);
           
        }

        public List<Matricula> ObterTodosPorCurso()
        {
            throw new NotImplementedException();
        }

        List<Matricula> ObterTodosPorCurso(int idCurso)
        {
            return _matriculaRepository.ObterTodosPorCurso();
        }

        List<Matricula> IMatriculaRepository.ObterTodosPorCurso(int idCurso)
        {
            return ObterTodosPorCurso(idCurso);
        }
    }
}
