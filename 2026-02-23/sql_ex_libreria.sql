CREATE DATABASE libreria;
USE libreria;

CREATE TABLE libri (
id INT,
titolo VARCHAR(100),
autore VARCHAR(100),
genere VARCHAR(50),
prezzo DECIMAL(10,2),
anno_pubblicazione INT,
PRIMARY KEY(id)
);

INSERT INTO libri VALUES 
(1, "Titolo A", "Autore A", "Genere A", 10, 2021),
(2, "Titolo B", "Autore B", "Genere B", 20, 2022),
(3, "Titolo C", "Autore C", "Genere C", 30, 2023),
(4, "Titolo D", "Autore D", "Genere D", 40, 2024),
(5, "Titolo E", "Autore E", "Genere E", 50, 2025),
(6, "Titolo F", "Autore F", "Genere F", 60, 2026);

SELECT genere, COUNT(*) AS totale_libri, AVG(prezzo) AS media_prezzo FROM libri GROUP BY genere ORDER BY genere ASC;
SELECT * FROM libri WHERE anno_pubblicazione >  2010 ORDER BY anno_pubblicazione DESC, prezzo ASC;
-- ==================================================
CREATE TABLE vendite (
	id INT,
    prodotto VARCHAR(100),
    categoria VARCHAR(50),
    quantita INT,
    prezzo_unitario DECIMAL(6,2),
    data_vendita DATE,
    PRIMARY KEY(id)
);

INSERT INTO vendite (id, prodotto, categoria, quantita, prezzo_unitario, data_vendita) VALUES
(1, 'Prodotto A', 'Categoria A', 5, 12.50, '2026-01-01'),
(2, 'Prodotto B', 'Categoria B', 2, 25.00, '2026-01-02'),
(3, 'Prodotto C', 'Categoria C', 10, 5.99, '2026-01-03'),
(4, 'Prodotto D', 'Categoria A', 1, 45.00, '2026-01-04'),
(5, 'Prodotto E', 'Categoria B', 3, 15.75, '2026-01-05'),
(6, 'Prodotto F', 'Categoria C', 7, 8.20, '2026-01-06'),
(7, 'Prodotto G', 'Categoria A', 4, 22.00, '2026-01-07'),
(8, 'Prodotto H', 'Categoria B', 6, 11.30, '2026-01-08'),
(9, 'Prodotto I', 'Categoria C', 2, 30.00, '2026-01-09'),
(10, 'Prodotto J', 'Categoria A', 8, 9.50, '2026-01-10'),
(11, 'Prodotto K', 'Categoria B', 5, 18.00, '2026-01-11'),
(12, 'Prodotto L', 'Categoria C', 12, 4.50, '2026-01-12'),
(13, 'Prodotto M', 'Categoria A', 3, 55.00, '2026-01-13'),
(14, 'Prodotto N', 'Categoria B', 1, 100.00, '2026-01-14'),
(15, 'Prodotto O', 'Categoria C', 9, 6.75, '2026-01-15'),
(16, 'Prodotto P', 'Categoria A', 2, 14.90, '2026-01-16'),
(17, 'Prodotto Q', 'Categoria B', 4, 33.00, '2026-01-17'),
(18, 'Prodotto R', 'Categoria C', 6, 19.99, '2026-01-18'),
(19, 'Prodotto S', 'Categoria A', 10, 12.00, '2026-01-19'),
(20, 'Prodotto T', 'Categoria B', 3, 27.50, '2026-01-20');

-- 1. Totale vendite per categoria
SELECT categoria, SUM(quantita * prezzo_unitario) AS totale_incassato FROM vendite GROUP BY categoria;
-- 2. Prezzo medio per categoria
SELECT categoria, AVG(prezzo_unitario) AS prezzo_medio FROM vendite GROUP BY categoria;
-- 3. Quantità totale venduta per ogni prodotto
SELECT prodotto, SUM(quantita) AS totale_quantita FROM vendite GROUP BY prodotto;
-- 4. Prezzo massimo e minimo venduto nella tabella
SELECT MAX(prezzo_unitario) AS prezzo_massimo, MIN(prezzo_unitario) AS prezzo_minimo FROM Vendite;
-- 5. Numero totale di vendite nella tabella
SELECT SUM(quantita) AS totale_vendite FROM vendite;
-- 6. I 5 prodotti più costosi (in base al prezzo_unitario)
SELECT * FROM vendite ORDER BY prezzo_unitario DESC LIMIT 5;
-- 7. I 3 prodotti meno venduti per quantità totale
SELECT prodotto, SUM(quantita) as quantita FROM vendite GROUP BY prodotto ORDER BY quantita ASC LIMIT 3;
-- ==================================================
CREATE TABLE clienti (
	id INT,
    nome VARCHAR(100),
    cognome VARCHAR(100),
    email VARCHAR(100),
    eta INT,
    citta VARCHAR(100),
    PRIMARY KEY (id)
);

