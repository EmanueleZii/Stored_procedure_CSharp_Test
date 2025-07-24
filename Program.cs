using Models;
using Services;

class Program
{
    static async Task Main()
    {
        Console.Write("Inserisci ID utente da cercare: ");
        if (int.TryParse(Console.ReadLine(), out int id))
        {
            var db = new DatabaseService();
            var utente = await db.GetUtenteByIdAsync(id);

            if (utente != null)
            {
                Console.WriteLine($"ID: {utente.Id}");
                Console.WriteLine($"Nome: {utente.Nome}");
                Console.WriteLine($"Email: {utente.Email}");
            }
            else
            {
                Console.WriteLine("Utente non trovato.");
            }
        }
        else
        {
            Console.WriteLine("ID non valido.");
        }
    }
}
