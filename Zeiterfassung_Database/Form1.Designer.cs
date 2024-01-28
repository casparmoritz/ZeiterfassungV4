namespace TaschenrechnerForms
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label_mitarbeiterNr = new System.Windows.Forms.Label();
            this.button_speichern = new System.Windows.Forms.Button();
            this.button_loeschen = new System.Windows.Forms.Button();
            this.radioButton_kommen = new System.Windows.Forms.RadioButton();
            this.radioButton_gehen = new System.Windows.Forms.RadioButton();
            this.groupBox_auswahl = new System.Windows.Forms.GroupBox();
            this.button_ausgabeMitarbeiter = new System.Windows.Forms.Button();
            this.button_ausgabeDatenbank = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label_vorname = new System.Windows.Forms.Label();
            this.label_nachname = new System.Windows.Forms.Label();
            this.textBox_nachname = new System.Windows.Forms.TextBox();
            this.textBox_vorname = new System.Windows.Forms.TextBox();
            this.label_passwort = new System.Windows.Forms.Label();
            this.textBox_passwort = new System.Windows.Forms.TextBox();
            this.textBox_mitarbeiterNr = new System.Windows.Forms.TextBox();
            this.button_hinzufuegen = new System.Windows.Forms.Button();
            this.button_schließen = new System.Windows.Forms.Button();
            this.groupBox_auswahl.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_mitarbeiterNr
            // 
            this.label_mitarbeiterNr.AutoSize = true;
            this.label_mitarbeiterNr.Location = new System.Drawing.Point(6, 5);
            this.label_mitarbeiterNr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_mitarbeiterNr.Name = "label_mitarbeiterNr";
            this.label_mitarbeiterNr.Size = new System.Drawing.Size(98, 13);
            this.label_mitarbeiterNr.TabIndex = 2;
            this.label_mitarbeiterNr.Text = "Mirarbeiter Nummer";
            // 
            // button_speichern
            // 
            this.button_speichern.Location = new System.Drawing.Point(136, 5);
            this.button_speichern.Margin = new System.Windows.Forms.Padding(2);
            this.button_speichern.Name = "button_speichern";
            this.button_speichern.Size = new System.Drawing.Size(74, 45);
            this.button_speichern.TabIndex = 6;
            this.button_speichern.Text = "Eingabe speichern";
            this.button_speichern.UseVisualStyleBackColor = true;
            this.button_speichern.Click += new System.EventHandler(this.button_speichern_Click);
            // 
            // button_loeschen
            // 
            this.button_loeschen.Location = new System.Drawing.Point(227, 5);
            this.button_loeschen.Margin = new System.Windows.Forms.Padding(2);
            this.button_loeschen.Name = "button_loeschen";
            this.button_loeschen.Size = new System.Drawing.Size(74, 45);
            this.button_loeschen.TabIndex = 7;
            this.button_loeschen.Text = "Eingabe löschen";
            this.button_loeschen.UseVisualStyleBackColor = true;
            this.button_loeschen.Click += new System.EventHandler(this.button_loeschen_Click);
            // 
            // radioButton_kommen
            // 
            this.radioButton_kommen.AutoSize = true;
            this.radioButton_kommen.Checked = true;
            this.radioButton_kommen.Location = new System.Drawing.Point(9, 18);
            this.radioButton_kommen.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton_kommen.Name = "radioButton_kommen";
            this.radioButton_kommen.Size = new System.Drawing.Size(65, 17);
            this.radioButton_kommen.TabIndex = 8;
            this.radioButton_kommen.TabStop = true;
            this.radioButton_kommen.Text = "kommen";
            this.radioButton_kommen.UseVisualStyleBackColor = true;
            // 
            // radioButton_gehen
            // 
            this.radioButton_gehen.AutoSize = true;
            this.radioButton_gehen.Location = new System.Drawing.Point(91, 18);
            this.radioButton_gehen.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton_gehen.Name = "radioButton_gehen";
            this.radioButton_gehen.Size = new System.Drawing.Size(55, 17);
            this.radioButton_gehen.TabIndex = 9;
            this.radioButton_gehen.TabStop = true;
            this.radioButton_gehen.Text = "gehen";
            this.radioButton_gehen.UseVisualStyleBackColor = true;
            // 
            // groupBox_auswahl
            // 
            this.groupBox_auswahl.Controls.Add(this.radioButton_gehen);
            this.groupBox_auswahl.Controls.Add(this.radioButton_kommen);
            this.groupBox_auswahl.Location = new System.Drawing.Point(136, 166);
            this.groupBox_auswahl.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox_auswahl.Name = "groupBox_auswahl";
            this.groupBox_auswahl.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox_auswahl.Size = new System.Drawing.Size(165, 46);
            this.groupBox_auswahl.TabIndex = 10;
            this.groupBox_auswahl.TabStop = false;
            this.groupBox_auswahl.Text = "Auswahl:";
            // 
            // button_ausgabeMitarbeiter
            // 
            this.button_ausgabeMitarbeiter.Location = new System.Drawing.Point(136, 60);
            this.button_ausgabeMitarbeiter.Margin = new System.Windows.Forms.Padding(2);
            this.button_ausgabeMitarbeiter.Name = "button_ausgabeMitarbeiter";
            this.button_ausgabeMitarbeiter.Size = new System.Drawing.Size(74, 45);
            this.button_ausgabeMitarbeiter.TabIndex = 11;
            this.button_ausgabeMitarbeiter.Text = "Ausgabe Mitarbeiter";
            this.button_ausgabeMitarbeiter.UseVisualStyleBackColor = true;
            this.button_ausgabeMitarbeiter.Click += new System.EventHandler(this.button_ausgabeMitarbeiter_Click);
            // 
            // button_ausgabeDatenbank
            // 
            this.button_ausgabeDatenbank.Location = new System.Drawing.Point(227, 60);
            this.button_ausgabeDatenbank.Margin = new System.Windows.Forms.Padding(2);
            this.button_ausgabeDatenbank.Name = "button_ausgabeDatenbank";
            this.button_ausgabeDatenbank.Size = new System.Drawing.Size(74, 45);
            this.button_ausgabeDatenbank.TabIndex = 12;
            this.button_ausgabeDatenbank.Text = "Ausgabe Datenbank";
            this.button_ausgabeDatenbank.UseVisualStyleBackColor = true;
            this.button_ausgabeDatenbank.Click += new System.EventHandler(this.button_ausgabeDatenbank_Click);
            // 
            // label_vorname
            // 
            this.label_vorname.AutoSize = true;
            this.label_vorname.Location = new System.Drawing.Point(6, 57);
            this.label_vorname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_vorname.Name = "label_vorname";
            this.label_vorname.Size = new System.Drawing.Size(49, 13);
            this.label_vorname.TabIndex = 0;
            this.label_vorname.Text = "Vorname";
            // 
            // label_nachname
            // 
            this.label_nachname.AutoSize = true;
            this.label_nachname.Location = new System.Drawing.Point(6, 110);
            this.label_nachname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_nachname.Name = "label_nachname";
            this.label_nachname.Size = new System.Drawing.Size(59, 13);
            this.label_nachname.TabIndex = 1;
            this.label_nachname.Text = "Nachname";
            // 
            // textBox_nachname
            // 
            this.textBox_nachname.Enabled = false;
            this.textBox_nachname.Location = new System.Drawing.Point(8, 125);
            this.textBox_nachname.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_nachname.Name = "textBox_nachname";
            this.textBox_nachname.Size = new System.Drawing.Size(96, 20);
            this.textBox_nachname.TabIndex = 5;
            // 
            // textBox_vorname
            // 
            this.textBox_vorname.Enabled = false;
            this.textBox_vorname.Location = new System.Drawing.Point(8, 73);
            this.textBox_vorname.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_vorname.Name = "textBox_vorname";
            this.textBox_vorname.Size = new System.Drawing.Size(96, 20);
            this.textBox_vorname.TabIndex = 4;
            // 
            // label_passwort
            // 
            this.label_passwort.AutoSize = true;
            this.label_passwort.Location = new System.Drawing.Point(6, 166);
            this.label_passwort.Name = "label_passwort";
            this.label_passwort.Size = new System.Drawing.Size(50, 13);
            this.label_passwort.TabIndex = 14;
            this.label_passwort.Text = "Passwort";
            // 
            // textBox_passwort
            // 
            this.textBox_passwort.Location = new System.Drawing.Point(9, 182);
            this.textBox_passwort.Name = "textBox_passwort";
            this.textBox_passwort.Size = new System.Drawing.Size(95, 20);
            this.textBox_passwort.TabIndex = 15;
            // 
            // textBox_mitarbeiterNr
            // 
            this.textBox_mitarbeiterNr.Enabled = false;
            this.textBox_mitarbeiterNr.Location = new System.Drawing.Point(9, 22);
            this.textBox_mitarbeiterNr.Name = "textBox_mitarbeiterNr";
            this.textBox_mitarbeiterNr.Size = new System.Drawing.Size(95, 20);
            this.textBox_mitarbeiterNr.TabIndex = 16;
            this.textBox_mitarbeiterNr.TextChanged += new System.EventHandler(this.textBox_mitarbeiterNr_TextChanged);
            // 
            // button_hinzufuegen
            // 
            this.button_hinzufuegen.Location = new System.Drawing.Point(136, 116);
            this.button_hinzufuegen.Name = "button_hinzufuegen";
            this.button_hinzufuegen.Size = new System.Drawing.Size(74, 45);
            this.button_hinzufuegen.TabIndex = 17;
            this.button_hinzufuegen.Text = "Mitarbeiter Himzufügen";
            this.button_hinzufuegen.UseVisualStyleBackColor = true;
            this.button_hinzufuegen.Click += new System.EventHandler(this.button_hinzufuegen_Click);
            // 
            // button_schließen
            // 
            this.button_schließen.Location = new System.Drawing.Point(227, 116);
            this.button_schließen.Name = "button_schließen";
            this.button_schließen.Size = new System.Drawing.Size(72, 45);
            this.button_schließen.TabIndex = 18;
            this.button_schließen.Text = "Programm beenden";
            this.button_schließen.UseVisualStyleBackColor = true;
            this.button_schließen.Click += new System.EventHandler(this.button_schließen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 222);
            this.Controls.Add(this.button_schließen);
            this.Controls.Add(this.button_hinzufuegen);
            this.Controls.Add(this.textBox_mitarbeiterNr);
            this.Controls.Add(this.textBox_passwort);
            this.Controls.Add(this.label_passwort);
            this.Controls.Add(this.button_ausgabeDatenbank);
            this.Controls.Add(this.button_ausgabeMitarbeiter);
            this.Controls.Add(this.groupBox_auswahl);
            this.Controls.Add(this.button_loeschen);
            this.Controls.Add(this.button_speichern);
            this.Controls.Add(this.textBox_nachname);
            this.Controls.Add(this.textBox_vorname);
            this.Controls.Add(this.label_mitarbeiterNr);
            this.Controls.Add(this.label_nachname);
            this.Controls.Add(this.label_vorname);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Zeiterfassung V1";
            this.groupBox_auswahl.ResumeLayout(false);
            this.groupBox_auswahl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_mitarbeiterNr;
        private System.Windows.Forms.Button button_speichern;
        private System.Windows.Forms.Button button_loeschen;
        private System.Windows.Forms.RadioButton radioButton_kommen;
        private System.Windows.Forms.RadioButton radioButton_gehen;
        private System.Windows.Forms.GroupBox groupBox_auswahl;
        private System.Windows.Forms.Button button_ausgabeMitarbeiter;
        private System.Windows.Forms.Button button_ausgabeDatenbank;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label_vorname;
        private System.Windows.Forms.Label label_nachname;
        private System.Windows.Forms.TextBox textBox_nachname;
        private System.Windows.Forms.TextBox textBox_vorname;
        private System.Windows.Forms.Label label_passwort;
        private System.Windows.Forms.TextBox textBox_passwort;
        private System.Windows.Forms.TextBox textBox_mitarbeiterNr;
        private System.Windows.Forms.Button button_hinzufuegen;
        private System.Windows.Forms.Button button_schließen;
    }
}
