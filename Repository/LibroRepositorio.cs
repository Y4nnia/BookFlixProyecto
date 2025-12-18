using BookFlixRazor.Models;
using BookFlixRazor.Repository.Factories;
using BookFlixRazor.Repository.IRepositorio;
using Dapper;

namespace BookFlixRazor.Repository
{
    public class LibroRepositorio : ILibroRepositorio
    {
        private readonly IDbConnectionFactory  _conexion;

        public LibroRepositorio(IDbConnectionFactory  conexion)
        {
            _conexion = conexion;
        }

         public IEnumerable<Libro> GetAll()
        {
            using var connection = _conexion.CreateConnection();
            return connection.Query<Libro>("SELECT * FROM Libro");
        }

        public Libro? GetById(int id)
        {
            using var connection = _conexion.CreateConnection();
            return connection.QueryFirstOrDefault<Libro>(
                "SELECT * FROM Libro WHERE IdLibro = @IdLibro",
                new { IdLibro = id }
            );
        }

   }
}