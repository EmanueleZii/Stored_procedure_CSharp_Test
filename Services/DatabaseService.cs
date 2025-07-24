using MySql.Data.MySqlClient;
using Models;
using System;
using System.Data;

namespace Services;

public class DatabaseService
{
    private readonly string _connStr = "Server=localhost;Database=test;User=root;Password=claptrap;";

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
                    Id = reader.GetOrdinal("Id"),
                    Nome = reader.GetString(reader.GetOrdinal("Nome")),
                    Email = reader.GetString(reader.GetOrdinal("Email"))
                };
            }
            return null;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Errore durante accesso ai dati: {ex.Message}");
            return null;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandTimeout = 5;
        }
    }

    public void CloseConnection(MySqlConnection conn)
    {
        if (conn != null && conn.State == System.Data.ConnectionState.Open)
        {
            conn.Close();
        }
    }

}
