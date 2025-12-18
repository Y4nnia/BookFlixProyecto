using BookFlixRazor.Models;

namespace BookFlixRazor.Services
{
    public interface IUsuarioService
    {
        void Registrar(RegistroDTO dto);
        Usuario? Login (string correo, string password);
        IEnumerable<Usuario> ObtenerTodosLosUsuarios ();
        Usuario? ObtenerUsuarioPorId(int id);
        Usuario? ObtenerPorCorreo(string correo);

    }
}
