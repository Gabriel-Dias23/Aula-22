using Projeto.Domain.EnTidads;
using Projeto.Domain.Interface;



namespace Projeto.Aplication.Service
{
    public class CursoService : ICursoRepository


    {
        private readonly ICursoRepository _cursoRepository;

        public CursoService(ICursoRepository cursoRepository)
        {
            _cursoRepository = cursoRepository;
        }

        public void Adicionar(Curso aluno)
        {
            Curso buscaAluno = _cursoRepository.ObterPorID(Curso.IDCurso);

            if (buscaAluno != null)
            {
                throw new Exception("Já Existe um curso cadastrado com esse CPF");
            }

            Curso BuscaAlunoMatricula = _cursoRepository.ObterPorID(Curso.IDCurso);
            _cursoRepository.Adicionar(aluno);

            if (buscaAluno != null)
            {
                throw new Exception("já existe um curso cadastrado com esse RA");
            }
        }

        public void Atualizar(Curso aluno)
        {
            Curso buscaCurso = _cursoRepository.ObterPorCurso(Curso.IDCurso);
            if (buscaCurso == null)
            {
                throw new Exception("Curso não existe");
            }

            buscaCurso = _cursoRepository.ObterPorCurso(Curso.curso);

            if(buscaCurso != null && buscaCurso.IDCurso != Curso.IDCurso) 
            { 
            
                throw new Exception("já existe um Aluno" + " Cadastrado com esse CPF");
            }

            _cursoRepository.Atualizar(Curso);

        }

        public void Deletar(int IDCurso)
        {

            Curso buscaCurso = _cursoRepository.ObterPorCurso(IDCurso);
            if(buscaCurso == null)
            {
                throw new Exception("Curso não encontrado");
            }


            _cursoRepository.Deletar(IDCurso);
        }

        public Curso ObterPorID(int IDCurso)
        {
            return _cursoRepository.ObterPorID(IDCurso);
        }

        public Curso ObterPorCurso(int Curso)
        {
            return _cursoRepository.ObterPorCurso(Curso); 
        }

        public List<Curso> ObterTodos()
        {
            throw new NotImplementedException();
        }
    }
}
