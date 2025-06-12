CREATE TABLE Skola
(
    SkolaID INT PRIMARY KEY,
    Naziv NVARCHAR(50) NOT NULL,
    Mesto NVARCHAR(50) NOT NULL,
    Adresa NVARCHAR(100) NOT NULL
);
ALTER TABLE Primerak
ADD SkolaID INT NOT NULL REFERENCES Skola(SkolaID),
    Datum_nabavke DATE NOT NULL,
    CONSTRAINT CHK_DatumNabavke CHECK (Datum_nabavke >= '2000-01-01');
