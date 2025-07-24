using MySql.Data.MySqlClient;
using Models;

namespace Services;

public class DatabaseService
{
    private readonly string _connStr = "Server=localhost;Database=testdb;User=root;Password=;";

    public async Task<Utente?> GetUtenteByIdAsync(int id)
    {
        using var conn = new MySqlConnection(_connStr);
        using var cmd = new MySqlCommand("GetUtenteById", conn);
        cmd.CommandType = System.Data.CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@idUtente", id);

        try
        {
            await conn.OpenAsync();
            using var reader = await cmd.ExecuteReaderAsync();

            if (await reader.ReadAsync())
            {
                return new Utente
                {
                    Id = reader.GetInt32("Id"),
                    Nome = reader.GetString("Nome"),
                    Email = reader.GetString("Email")
                };
            }
            return null;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Errore durante accesso ai dati: {ex.Message}");
            return null;
        }
    }
}
