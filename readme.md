# ConsoleMySQLApp

Applicazione console C# per leggere dati utente da MySQL tramite Stored Procedure.

## Setup

1. Assicurati che MySQL sia in esecuzione e crea il database `testdb`
2. Esegui `StoredProcedure.sql` nel tuo client MySQL (es. MySQL Workbench o da terminale)
3. Modifica la stringa di connessione in `DatabaseService.cs` se necessario
4. Da terminale:

```
dotnet restore
dotnet run
```

## Dipendenze

- .NET 8.0
- MySql.Data
