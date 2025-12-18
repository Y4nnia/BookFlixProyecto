using BookFlixRazor.Repository.Factories;
using Dapper;
using BookFlixRazor.Repository.IRepositorio;
using BookFlixRazor.Models;

namespace BookFlixRazor.Repository
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        private readonly IDbConnectionFactory  _conexion;

        public UsuarioRepositorio(IDbConnectionFactory  conexion)
        {
            _conexion = conexion;
        }

        public void Add(Usuario usuario)
        {
            using var connection = _conexion.CreateConnection();

            string sql = @"
                INSERT INTO Usuario (Nombre, Correo, Password)
                VALUES (@Nombre, @Correo, @Password); ";

            connection.Execute(sql, usuario);
        }

        public Usuario? GetById(int id)
        {
            using var connection = _conexion.CreateConnection();
            string sql = "SELECT * FROM Usuario WHERE Id = @Id";

            return connection.QueryFirstOrDefault<Usuario>(
                sql,
                new { Id = id }
            );
        }

        public Usuario? GetByEmail(string correo)
        {
            using var connection = _conexion.CreateConnection();
            string sql = "SELECT * FROM Usuario WHERE Correo = @Correo";

            return connection.QueryFirstOrDefault<Usuario>(
                sql,
                new { Correo = correo }
            );
        }
        public IEnumerable<Usuario> GetAll()
        {
            using var connection = _conexion.CreateConnection();
            return connection.Query<Usuario>("SELECT * FROM Usuario");
        }

        
    }
}