﻿CREATE TABLE ODGAJIVAC
(
    odgajivac_id INT PRIMARY KEY,
    ime NVARCHAR(50) NOT NULL,
    broj_telefona NVARCHAR(20) NOT NULL,
    email NVARCHAR(50),
    adresa NVARCHAR(100),
    drzava NVARCHAR(30)
);
ALTER TABLE PAS
ADD id_odgajivaca INT REFERENCES ODGAJIVAC(odgajivac_id);
ALTER TABLE RASA
ADD napomena NVARCHAR(100);
