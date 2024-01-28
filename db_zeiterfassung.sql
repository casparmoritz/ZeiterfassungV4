-- create Database

create DATABASE db_zeiterfassung;

use db_zeiterfassung;

-- create tables

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

-- when somthing is deleted this code is called
DELIMITER //

CREATE TRIGGER delete_related_rows_tbl_passwort
BEFORE DELETE ON tbl_passwort
FOR EACH ROW
BEGIN
    DECLARE v_MitarbeiterNr INT;
    SET v_MitarbeiterNr = OLD.MitarbeiterNr;

    -- Lösche Zeilen in tbl_zeit
    DELETE FROM tbl_zeit WHERE MitarbeiterNr = v_MitarbeiterNr;

    -- Lösche Zeilen in tbl_mitarbeiter
    DELETE FROM tbl_mitarbeiter WHERE mitarbeiter_id = v_MitarbeiterNr;

    -- Speichere die MitarbeiterNr in einer temporären Tabelle
    CREATE TEMPORARY TABLE tmp_deleted_mitarbeiter (MitarbeiterNr INT);
    INSERT INTO tmp_deleted_mitarbeiter VALUES (v_MitarbeiterNr);

    -- Lösche Zeilen in tbl_rfidchips nach dem Trigger
    DELETE FROM tbl_rfidchips WHERE MitarbeiterNr IN (SELECT MitarbeiterNr FROM tmp_deleted_mitarbeiter);

    -- Lösche Zeilen in tbl_passwort nach dem Trigger
    DELETE FROM tbl_passwort WHERE MitarbeiterNr IN (SELECT MitarbeiterNr FROM tmp_deleted_mitarbeiter);
END;
//

DELIMITER ;



