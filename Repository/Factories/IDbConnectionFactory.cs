using MySql.Data.MySqlClient;

namespace BookFlixRazor.Repository.Factories
{
    public interface IDbConnectionFactory
    {
        MySqlConnection CreateConnection();
    }
}
