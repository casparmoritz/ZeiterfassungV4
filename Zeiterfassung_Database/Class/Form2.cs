using System;
using System.Data;
using System.Text;
using System.Windows.Forms;
using MySqlConnector;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO.Ports;
using Zeiterfassung_Database.Class;
using TaschenrechnerForms;
using System.Linq;
using System.Security.Cryptography;

namespace Zeiterfassung_Database.Class
{
    public partial class Form2 : Form
    {
        string connectionString = "SERVER=localhost; DATABASE=db_zeiterfassung; UID=root; PASSWORD=;";

        private SerialPort serialPort;
        private DatabaseHelper dbHelper;

        public Form2()
        {
            InitializeComponent();
            serialPort = new SerialPort("COM3", 9600);
            serialPort.DataReceived += SerialPort_DataReceived;
            serialPort.Open();
            dbHelper = new DatabaseHelper();
        }

        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string uid = serialPort.ReadLine();

            string cleanedUID = uid.Trim();
            string uidWithoutPrefix = cleanedUID.Replace("UID: ", "");

            if (textBox_uid.InvokeRequired)
            {
                textBox_uid.Invoke((Action)(() => textBox_uid.Text = uidWithoutPrefix));
            }
            else
            {
                textBox_uid.Text = uidWithoutPrefix;
            }
        }
        private void CloseSerialPort()
        {
            if (serialPort.IsOpen)
            {
                serialPort.Close();
                serialPort.DataReceived -= SerialPort_DataReceived;
            }
        }

        private void button_schließen_Click(object sender, EventArgs e)
        {
            CloseSerialPort();

            Form1 form1 = new Form1();
            form1.Show();

            this.Close();
        }
        private void button_loeschen_Click(object sender, EventArgs e)
        {
            textBox_mitarbeiterNr.Text = string.Empty;
            textBox_nachname.Text = string.Empty;
            textBox_passwort.Text = string.Empty;
            textBox_passwort_bestaetigen.Text = string.Empty;
            textBox_vorname.Text = string.Empty;
            textBox_uid.Text = string.Empty;
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button_speichern_Click(object sender, EventArgs e)
        {
            if (textBox_passwort.Text != textBox_passwort_bestaetigen.Text)
            {
                MessageBox.Show("Ihre Passwörter stimmen nicht miteinander ein!");
            }
            else
            {
                string uidToCheck = textBox_uid.Text;

                string checkUidQuery = "SELECT COUNT(*) FROM tbl_rfidchips WHERE uid = @uid";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(checkUidQuery, connection))
                    {
                        command.Parameters.AddWithValue("@uid", uidToCheck);
                        int count = Convert.ToInt32(command.ExecuteScalar());

                        if (count > 0)
                        {
                            MessageBox.Show("Die UID existiert bereits in der Datenbank.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }

                string query = $"INSERT INTO tbl_mitarbeiter (MitarbeiterNr, Vorname, Nachname) values (@MitarbeiterNr, @Vorname, @Nachname);" +
                               $"INSERT INTO tbl_passwort (MitarbeiterNr, passwort) values (@MitarbeiterNr, @passwort);" +
                               $"INSERT INTO tbl_rfidchips (MitarbeiterNr, uid) values (@MitarbeiterNr, @uid);";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MitarbeiterNr", textBox_mitarbeiterNr.Text);
                        command.Parameters.AddWithValue("@Vorname", textBox_vorname.Text);
                        command.Parameters.AddWithValue("@Nachname", textBox_nachname.Text);
                        command.Parameters.AddWithValue("@passwort", textBox_passwort.Text);
                        command.Parameters.AddWithValue("@uid", uidToCheck);

                        command.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Der Mitarbeiter wurde erfolgreich in die Datenbank aufgenommen!");
            }
        }
    }
}
