-- create Database

create DATABASE db_zeiterfassung;

use db_zeiterfassung;

-- create tables

create table tbl_zeit
(
    MitarbeiterNr int PRIMARY KEY not null,
    `Zeit_kommen` time,
    `Zeit_gehen`time
);

CREATE TABLE tbl_mitarbeiter (
    mitarbeiterNr INT PRIMARY KEY NOT NULL,
    vorname VARCHAR(50),
    nachname VARCHAR(50)
);
 
create table tbl_passwort
(
    MitarbeiterNr INT PRIMARY KEY NOT NULL,
    passwort varchar (15)
);

create TABLE tbl_rfidchips
(
    MitarbeiterNr int PRIMARY KEY NOT NULL,
    UID char(7)
);
