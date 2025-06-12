ALTER TABLE glumac
ADD Nadimak NVARCHAR(20);
CREATE TABLE zaposleni
(
    ZaposleniID INT PRIMARY KEY,
    Ime NVARCHAR(30) NOT NULL,
    Prezime NVARCHAR(30) NOT NULL,
    Telefon NVARCHAR(15) NOT NULL,
    Adresa NVARCHAR(50) NOT NULL
);
CREATE TABLE posudba
(
    PosudbaID INT PRIMARY KEY,
    FilmID INT NOT NULL,
    FOREIGN KEY (FilmID) REFERENCES film(FilmID),
    ZaposleniID INT NOT NULL,
    FOREIGN KEY (ZaposleniID) REFERENCES zaposleni(ZaposleniID),
    Datum_posudbe DATE NOT NULL,
    Datum_vracanja DATE,
    Status NVARCHAR(10) NOT NULL CHECK (Status IN ('Slobodan', 'Zauzet'))
);
