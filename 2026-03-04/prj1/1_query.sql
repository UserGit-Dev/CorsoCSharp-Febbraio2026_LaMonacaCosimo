USE FestivalMusicale;

-- QUERY 1: Numero di performance per artista
-- Uso LEFT JOIN per vedere anche gli artisti che non hanno ancora performance assegnate
SELECT A.Nome_Darte, COUNT(L.ID_Performance) AS Tot_Performance
FROM Artisti A
LEFT JOIN Lineup L ON A.ID_Artista = L.ID_Artista
GROUP BY A.ID_Artista, A.Nome_Darte;
-- --------------------------------------------------------------------------------
-- QUERY 2: Totale incasso per giorno del festival
-- Consideriamo solo i biglietti pagati per avere un dato reale
SELECT DATE(Data_Acquisto) AS Giorno, SUM(Prezzo) AS Incasso_Giornaliero
FROM Biglietti
WHERE Stato_Pagamento = 'Pagato'
GROUP BY DATE(Data_Acquisto);
-- --------------------------------------------------------------------------------
-- QUERY 3: Artisti che si sono esibiti su più di un palco
SELECT A.Nome_Darte, COUNT(DISTINCT P.ID_Palco) AS Numero_Palchi
FROM Artisti A
JOIN Lineup L ON A.ID_Artista = L.ID_Artista
JOIN Performance P ON L.ID_Performance = P.ID_Performance
GROUP BY A.ID_Artista, A.Nome_Darte
HAVING Numero_Palchi > 1;
-- --------------------------------------------------------------------------------
-- QUERY 4: Palco con il maggior numero di spettatori totali
-- Uniamo i biglietti alle performance tramite la data
SELECT PL.Nome_Palco, COUNT(B.ID_Biglietto) AS Tot_Spettatori
FROM Palchi PL
JOIN Performance Perf ON PL.ID_Palco = Perf.ID_Palco
JOIN Biglietti B ON DATE(Perf.Data_Ora_Inizio) = DATE(B.Data_Acquisto)
GROUP BY PL.ID_Palco, PL.Nome_Palco
ORDER BY Tot_Spettatori DESC 
LIMIT 1;
-- --------------------------------------------------------------------------------
-- QUERY 5: Artista che ha generato il maggior incasso in biglietti
-- Colleghiamo gli artisti ai biglietti venduti nella stessa data delle loro performance
SELECT A.Nome_Darte, SUM(B.Prezzo) AS Incasso_Generato
FROM Artisti A
JOIN Lineup L ON A.ID_Artista = L.ID_Artista
JOIN Performance P ON L.ID_Performance = P.ID_Performance
JOIN Biglietti B ON DATE(P.Data_Ora_Inizio) = DATE(B.Data_Acquisto)
WHERE B.Stato_Pagamento = 'Pagato'
GROUP BY A.ID_Artista, A.Nome_Darte
ORDER BY Incasso_Generato DESC 
LIMIT 1;
-- --------------------------------------------------------------------------------
-- QUERY 6: Coppie di artisti che hanno collaborato almeno 2 volte
-- Usiamo una self-join sulla tabella Lineup (stessa performance, artisti diversi)
SELECT A1.Nome_Darte AS Artista_A, A2.Nome_Darte AS Artista_B, COUNT(*) AS Volte_Insieme
FROM Lineup L1
JOIN Lineup L2 ON L1.ID_Performance = L2.ID_Performance AND L1.ID_Artista < L2.ID_Artista
JOIN Artisti A1 ON L1.ID_Artista = A1.ID_Artista
JOIN Artisti A2 ON L2.ID_Artista = A2.ID_Artista
GROUP BY L1.ID_Artista, L2.ID_Artista, A1.Nome_Darte, A2.Nome_Darte
HAVING Volte_Insieme >= 2;
-- --------------------------------------------------------------------------------
-- QUERY 7: Sponsor con performance in almeno 3 giorni diversi
SELECT S.Nome_Sponsor, COUNT(DISTINCT DATE(P.Data_Ora_Inizio)) AS Giorni_Coperti
FROM Sponsor S
JOIN Performance P ON S.ID_Performance_Esclusiva = P.ID_Performance
GROUP BY S.Nome_Sponsor
HAVING Giorni_Coperti >= 3;
-- --------------------------------------------------------------------------------
-- QUERY 8: Palco con l'incasso più alto per ogni giorno
WITH IncassiPalco AS (
    SELECT DATE(Perf.Data_Ora_Inizio) as Giorno, PL.Nome_Palco, SUM(B.Prezzo) as Incasso
    FROM Palchi PL
    JOIN Performance Perf ON PL.ID_Palco = Perf.ID_Palco
    JOIN Biglietti B ON DATE(Perf.Data_Ora_Inizio) = DATE(B.Data_Acquisto)
    GROUP BY Giorno, PL.Nome_Palco
)
SELECT Giorno, Nome_Palco, Incasso
FROM IncassiPalco I1
WHERE Incasso = (SELECT MAX(Incasso) FROM IncassiPalco I2 WHERE I1.Giorno = I2.Giorno);
-- --------------------------------------------------------------------------------
-- QUERY 9: Variazione percentuale di incasso giorno per giorno
-- Utilizzo il LAG (nuovamente) per recuperare il valore del giorno precedente
SELECT 
    Giorno, 
    Incasso_Giornaliero,
    LAG(Incasso_Giornaliero) OVER (ORDER BY Giorno) AS Incasso_Ieri,
    ((Incasso_Giornaliero - LAG(Incasso_Giornaliero) OVER (ORDER BY Giorno)) 
    / NULLIF(LAG(Incasso_Giornaliero) OVER (ORDER BY Giorno), 0) * 100) AS Variazione_Perc
FROM (
    SELECT DATE(Data_Acquisto) AS Giorno, SUM(Prezzo) AS Incasso_Giornaliero
    FROM Biglietti
    WHERE Stato_Pagamento = 'Pagato'
    GROUP BY Giorno
) AS TabellaIncassi;