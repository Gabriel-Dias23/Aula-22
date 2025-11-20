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

        public void Adicionar(Curso curso)
        { 
            _cursoRepository.Adicionar(curso);
        }

        public void Atualizar(Curso curso)
        {
            Curso buscaCurso = _cursoRepository.ObterPorID(curso.IDCurso);
            if (buscaCurso == null)
            {
                throw new Exception("Curso não encontrado");
            }

            _cursoRepository.Atualizar(curso);

        }

        public void Deletar(int IDCurso)
        {

            Curso buscaCurso = _cursoRepository.ObterPorID(IDCurso);
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

       

        public List<Curso> ObterTodos()
        {
            return _cursoRepository.ObterTodos();
        }
    }
}
