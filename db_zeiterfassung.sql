--create Database

create DATABASE db_zeiterfassung;

use db_zeiterfassung;

--create tables

create table tbl_zeit
(
    ID int PRIMARY KEY NOT NULL,
    MitarbeiterNr int,
   	Vorname varchar(30),
    Nachname varchar(50),
    `Zeit_kommen` time,
    `Zeit_gehen`time
);

CREATE TABLE tbl_mitarbeiter (
    mitarbeiter_id INT PRIMARY KEY NOT NULL,
    vorname VARCHAR(50),
    nachname VARCHAR(50),
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

-- fill Database

Insert into tbl_mitarbeiter (MitarbeiterNr, vorname, nachname) 
values 
(1, "Caspar", "Schweikart"), 
(2, "Oliver", "Schweikart");

insert into tbl_passwort (MitarbeiterNr, passwort) values 
    (1, "chef"),
    (2, "2892");

insert into tbl_rfidchips (MitarbeiterNr, UID) values 
    (1, "d92dba4"),
    (2, "76bfd25");

--when insert in tbl_mitarbeiter insert standart password
DELIMITER //
CREATE TRIGGER employee_insert_trigger
AFTER INSERT ON tbl_mitarbeiter
FOR EACH ROW
BEGIN
  INSERT INTO tbl_passwort (MitarbeiterNr, Passwort)
  VALUES (NEW.MitarbeiterNr, '123');
END;
//
DELIMITER ;
