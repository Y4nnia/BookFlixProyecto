using MySql.Data.MySqlClient;
using Microsoft.Extensions.Configuration;

namespace BookFlixRazor.Repository.Factories
{
    public class DbConnectionRepo : IDbConnectionFactory
    {
        private readonly IConfiguration _configuration;

        public DbConnectionRepo(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public MySqlConnection CreateConnection()
        {
            return new MySqlConnection(
                _configuration.GetConnectionString("DefaultConnection")
            );
        }
    }
}
