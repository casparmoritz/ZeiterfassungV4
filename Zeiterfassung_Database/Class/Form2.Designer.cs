namespace Zeiterfassung_Database.Class
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_mitarbeiterNr = new System.Windows.Forms.Label();
            this.label_vorname = new System.Windows.Forms.Label();
            this.textBox_mitarbeiterNr = new System.Windows.Forms.TextBox();
            this.textBox_vorname = new System.Windows.Forms.TextBox();
            this.label_nachname = new System.Windows.Forms.Label();
            this.textBox_nachname = new System.Windows.Forms.TextBox();
            this.label_passwort = new System.Windows.Forms.Label();
            this.textBox_passwort = new System.Windows.Forms.TextBox();
            this.label_passwort_bestaetigen = new System.Windows.Forms.Label();
            this.textBox_passwort_bestaetigen = new System.Windows.Forms.TextBox();
            this.label_uid = new System.Windows.Forms.Label();
            this.textBox_uid = new System.Windows.Forms.TextBox();
            this.button_loeschen = new System.Windows.Forms.Button();
            this.button_speichern = new System.Windows.Forms.Button();
            this.button_zurück = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_mitarbeiterNr
            // 
            this.label_mitarbeiterNr.AutoSize = true;
            this.label_mitarbeiterNr.Location = new System.Drawing.Point(13, 14);
            this.label_mitarbeiterNr.Name = "label_mitarbeiterNr";
            this.label_mitarbeiterNr.Size = new System.Drawing.Size(67, 13);
            this.label_mitarbeiterNr.TabIndex = 0;
            this.label_mitarbeiterNr.Text = "MitarbeiterNr";
            // 
            // label_vorname
            // 
            this.label_vorname.AutoSize = true;
            this.label_vorname.Location = new System.Drawing.Point(13, 65);
            this.label_vorname.Name = "label_vorname";
            this.label_vorname.Size = new System.Drawing.Size(49, 13);
            this.label_vorname.TabIndex = 1;
            this.label_vorname.Text = "Vorname";
            // 
            // textBox_mitarbeiterNr
            // 
            this.textBox_mitarbeiterNr.Location = new System.Drawing.Point(16, 30);
            this.textBox_mitarbeiterNr.Name = "textBox_mitarbeiterNr";
            this.textBox_mitarbeiterNr.Size = new System.Drawing.Size(100, 20);
            this.textBox_mitarbeiterNr.TabIndex = 2;
            // 
            // textBox_vorname
            // 
            this.textBox_vorname.Location = new System.Drawing.Point(16, 81);
            this.textBox_vorname.Name = "textBox_vorname";
            this.textBox_vorname.Size = new System.Drawing.Size(100, 20);
            this.textBox_vorname.TabIndex = 3;
            // 
            // label_nachname
            // 
            this.label_nachname.AutoSize = true;
            this.label_nachname.Location = new System.Drawing.Point(13, 122);
            this.label_nachname.Name = "label_nachname";
            this.label_nachname.Size = new System.Drawing.Size(59, 13);
            this.label_nachname.TabIndex = 4;
            this.label_nachname.Text = "Nachname";
            // 
            // textBox_nachname
            // 
            this.textBox_nachname.Location = new System.Drawing.Point(16, 138);
            this.textBox_nachname.Name = "textBox_nachname";
            this.textBox_nachname.Size = new System.Drawing.Size(100, 20);
            this.textBox_nachname.TabIndex = 5;
            // 
            // label_passwort
            // 
            this.label_passwort.AutoSize = true;
            this.label_passwort.Location = new System.Drawing.Point(13, 179);
            this.label_passwort.Name = "label_passwort";
            this.label_passwort.Size = new System.Drawing.Size(50, 13);
            this.label_passwort.TabIndex = 6;
            this.label_passwort.Text = "Passwort";
            // 
            // textBox_passwort
            // 
            this.textBox_passwort.Location = new System.Drawing.Point(16, 195);
            this.textBox_passwort.Name = "textBox_passwort";
            this.textBox_passwort.Size = new System.Drawing.Size(100, 20);
            this.textBox_passwort.TabIndex = 7;
            // 
            // label_passwort_bestaetigen
            // 
            this.label_passwort_bestaetigen.AutoSize = true;
            this.label_passwort_bestaetigen.Location = new System.Drawing.Point(148, 179);
            this.label_passwort_bestaetigen.Name = "label_passwort_bestaetigen";
            this.label_passwort_bestaetigen.Size = new System.Drawing.Size(102, 13);
            this.label_passwort_bestaetigen.TabIndex = 8;
            this.label_passwort_bestaetigen.Text = "Passwort bestärigen";
            // 
            // textBox_passwort_bestaetigen
            // 
            this.textBox_passwort_bestaetigen.Location = new System.Drawing.Point(151, 196);
            this.textBox_passwort_bestaetigen.Name = "textBox_passwort_bestaetigen";
            this.textBox_passwort_bestaetigen.Size = new System.Drawing.Size(100, 20);
            this.textBox_passwort_bestaetigen.TabIndex = 9;
            // 
            // label_uid
            // 
            this.label_uid.AutoSize = true;
            this.label_uid.Location = new System.Drawing.Point(13, 235);
            this.label_uid.Name = "label_uid";
            this.label_uid.Size = new System.Drawing.Size(54, 13);
            this.label_uid.TabIndex = 10;
            this.label_uid.Text = "RFDI UID";
            // 
            // textBox_uid
            // 
            this.textBox_uid.Enabled = false;
            this.textBox_uid.Location = new System.Drawing.Point(16, 252);
            this.textBox_uid.Name = "textBox_uid";
            this.textBox_uid.Size = new System.Drawing.Size(100, 20);
            this.textBox_uid.TabIndex = 11;
            // 
            // button_loeschen
            // 
            this.button_loeschen.Location = new System.Drawing.Point(152, 81);
            this.button_loeschen.Name = "button_loeschen";
            this.button_loeschen.Size = new System.Drawing.Size(99, 48);
            this.button_loeschen.TabIndex = 12;
            this.button_loeschen.Text = "Einagben loeschen";
            this.button_loeschen.UseVisualStyleBackColor = true;
            this.button_loeschen.Click += new System.EventHandler(this.button_loeschen_Click);
            // 
            // button_speichern
            // 
            this.button_speichern.Location = new System.Drawing.Point(151, 17);
            this.button_speichern.Name = "button_speichern";
            this.button_speichern.Size = new System.Drawing.Size(99, 46);
            this.button_speichern.TabIndex = 13;
            this.button_speichern.Text = "Eingabe speichern";
            this.button_speichern.UseVisualStyleBackColor = true;
            this.button_speichern.Click += new System.EventHandler(this.button_speichern_Click);
            // 
            // button_zurück
            // 
            this.button_zurück.Location = new System.Drawing.Point(269, 15);
            this.button_zurück.Name = "button_zurück";
            this.button_zurück.Size = new System.Drawing.Size(99, 48);
            this.button_zurück.TabIndex = 14;
            this.button_zurück.Text = "Zurück gehen";
            this.button_zurück.UseVisualStyleBackColor = true;
            this.button_zurück.Click += new System.EventHandler(this.button_schließen_Click);
            // 
            // button_exit
            // 
            this.button_exit.Location = new System.Drawing.Point(269, 81);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(98, 48);
            this.button_exit.TabIndex = 15;
            this.button_exit.Text = "Programm beenden";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 281);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.button_zurück);
            this.Controls.Add(this.button_speichern);
            this.Controls.Add(this.button_loeschen);
            this.Controls.Add(this.textBox_uid);
            this.Controls.Add(this.label_uid);
            this.Controls.Add(this.textBox_passwort_bestaetigen);
            this.Controls.Add(this.label_passwort_bestaetigen);
            this.Controls.Add(this.textBox_passwort);
            this.Controls.Add(this.label_passwort);
            this.Controls.Add(this.textBox_nachname);
            this.Controls.Add(this.label_nachname);
            this.Controls.Add(this.textBox_vorname);
            this.Controls.Add(this.textBox_mitarbeiterNr);
            this.Controls.Add(this.label_vorname);
            this.Controls.Add(this.label_mitarbeiterNr);
            this.Name = "Form2";
            this.Text = "Mitarbeiter hinzufügen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_mitarbeiterNr;
        private System.Windows.Forms.Label label_vorname;
        private System.Windows.Forms.TextBox textBox_mitarbeiterNr;
        private System.Windows.Forms.TextBox textBox_vorname;
        private System.Windows.Forms.Label label_nachname;
        private System.Windows.Forms.TextBox textBox_nachname;
        private System.Windows.Forms.Label label_passwort;
        private System.Windows.Forms.TextBox textBox_passwort;
        private System.Windows.Forms.Label label_passwort_bestaetigen;
        private System.Windows.Forms.TextBox textBox_passwort_bestaetigen;
        private System.Windows.Forms.Label label_uid;
        private System.Windows.Forms.TextBox textBox_uid;
        private System.Windows.Forms.Button button_loeschen;
        private System.Windows.Forms.Button button_speichern;
        private System.Windows.Forms.Button button_zurück;
        private System.Windows.Forms.Button button_exit;
    }
}
