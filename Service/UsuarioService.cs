using BookFlixRazor.Models;
using BookFlixRazor.Repository.IRepositorio;
using System.Security.Cryptography;
using System.Text;

namespace BookFlixRazor.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepositorio _usuarioRepo;

        public UsuarioService(IUsuarioRepositorio usuarioRepo)
        {
            _usuarioRepo = usuarioRepo;
        }

        public void Registrar(RegistroDTO dto)
        {
            if (_usuarioRepo.GetByEmail(dto.Correo) != null)
                throw new Exception("El correo ya está registrado");

            var usuario = new Usuario
            {
                Nombre = dto.Nombre,
                Apellido = dto.Apellido,
                Correo = dto.Correo,
                Password = HashPassword(dto.Password)
            };

            _usuarioRepo.Add(usuario);
        }

        public Usuario? Login(string correo, string password)
        {
            var usuario = _usuarioRepo.GetByEmail(correo);

            if (usuario == null)
                return null;

            var passwordHash = HashPassword(password);
            return usuario.Password == passwordHash ? usuario : null;
        }

        public IEnumerable<Usuario> ObtenerTodosLosUsuarios()
        {
            return _usuarioRepo.GetAll();
        }

        public Usuario? ObtenerUsuarioPorId(int id)
        {
            return _usuarioRepo.GetById(id);
        }

        public Usuario? ObtenerPorCorreo(string correo)
        {
            return _usuarioRepo.GetByEmail(correo);
        }

        private string HashPassword(string password)
        {
            using var sha = SHA256.Create();
            var bytes = Encoding.UTF8.GetBytes(password);
            var hash = sha.ComputeHash(bytes);
            return Convert.ToBase64String(hash);
        }
    }
}