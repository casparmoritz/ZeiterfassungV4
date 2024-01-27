using System;
using System.Data;
using System.Text;
using System.Windows.Forms;
using MySqlConnector;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO.Ports;

namespace Zeiterfassung_Database.Class
{
    public class DatabaseHelper
    {
        string connectionString = "SERVER=localhost; DATABASE=db_zeiterfassung; UID=root; PASSWORD=;";

        public string GetMitarbeiterNrFromUID(string uid)
        {
            string mitarbeiterNr = "";

            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = $"SELECT MitarbeiterNr FROM tbl_rfidchips WHERE UID = @uid";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    string cleanedUID = uid.Trim();
                    string uidWithoutPrefix = cleanedUID.Replace("UID: ", "");
                    command.Parameters.AddWithValue("@uid", uidWithoutPrefix);

                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        mitarbeiterNr = result.ToString();
                    }
                }
            }
            return mitarbeiterNr;
        }
    }
}
