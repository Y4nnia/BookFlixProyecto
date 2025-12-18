using BookFlixRazor.Models;
using BookFlixRazor.Repository.IRepositorio;

namespace BookFlixRazor.Services
{
    public class LibroService : ILibroService
    {
        private readonly ILibroRepositorio _libroRepositorio;
        public LibroService(ILibroRepositorio libroRepositorio)
        {
            _libroRepositorio = libroRepositorio;
        }

        public IEnumerable<Libro> ObtenerTodos()
        {
            return _libroRepositorio.GetAll();
        }

        public Libro? ObtenerPorId(int id)
        {
            return _libroRepositorio.GetById(id);
        }
    }
}
