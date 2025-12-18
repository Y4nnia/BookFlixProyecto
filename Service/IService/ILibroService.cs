using BookFlixRazor.Models;

namespace BookFlixRazor.Services
{
    public interface ILibroService
    {
        IEnumerable<Libro> ObtenerTodos();
        Libro? ObtenerPorId(int id);
    }
}
