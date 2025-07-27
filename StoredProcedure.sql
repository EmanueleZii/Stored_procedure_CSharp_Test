CREATE TABLE Utenti (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    Nome VARCHAR(100),
    Email VARCHAR(100)
);

INSERT INTO Utenti (Nome, Email)
VALUES ('Mario Rossi', 'mario@example.com'),
       ('Luisa Bianchi', 'luisa@example.com');

DELIMITER $$

CREATE PROCEDURE GetUtenteById(IN idUtente INT)
BEGIN
    SELECT Id, Nome, Email
    FROM Utenti
    WHERE Id = idUtente;
END $$

DELIMITER ;
