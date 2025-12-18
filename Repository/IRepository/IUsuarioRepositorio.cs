using BookFlixRazor.Models;

namespace BookFlixRazor.Repository.IRepositorio
{
    public interface IUsuarioRepositorio
    {
        void Add(Usuario usuario);       // Para registrar
        Usuario? GetById(int id);        // Buscar por id
        Usuario? GetByEmail(string correo); // Buscar por email, útil para login
        IEnumerable<Usuario> GetAll();
    }
}
