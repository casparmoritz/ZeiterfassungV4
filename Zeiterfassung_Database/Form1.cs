using System;
using System.Data;
using System.Text;
using System.Windows.Forms;
using MySqlConnector;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO.Ports;
using Zeiterfassung_Database.Class;

namespace TaschenrechnerForms
{
    public partial class Form1 : Form
    {
        string connectionString = "SERVER=localhost; DATABASE=db_zeiterfassung; UID=root; PASSWORD=;";
        private SerialPort serialPort;

        public Form1()
        {
            InitializeComponent();
            serialPort = new SerialPort("COM3", 9600);
            serialPort.DataReceived += SerialPort_DataReceived;
            serialPort.Open();

            textBox_passwort.PasswordChar = '*';
        }

        #region Eventhandeler Methoden
        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string uid = serialPort.ReadLine();

            string cleanedUID = uid.Trim();
            string uidWithoutPrefix = cleanedUID.Replace("UID: ", "");

            RFIDScanned(uidWithoutPrefix);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Close();
            }
        }

        private void textBox_mitarbeiterNr_TextChanged(object sender, EventArgs e)
        {
            string query = "SELECT Vorname, Nachname FROM tbl_mitarbeiter where MitarbeiterNr = @MitarbeiterNr";

            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("MitarbeiterNr", textBox_mitarbeiterNr.Text);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            textBox_vorname.Text = reader["Vorname"].ToString();
                            textBox_nachname.Text = reader["Nachname"].ToString();

                        }
                    }
                }
            }
        }

        private void button_speichern_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM tbl_passwort where MitarbeiterNr = @MitarbeiterNr";

            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("MitarbeiterNr", textBox_mitarbeiterNr.Text);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (textBox_passwort.Text == reader["passwort"].ToString())
                            {
                                try
                                {
                                    using (var connection_1 = new MySqlConnection(connectionString))
                                    {
                                        connection_1.Open();
                                        string tableName = "tbl_zeit";
                                        string zeitSpalte = radioButton_gehen.Checked ? "Zeit_gehen" : "Zeit_kommen";
                                        SaveZeitData(connection_1, tableName, zeitSpalte);
                                    }
                                }
                                catch (MySqlException ex)
                                {
                                    MessageBox.Show($"Fehler beim Verbindungsaufbau zur MySQL-Datenbank: {ex.Message}");
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show($"Es ist ein Fehler aufgetreten: {ex.Message}");
                                }
                            }
                            else
                            {
                                MessageBox.Show($"Sie haben das falsche passwort für den Benutzer: {textBox_vorname.Text} {textBox_nachname.Text}");
                            }
                        }
                    }
                }
            }   
        }

        private void button_ausgabeMitarbeiter_Click(object sender, EventArgs e)
        {
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string tableName = "tbl_zeit";
                    string zeitSpalte = radioButton_gehen.Checked ? "Zeit_gehen" : "Zeit_kommen";
                    AusgabeMitarbeiterZeit(connection, tableName, zeitSpalte);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Fehler beim Verbindungsaufbau zur MySQL-Datenbank: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Es ist ein Fehler aufgetreten: {ex.Message}");
            }
        }

        private void button_loeschen_Click(object sender, EventArgs e)
        {
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string tableName = "tbl_zeit";
                    string zeitSpalte = radioButton_gehen.Checked ? "Zeit_gehen" : "Zeit_kommen";

                    DeleteDatensatz(connection, tableName, zeitSpalte);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Fehler beim Verbindungsaufbau zur MySQL-Datenbank: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Es ist ein Fehler aufgetreten: {ex.Message}");
            }
        }

        private void button_ausgabeDatenbank_Click(object sender, EventArgs e)
        {
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string tableName = "tbl_zeit";
                    string zeitSpalte = radioButton_gehen.Checked ? "Zeit_gehen" : "Zeit_kommen";
                    AusgabeAllerDaten(connection, tableName, zeitSpalte);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Fehler beim Verbindungsaufbau zur MySQL-Datenbank: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Es ist ein Fehler aufgetreten: {ex.Message}");
            }
        }
        #endregion

        #region extra Methoden
        private void RFIDScanned(string scannedUID)
        {
            DatabaseHelper dbHelper = new DatabaseHelper();

            string mitarbeiterNr = dbHelper.GetMitarbeiterNrFromUID(scannedUID);

            if (!string.IsNullOrEmpty(mitarbeiterNr))
            {
                this.Invoke((Action)(() => { 
                    textBox_mitarbeiterNr.Text = mitarbeiterNr;
                }));
            }
            else
            {
                MessageBox.Show("Mitarbeiter nicht gefunden!");
            }
        }

        private void AusgabeAllerDaten(MySqlConnection connection, string tableName, string zeitSpalte)
        {
            string query = $"SELECT * FROM {tableName} inner join tbl_mitarbeiter on {tableName}.MitarbeiterNr = tbl_mitarbeiter.MitarbeiterNr";

            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    if (dataTable.Rows.Count > 0)
                    {
                        StringBuilder dataStringBuilder = new StringBuilder();

                        foreach (DataRow row in dataTable.Rows)
                        {
                            string mitarbeiterNr = row["MitarbeiterNr"].ToString();
                            string vorname = row["Vorname"].ToString();
                            string nachname = row["Nachname"].ToString();
                            string zeit_kommen = row["Zeit_kommen"].ToString();
                            string zeit_gehen = row["Zeit_gehen"].ToString();


                            dataStringBuilder.AppendLine($"Ausgabe aller Datenbankdaten\n\nMitarbeiterNr: {mitarbeiterNr}\nVorname: {vorname}\nNachname: {nachname}\nZeit kommen: {zeit_kommen}\nZeit gehen: {zeit_gehen}\n-----------------------------------\n");
                        }

                        MessageBox.Show(dataStringBuilder.ToString());
                    }
                    else
                    {
                        MessageBox.Show("Keine Daten gefunden.");
                    }
                }
            }
        }

        private void DeleteDatensatz(MySqlConnection connection, string tableName, string zeitSpalte)
        {
            string query = $"DELETE FROM {tableName} WHERE MitarbeiterNR = @MitarbeiterNr";

            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@MitarbeiterNr", textBox_mitarbeiterNr.Text);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show($"Der Datensatz von Mitarbeiter Nummer: {textBox_mitarbeiterNr.Text} wurde erfolgreich entfernt!");
                }
                else
                {
                    MessageBox.Show($"Kein Datensatz mit Mitarbeiter Nummer: {textBox_mitarbeiterNr.Text} gefunden.");
                }
            }
        }

        private void AusgabeMitarbeiterZeit(MySqlConnection connection, string tableName, string zeitSpalte)
        {
            string query = "SELECT tbl_zeit.*, tbl_mitarbeiter.vorname, tbl_mitarbeiter.nachname " +
                           "FROM tbl_zeit INNER JOIN tbl_mitarbeiter " +
                           "ON tbl_zeit.MitarbeiterNr = tbl_mitarbeiter.MitarbeiterNr " +
                           "WHERE tbl_zeit.MitarbeiterNr = @MitarbeiterNr";

            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@MitarbeiterNr", textBox_mitarbeiterNr.Text);

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    if (dataTable.Rows.Count > 0)
                    {
                        StringBuilder dataStringBuilder = new StringBuilder();

                        foreach (DataRow row in dataTable.Rows)
                        {
                            string mitarbeiterNr = row["MitarbeiterNr"].ToString();
                            string vorname = row["vorname"].ToString();
                            string nachname = row["nachname"].ToString();
                            string zeit = row[zeitSpalte].ToString();

                            dataStringBuilder.AppendLine($"MitarbeiterNr: {mitarbeiterNr}\nVorname: {vorname}\nNachname: {nachname}\nZeit: {zeit}");
                        }

                        MessageBox.Show(dataStringBuilder.ToString());
                    }
                    else
                    {
                        MessageBox.Show("Keine Daten gefunden.");
                    }
                }
            }
        }

        private void SaveZeitData(MySqlConnection connection, string tableName, string zeitSpalte)
        {
            try
            {
                string query = $"SELECT MitarbeiterNr FROM {tableName} WHERE MitarbeiterNr = @MitarbeiterNr;";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@MitarbeiterNr", textBox_mitarbeiterNr.Text);
                    cmd.Parameters.AddWithValue("@Vorname", textBox_vorname.Text);
                    cmd.Parameters.AddWithValue("@Nachname", textBox_nachname.Text);

                    object existingMitarbeiterNr = cmd.ExecuteScalar();

                    if (existingMitarbeiterNr != null)
                    {
                        string updateQuery = $"UPDATE {tableName} SET {zeitSpalte} = NOW() WHERE MitarbeiterNr = @MitarbeiterNr";

                        using (MySqlCommand updateCmd = new MySqlCommand(updateQuery, connection))
                        {
                            updateCmd.Parameters.AddWithValue("@MitarbeiterNr", textBox_mitarbeiterNr.Text);
                            updateCmd.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        string insertQuery = $"INSERT INTO {tableName} (MitarbeiterNR, `{zeitSpalte}`) VALUES (@MitarbeiterNr, NOW())";

                        using (MySqlCommand insertCmd = new MySqlCommand(insertQuery, connection))
                        {
                            insertCmd.Parameters.AddWithValue("@MitarbeiterNr", textBox_mitarbeiterNr.Text);
                            insertCmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Die Daten wurden erfolgreich in der Datenbank gespeichert!");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Ungültiges Zeitformat. Bitte verwenden Sie das Format 'HH:mm:ss'.");
            }
        }
        #endregion
    }
}
