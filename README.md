In this program, interfaces between C#, MySql and Arduino were created.
A database is created in MySql, which consists of 4 tables and stores the times when someone has come and gone.
In addition, passwords are stored for the respective employees so that no "stranger" enters themselves as this employee as "coming" or "going".

An RFID chip interface is created using the Arduino Mega 2560 with an RFID RC-522, with which only the RFID chip or the RFID card is scanned on the reader 
is scanned and everything except the appropriate password is automatically entered in the user interface of the C# program.
