SELECT ArtistName, YearEstablished
FROM Artist
WHERE YearEstablished > 1970 
AND YearEstablished < 2000
ORDER BY YearEstablished DESC
;

SELECT a.Title,
			a.AlbumLength,
			a.Label,  
			ar.ArtistName,
			ar.YearEstablished,
			g.Label AS GenreLabel
FROM Album a
JOIN Artist  ar ON a.ArtistId = ar.ArtistId
JOIN Genre g ON a.GenreId = g.GenreId
;

SELECT * 
FROM Song s
JOIN Album al ON al.ALbumId = s.AlbumId
JOIN Artist  ar ON ar.ArtistId= s.ArtistId
JOIN Genre g ON g.GenreId = s.GenreId
;


INSERT INTO Artist 
(ArtistName, YearEstablished)
VALUES 
("Bowling for soup", 2000)
;


SELECT * FROM Artist;

DELETE FROM Artist WHERE ArtistId = 28;

UPDATE Artist 
	SET ArtistName = "Bowling for yummy Soup"
	WHERE ArtistId = 32
	;
	
SELECT *
FROM Album a
LEFT JOIN Song s ON s.AlbumId = a.AlbumId
;

--#1
SELECT * 
FROM Genre
;
--#2
INSERT INTO Artist
(ArtistName, YearEstablished)
VALUES
("New artist", 1998)
;
 --#3
 
 INSERT INTO Album 
 (Title, ReleaseDate, AlbumLength, Label, ArtistId, GenreId)
 VALUES 
 ("Bloop", "2/11/2018", 12, "Dejan Inc.", 33, 6)
;

--#4 

INSERT INTO Song
(Title, SongLength, ReleaseDate, GenreId, ArtistId, AlbumId)
VALUES 
("Song 1", 345, 12/1/1997, 6, 33, 23)
;

INSERT INTO Song
(Title, SongLength, ReleaseDate, GenreId, ArtistId, AlbumId)
VALUES 
("Song 2", 765, 1/14/2009, 6, 33, 23)
;

UPDATE Song 
	SET ReleaseDate = "1/9/2010"
	WHERE SongId = 22
	;
	
SELECT g.Label, COUNT(al.AlbumId) AS AlbumCount
FROM Genre g
JOIN Album al ON al.GenreId = g.GenreId
GROUP BY g.Label
ORDER BY AlbumCount DESC
LIMIT 1
;

SELECT al.Title,
			MAX(al.AlbumLength)
FROM Album al
;

--5
SELECT a.Title, s.Title 
FROM Song s 
LEFT JOIN Album a 
ON s.AlbumId = a.AlbumId 
JOIN Artist ar
ON s.ArtistId =ar.ArtistId
WHERE ar.ArtistId = 33
;

--6
SELECT al.Title, COUNT(s.AlbumId) AS SongsInAlbum 
FROM Album al
JOIN Song s ON s.AlbumId = al.AlbumId 
GROUP BY al.Title
ORDER BY SongsInAlbum DESC
;

--7
--Write a SELECT statement to display how many songs exist for each artist. 
--You'll need to use the COUNT() function and the GROUP BY keyword sequence.
SELECT a.ArtistName, COUNT(s.ArtistId) AS SongsArtistHas
FROM Artist a
JOIN Song s ON a.ArtistId  = s.ArtistId
GROUP BY a.ArtistName
ORDER BY SongsArtistHas DESC
;

--8
--Write a SELECT statement to display how many songs exist for each genre. 
--You'll need to use the COUNT() function and the GROUP BY keyword sequence.
SELECT g.Label, COUNT(s.GenreId) AS SongsForEachG
FROM Genre g 
JOIN Song s ON s.GenreId = g.GenreId
GROUP BY g.Label
ORDER BY SongsForEachG DESC
;

--10
SELECT s.Title,
			MAX(s.SongLength)
FROM Song s
;

--11
--Modify the previous query to also display the title of the album.
SELECT s.Title,
			MAX(s.SongLength),
			al.Title
FROM Song s
JOIN Album al ON s.AlbumId = al.AlbumId
;