INSERT INTO clienti (id, nome, cognome, email, eta, citta) VALUES
(1, 'Mario', 'Rossi', 'mario.rossi@gmail.com', 25, 'Roma'),
(2, 'Luigi', 'Verdi', 'luigi.verdi@outlook.com', 30, 'Milano'),
(3, 'Anna', 'Bianchi', 'anna.bianchi@yahoo.com', 22, 'Napoli'),
(4, 'Paolo', 'Neri', 'p.neri@gmail.com', 45, 'Torino'),
(5, 'Elena', 'Gialli', 'elena.gialli@outlook.com', 28, 'Firenze'),
(6, 'Marco', 'Russo', 'russo.marco@yahoo.com', 35, 'Palermo'),
(7, 'Giulia', 'Ferrari', 'g.ferrari@gmail.com', 19, 'Bologna'),
(8, 'Luca', 'Esposito', 'esposito.luca@outlook.com', 50, 'Genova'),
(9, 'Sara', 'Romano', 'sara_romano@yahoo.com', 27, 'Venezia'),
(10, 'Davide', 'Gallo', 'davide.gallo@gmail.com', 33, 'Bari'),
(11, 'Chiara', 'Costa', 'c.costa@outlook.com', 24, 'Verona'),
(12, 'Antonio', 'Fontana', 'antonio84@yahoo.com', 40, 'Messina'),
(13, 'Sofia', 'Ricci', 'sofia.ricci@gmail.com', 21, 'Padova'),
(14, 'Federico', 'Lombardi', 'f.lombardi@outlook.com', 38, 'Trieste'),
(15, 'Marta', 'Moretti', 'marta.moretti@yahoo.com', 29, 'Brescia'),
(16, 'Giovanni', 'Marini', 'g.marini@gmail.com', 42, 'Taranto'),
(17, 'Beatrice', 'Barbieri', 'b.barbieri@outlook.com', 26, 'Parma'),
(18, 'Riccardo', 'Serra', 'serra.riccardo@yahoo.com', 31, 'Prato'),
(19, 'Silvia', 'Conte', 'silvia.conte@gmail.com', 36, 'Modena'),
(20, 'Alessandro', 'De Luca', 'a.deluca@outlook.com', 48, 'Reggio Calabria');

-- 1. Clienti con email su dominio Gmail (@gmail.com)
SELECT * FROM clienti WHERE email LIKE '%@gmail.com';
-- 2. Clienti con nome che inizia con la lettera 'A'
SELECT * FROM clienti WHERE nome LIKE 'A%';
-- 3. Clienti con cognome che contiene esattamente 5 lettere
SELECT * FROM clienti WHERE LENGTH(cognome) = 5;
-- 4. Clienti con età compresa tra 30 e 40 anni (inclusi)
SELECT * FROM clienti WHERE eta BETWEEN 30 AND 40;
-- 5. Clienti che vivono in città il cui nome contiene 'roma' (maiuscole/minuscole ignorate)
SELECT * FROM clienti WHERE LOWER(citta) LIKE '%roma%';
-- ==================================================
CREATE TABLE clienti (
id INT,
nome VARCHAR(100),
citta VARCHAR(100),
PRIMARY KEY(id)
);

CREATE TABLE ordini(
id INT,
id_cliente INT,
data_ordine DATE,
importo DECIMAL(10,2),
PRIMARY KEY(id),
FOREIGN KEY (id_cliente) REFERENCES clienti(id)
);

INSERT INTO clienti (id, nome, citta) VALUES
(1, 'Mario Rossi', 'Milano'),
(2, 'Luigi Verdi', 'Roma'),
(3, 'Giovanna Bianchi', 'Napoli'),
(4, 'Anna Neri', 'Torino'),
(5, 'Roberto Gialli', 'Firenze'),
(6, 'Lucia Viola', 'Bologna'),
(7, 'Stefano Blu', 'Genova'),
(8, 'Elena Arancio', 'Venezia'),
(9, 'Paolo Marrone', 'Palermo'),
(10, 'Giulia Rosa', 'Bari');

INSERT INTO ordini (id, id_cliente, data_ordine, importo) VALUES
(101, 1, '2024-01-10', 50.50),
(102, 1, '2024-02-15', 120.00),
(103, 2, '2024-01-12', 75.00),
(104, 4, '2024-03-01', 30.00),
(105, 4, '2024-03-10', 45.00),
(106, 4, '2024-03-20', 15.00),
(107, 5, '2024-01-05', 200.00),
(108, 5, '2024-02-05', 150.00),
(109, 5, '2024-03-05', 100.00),
(110, 5, '2024-04-05', 50.00);

