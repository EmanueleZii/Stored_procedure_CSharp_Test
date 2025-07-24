# ✅ Test Tecnico – Accesso a Stored Procedure MySQL da .NET Console App

Questo progetto è stato realizzato per esercitarmi in vista di un test tecnico proposto da GigaSolar, focalizzato su:

- **Stored Procedure in MySQL**
- **Accesso ai dati da C#**
- **POCO Classes**
- **Async/Await**
- **Gestione degli errori**
- **Buone pratiche di codice strutturato**

---

## 🚀 Obiettivo del Test

Simulare un'applicazione che:

1. Si connette a un database MySQL
2. Chiama una Stored Procedure `GetUtenteById`
3. Restituisce un oggetto `Utente` usando una classe POCO
4. Gestisce tutto da un'applicazione **.NET Console** con codice asincrono e separazione in `Models` e `Services`

---

## 📁 Struttura del progetto

ConsoleMySQLApp/
│
├── Program.cs                    # Entry point con interazione utente
├── ConsoleMySQLApp.csproj        # File di progetto .NET
├── NuGet.config                  # Configurazione NuGet pulita
├── README.md                     # Questo file
├── StoredProcedure.sql           # Script SQL con tabella + SP
│
├── Models/
│   └── Utente.cs                 # POCO per rappresentare la tabella SQL
│
└── Services/
└── DatabaseService.cs        # Logica di accesso al database e chiamata SP