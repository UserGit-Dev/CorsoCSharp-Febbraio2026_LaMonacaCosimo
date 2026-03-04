CREATE DATABASE FestivalMusicale;
USE FestivalMusicale;

-- 1. Artisti (Singoli o Band)
CREATE TABLE Artisti (
    ID_Artista INT PRIMARY KEY AUTO_INCREMENT,
    Nome_Darte VARCHAR(100) NOT NULL UNIQUE,
    Tipo ENUM('Singolo', 'Band') NOT NULL,
    Genere VARCHAR(50)
);

-- 2. Palchi
CREATE TABLE Palchi (
    ID_Palco INT PRIMARY KEY AUTO_INCREMENT,
    Nome_Palco VARCHAR(50) NOT NULL,
    Capacita_Max INT NOT NULL CHECK (Capacita_Max > 0),
    Ubicazione VARCHAR(100)
);

-- 3. Performance
CREATE TABLE Performance (
    ID_Performance INT PRIMARY KEY AUTO_INCREMENT,
    ID_Palco INT NOT NULL,
    Data_Ora_Inizio DATETIME NOT NULL,
    FOREIGN KEY (ID_Palco) REFERENCES Palchi(ID_Palco)
);

-- 4. Lineup (Chi suona in quella performance)
CREATE TABLE Lineup (
    ID_Performance INT,
    ID_Artista INT,
    Tipo_Presenza ENUM('Principale', 'Ospite') DEFAULT 'Principale',
    PRIMARY KEY (ID_Performance, ID_Artista),
    FOREIGN KEY (ID_Performance) REFERENCES Performance(ID_Performance),
    FOREIGN KEY (ID_Artista) REFERENCES Artisti(ID_Artista)
);

-- 5. Spettatori
CREATE TABLE Spettatori (
    ID_Spettatore INT PRIMARY KEY AUTO_INCREMENT,
    Nome VARCHAR(50) NOT NULL,
    Email VARCHAR(100) UNIQUE NOT NULL
);

-- 6. Biglietti (Prezzo variabile e tracciamento pagamenti)
CREATE TABLE Biglietti (
    ID_Biglietto INT PRIMARY KEY AUTO_INCREMENT,
    ID_Spettatore INT NOT NULL,
    Tipo_Biglietto VARCHAR(30) NOT NULL, -- VIP, Standard, Early Bird
    Prezzo DECIMAL(10, 2) NOT NULL CHECK (Prezzo >= 0),
    Stato_Pagamento ENUM('Pagato', 'In Attesa', 'Annullato') DEFAULT 'In Attesa',
    Data_Acquisto TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (ID_Spettatore) REFERENCES Spettatori(ID_Spettatore)
);

-- 7. Sponsor (Associati ad artisti o performance)
CREATE TABLE Sponsor (
    ID_Sponsor INT PRIMARY KEY AUTO_INCREMENT,
    Nome_Sponsor VARCHAR(100) NOT NULL,
    Contributo_Euro DECIMAL(15, 2),
    ID_Artista_Sponsorizzato INT,
    ID_Performance_Esclusiva INT,
    FOREIGN KEY (ID_Artista_Sponsorizzato) REFERENCES Artisti(ID_Artista),
    FOREIGN KEY (ID_Performance_Esclusiva) REFERENCES Performance(ID_Performance)
);

-- 8. Staff Tecnico e assegnazione palchi
CREATE TABLE Staff (
    ID_Membro INT PRIMARY KEY AUTO_INCREMENT,
    Nome VARCHAR(50) NOT NULL,
    Ruolo VARCHAR(50), -- Fonico, Tecnico Luci, ecc.
    ID_Palco_Assegnato INT,
    FOREIGN KEY (ID_Palco_Assegnato) REFERENCES Palchi(ID_Palco)
);