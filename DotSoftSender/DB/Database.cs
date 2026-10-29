using Npgsql;

namespace DotSoftSender.DB
{
    public static class Database
    {
        private static readonly string connectionString =
            "Host=localhost;Port=5432;Database=dotsoft_sender;Username=postgres;Password=P@ssw0rd";

        public static NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(connectionString);
        }
    }
}