-- 1.
SELECT c.nome, o.data_ordine, o.importo 
FROM clienti AS c 
INNER JOIN ordini AS o ON c.id = o.id_cliente;

-- 2. 
SELECT c.nome, o.data_ordine, o.importo 
FROM clienti AS c 
LEFT JOIN ordini AS o ON c.id = o.id_cliente;

-- 3.
SELECT c.nome, o.data_ordine, o.importo 
FROM clienti AS c
RIGHT JOIN ordini AS o ON c.id = o.id_cliente;
-- ==================================================
-- 1.
SELECT c.nome, COUNT(*) AS totale_ordini, SUM(o.importo) AS totale_somma 
FROM clienti AS c 
INNER JOIN ordini AS o ON c.id = o.id_cliente
GROUP BY c.id;
-- 2.
SELECT nome, citta
FROM clienti
LEFT JOIN ordini AS o ON clienti.id = o.id_cliente
WHERE o.id IS NULL;
-- 3.
SELECT nome, citta
FROM clienti
RIGHT JOIN ordini AS o ON clienti.id = o.id_cliente
WHERE clienti.id IS NULL;
-- ==================================================
CREATE TABLE libri (
id INT,
titolo VARCHAR(100),
autore VARCHAR(100),
genere VARCHAR(50),
anno_pubblicazione INT,
prezzo DECIMAL(10,2),
PRIMARY KEY(id)
);

CREATE TABLE vendite (
	id INT,
    id_libro INT,
    data_vendita DATE,
    quantita INT,
    negozio VARCHAR(100),    
    PRIMARY KEY(id)
);

INSERT INTO libri (id, titolo, autore, genere, anno_pubblicazione, prezzo) VALUES
(1, 'It', 'Stephen King', 'Horror', 1986, 22.00),
(2, 'Shining', 'Stephen King', 'Horror', 1977, 14.50),
(3, 'Misery', 'Stephen King', 'Thriller Psicologico', 1987, 13.00),
(4, '22/11/''63', 'Stephen King', 'Fantascienza', 2011, 25.00),
(5, 'Il Signore degli Anelli', 'J.R.R. Tolkien', 'Fantasy', 1954, 30.00),
(6, '1984', 'George Orwell', 'Distopia', 1949, 12.50),
(7, 'Il Nome della Rosa', 'Umberto Eco', 'Giallo Storico', 1980, 16.00),
(8, 'Harry Potter e la Pietra Filosofale', 'J.K. Rowling', 'Fantasy', 1997, 15.00),
(9, 'Sapiens: Da animali a dèi', 'Yuval Noah Harari', 'Saggistica', 2011, 21.00),
(10, 'Il Piccolo Principe', 'Antoine de Saint-Exupéry', 'Favola', 1943, 8.00);

INSERT INTO vendite (id, id_libro, data_vendita, quantita, negozio) VALUES
(1, 1, '2024-01-10', 5, 'Amazon'),
(2, 2, '2024-01-11', 2, 'Libreria Centrale'),
(3, 5, '2024-01-12', 1, 'Feltrinelli'),
(4, 3, '2024-01-12', 3, 'Mondadori Store'),
(5, 8, '2024-01-13', 10, 'Amazon'),
(6, 4, '2024-01-14', 2, 'Libreria del Porto'),
(7, 1, '2024-01-15', 1, 'Feltrinelli'),
(8, 7, '2024-01-16', 4, 'Mondadori Store'),
(9, 6, '2024-01-17', 2, 'Libreria Centrale'),
(10, 10, '2024-01-18', 6, 'Amazon');

-- 1.
SELECT titolo, anno_pubblicazione, prezzo, data_vendita FROM libri
INNER JOIN vendite ON libri.id = vendite.id_libro
WHERE LOWER(libri.autore) LIKE '%king%';

-- 2.
SELECT titolo, anno_pubblicazione, prezzo, data_vendita FROM libri
INNER JOIN vendite ON libri.id = vendite.id_libro
WHERE libri.anno_pubblicazione BETWEEN 2000 AND 2010;

-- 3.
SELECT l.titolo, v.negozio, SUM(v.quantita * l.prezzo) as prezzo_totale FROM libri AS l
INNER JOIN vendite AS v ON l.id = v.id_libro
WHERE LOWER(v.negozio) IN ('libreria centrale','bookcity milano','cartoleria roma')
GROUP BY l.titolo, v.negozio;
-- ==================================================






