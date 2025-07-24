CREATE TABLE Utenti (
    Id INT PRIMARY,
    Nome NVARCHAR(100),
    Email NVARCHAR(100)
);

INSERT INTO Utenti (Nome, Email)
VALUES ('Mario Rossi', 'mario@example.com'),
       ('Luisa Bianchi', 'luisa@example.com');

/* sql */
CREATE PROCEDURE GetUtenteById
    @Id INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT Id, Nome, Email
    FROM Utenti
    WHERE Id = @Id;
END

/* mysql */
DELIMITER $$

CREATE PROCEDURE GetUtenteById(IN idUtente INT)
BEGIN
    SELECT Id, Nome, Email
    FROM Utenti
    WHERE Id = idUtente;
END$$

DELIMITER ;