USE FestivalMusicale;

-- 1. Popolamento Artisti
INSERT INTO Artisti (Nome_Darte, Tipo, Genere) VALUES 
('Radiohead', 'Band', 'Alternative Rock'),
('Dua Lipa', 'Singolo', 'Pop'),
('Calvin Harris', 'Singolo', 'Electronic'),
('Maneskin', 'Band', 'Rock'),
('Angèle', 'Singolo', 'Pop Indie'),
('Coldplay', 'Band', 'Pop Rock'),
('Peggy Gou', 'Singolo', 'House');
-- --------------------------------------------------------------------------------
-- 2. Popolamento Palchi
INSERT INTO Palchi (Nome_Palco, Capacita_Max, Ubicazione) VALUES 
('Main Stage', 15000, 'Piazzale Ovest'),
('Electronic Tent', 5000, 'Prato Est'),
('Acoustic Garden', 1000, 'Boschetto Sud'),
('Beach Stage', 3000, 'Spiaggia Nord');
-- --------------------------------------------------------------------------------
-- 3. Popolamento Performance
-- Giorno 1: 2024-08-20
INSERT INTO Performance (ID_Palco, Data_Ora_Inizio) VALUES 
(1, '2024-08-20 21:00:00'), -- Perf 1
(2, '2024-08-20 22:00:00'), -- Perf 2
(1, '2024-08-20 19:00:00'); -- Perf 3 (Coldplay sul Main)

-- Giorno 2: 2024-08-21
INSERT INTO Performance (ID_Palco, Data_Ora_Inizio) VALUES 
(4, '2024-08-21 21:00:00'), -- Perf 4 (Coldplay sul Beach)
(2, '2024-08-21 23:00:00'); -- Perf 5 (Peggy + Dua collab 1)

-- Giorno 3: 2024-08-22
INSERT INTO Performance (ID_Palco, Data_Ora_Inizio) VALUES 
(4, '2024-08-22 22:00:00'), -- Perf 6 (Peggy + Dua collab 2)
(3, '2024-08-22 18:00:00'); -- Perf 7
-- --------------------------------------------------------------------------------
-- 4. Popolamento Lineup (Associazione Artisti -> Performance)
-- Qui gestiamo chi suona e se ci sono ospiti
-- Associazioni Lineup
INSERT INTO Lineup (ID_Performance, ID_Artista, Tipo_Presenza) VALUES 
(1, 1, 'Principale'), -- Radiohead
(2, 3, 'Principale'), -- Calvin Harris
(3, 6, 'Principale'), -- Coldplay (Main Stage)
(4, 6, 'Principale'), -- Coldplay (Beach Stage -> Query 3 OK)
(5, 7, 'Principale'), (5, 2, 'Ospite'), -- Peggy + Dua (Collab 1)
(6, 7, 'Principale'), (6, 2, 'Ospite'), -- Peggy + Dua (Collab 2 -> Query 6 OK)
(7, 5, 'Principale'); -- Angèle
-- --------------------------------------------------------------------------------
-- 5. Popolamento Spettatori
INSERT INTO Spettatori (Nome, Email) VALUES 
('Marco Rossi', 'marco@email.it'), ('Sofia Bianchi', 'sofia@email.it'),
('Alessandro Neri', 'ale@email.it'), ('Elena Verdi', 'elena@email.it'),
('Giulia Gialli', 'giulia@email.it'), ('Luca Bruno', 'luca@email.it');
-- --------------------------------------------------------------------------------
-- 6. Popolamento Biglietti
INSERT INTO Biglietti (ID_Spettatore, Tipo_Biglietto, Prezzo, Stato_Pagamento) VALUES 
(1, 'VIP', 120.00, 'Pagato'),
(2, 'Standard', 65.50, 'Pagato'),
(3, 'Early Bird', 45.00, 'In Attesa'),
(4, 'Standard', 65.50, 'Annullato');

-- Vendite Giorno 1 (Tot 185.50)
INSERT INTO Biglietti (ID_Spettatore, Tipo_Biglietto, Prezzo, Stato_Pagamento, Data_Acquisto) VALUES 
(1, 'VIP', 120.00, 'Pagato', '2024-08-20 10:00:00'),
(2, 'Standard', 65.50, 'Pagato', '2024-08-20 11:00:00');

-- Vendite Giorno 2 (Tot 300.00 -> Incremento per Query 9)
INSERT INTO Biglietti (ID_Spettatore, Tipo_Biglietto, Prezzo, Stato_Pagamento, Data_Acquisto) VALUES 
(3, 'VIP', 150.00, 'Pagato', '2024-08-21 09:00:00'),
(4, 'VIP', 150.00, 'Pagato', '2024-08-21 10:00:00');

-- Vendite Giorno 3 (Tot 50.00 -> Calo per Query 9)
INSERT INTO Biglietti (ID_Spettatore, Tipo_Biglietto, Prezzo, Stato_Pagamento, Data_Acquisto) VALUES 
(5, 'Standard', 50.00, 'Pagato', '2024-08-22 15:00:00');
-- --------------------------------------------------------------------------------
-- 7. Popolamento Sponsor
INSERT INTO Sponsor (Nome_Sponsor, Contributo_Euro, ID_Performance_Esclusiva) VALUES 
('Global Drink', 10000.00, 1), -- 20 Agosto
('Global Drink', 10000.00, 5), -- 21 Agosto
('Global Drink', 10000.00, 6); -- 22 Agosto
-- --------------------------------------------------------------------------------
-- 8. Popolamento Staff
INSERT INTO Staff (Nome, Ruolo, ID_Palco_Assegnato) VALUES 
('Giorgio Vanni', 'Fonico di palco', 1),
('Luca Luce', 'Light Designer', 1),
('Anna Cavi', 'Tecnico Audio', 2),
('Paolo Sicuro', 'Responsabile Sicurezza', 3);
-- --------------------------------------------------------------------------------