using MySql.Data.MySqlClient;
using System.Threading.Tasks;

public class DatabaseService
{
    private readonly string _connStr = "Server=localhost;Database=test;User=root;Password=claptrap;";

    public async Task<Utente?> GetUtenteByIdAsync(int id)
    {
        using var conn = new MySqlConnection(_connStr);
        using var cmd = new MySqlCommand("GetUtenteById", conn);
        cmd.CommandType = System.Data.CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@idUtente", id); // cambia nome parametro per MySQL

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
            Console.WriteLine($"Errore: {ex.Message}");
            return null;
        }
    }
}