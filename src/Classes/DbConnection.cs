using Microsoft.Data.SqlClient;

namespace harryPotter.src.Classes;

class DbConnection
{
    public static SqlConnection DatabaseConnection()
    {
        string connectionString = @"Server=tcp:home-server.database.windows.net,1433;Initial Catalog=harryPotterTopTrumps;Persist Security Info=False;User ID=lilyboughton;Password=L1LyBought0n;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

        SqlConnection connection = new SqlConnection(connectionString);

        return connection;
    }
}
