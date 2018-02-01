using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MLZ_Bootsverwaltung
{/// <summary>
/// <Autor>Alex Moritzi</Autor>
/// <Version>1.0</Version>
/// </summary>
    [Serializable]
    public partial class MainForm : Form
    {
        Farbe farbe = new Farbe();
        Typ typ = new Typ();
        BootModell bootmodell = new BootModell();
        public static int BootId = 1000;
        BootController bc = new BootController();
        private BindingSource lbxBindingSource = new BindingSource();
        public int BootslisteZaehler = 0;
        public static int Index { get; set; }
        public static int id;
        public int Status = 0;
        int LastIndex;
        public static string Bildpfad;
                
        public MainForm()
        {
            InitializeComponent();
            // Einfacher Befehl, um das Window auf Bildschirmgrösse festzulegen!!
            // this.WindowState = FormWindowState.Maximized;
            CmbFarbe.DataSource = Enum.GetValues(typeof(Farbe));
            CmbTyp.DataSource = Enum.GetValues(typeof(Typ));
            // Liest File Boats.xlm ein = Bootsliste
            bootmodell.bootsListe = BootController.DeserializeXml("Boats.xlm");
        }
        
        private void CmbFarbe_SelectedIndexChanged(object sender, EventArgs e)
        {
            Enum.TryParse<Farbe>(CmbFarbe.SelectedValue.ToString(), out farbe);
        }
        private void CmbTyp_SelectedIndexChanged(object sender, EventArgs e)
        {   // Macht die letzten drei Felder mit Labels sichtbar oder nicht
            Enum.TryParse<Typ>(CmbTyp.SelectedValue.ToString(), out typ);
            if (typ != Typ.Kajak)
            {
                LblPS.Visible = true;
                TxbPS.Visible = true;
                LblMaxSpeedMotor.Visible = true;
                TxbSpeedMotor.Visible = true;
                LblMaxSpeedSegel.Visible = true;
                TxbSpeedSegel.Visible = true;
                // Positioniert Cursor im ersten Textfeld (Marke)
                TxbMarke.Focus();
            }
            else
            {
                LblPS.Visible = false;
                TxbPS.Visible = false;
                LblMaxSpeedMotor.Visible = false;
                TxbSpeedMotor.Visible = false;
                LblMaxSpeedSegel.Visible = false;
                TxbSpeedSegel.Visible = false;
            }
        }
        
        private void BtnSave_Click(object sender, EventArgs e)
        {   // Fängt ab, wenn Felder leer sind.
            if (TxbMarke.Text == "" || TxbModell.Text == ""  || TxbNummernschild.Text == ""
                || TxbBreite.Text == "" || TxBHoehe.Text == "" || TxBLaenge.Text == "" ||
                TxbTagesmiete.Text == "" || TxbAnzahlPersonen.Text == "")
            {
                MessageBox.Show("Es müssen alle Felder ausgefüllt werden!");
                TxbMarke.Focus();
                return;
            }
            // Status 0 = neues File
            if (Status == 0)
            {   // Speichern neue Boote abhängig vom Typ
                if (typ == Typ.Kajak)
                {
                    IndexNeu();
                    Boot boot = BootErfassen();
                    // Speichert die Daten in der List<> bootsliste
                    bootmodell.bootsListe.Add(boot);
                    boot.Bildpfad = @"..\..\..\..\..\Bilder\Kajak.jpg";

                }
                if (typ == Typ.Motorboot)
                {   // Fängt ab, wenn Felder leer sind.
                    if (TxbPS.Text == "" || TxbSpeedMotor.Text == "" || TxbSpeedSegel.Text == "")
                    {
                        MessageBox.Show("Es müssen alle Felder ausgefüllt werden!!");
                        TxbMarke.Focus();
                        return;
                    }
                    IndexNeu();
                    Motorboot motorboot = MotorbootErfassen();
                    bootmodell.bootsListe.Add(motorboot);
                    motorboot.Bildpfad = @"..\..\..\..\..\Bilder\Motorboot.jpg";
                }
                if (typ == Typ.Katamaran)
                {
                    if (TxbPS.Text == "" || TxbSpeedMotor.Text == "" || TxbSpeedSegel.Text == "")
                    {
                        MessageBox.Show("Feld darf nicht leer sein!");
                        TxbMarke.Focus();
                        return;
                    }
                    IndexNeu();
                    Motorboot motorboot = MotorbootErfassen();
                    bootmodell.bootsListe.Add(motorboot);
                    motorboot.Bildpfad = @"..\..\..\..\..\Bilder\Katamaran.jpg";
                }
                if (typ == Typ.Segelboot)
                {
                    if (TxbPS.Text == "" || TxbSpeedMotor.Text == "" || TxbSpeedSegel.Text == "")
                    {
                        MessageBox.Show("Feld darf nicht leer sein!");
                        TxbMarke.Focus();
                        return;
                    }
                    IndexNeu();
                    Motorboot motorboot = MotorbootErfassen();
                    bootmodell.bootsListe.Add(motorboot);
                    motorboot.Bildpfad = @"..\..\..\..\..\Bilder\Segelboot.jpg";
                }
            }
            else
            {   // Speichern von Mutationen abhängig vom Typ 
                if (typ == Typ.Kajak)
                {
                    IndexMutation();
                    Boot boot = BootMutationSpeichern();
                    // Speichert die geänderten Daten in der List<>
                    bootmodell.bootsListe.Insert(Index, boot);
                    boot.Bildpfad = @"..\..\..\..\..\Bilder\Kajak.jpg";
                    UpdateListe();
                }
                if (typ == Typ.Motorboot)
                {
                    IndexMutation();
                    Motorboot motorboot = MotorbootMutationSpeichern();
                    bootmodell.bootsListe.Insert(Index, motorboot);
                    motorboot.Bildpfad = @"..\..\..\..\..\Bilder\Motorboot.jpg";
                    UpdateListe();
                }
                if (typ == Typ.Katamaran)
                {
                    IndexMutation();
                    Motorboot motorboot = MotorbootMutationSpeichern();
                    bootmodell.bootsListe.Insert(Index, motorboot);
                    motorboot.Bildpfad = @"..\..\..\..\..\Bilder\Katamaran.jpg";
                    UpdateListe();
                }
                if (typ == Typ.Segelboot)
                {
                    IndexMutation();
                    Motorboot motorboot = MotorbootMutationSpeichern();
                    bootmodell.bootsListe.Insert(Index, motorboot);
                    motorboot.Bildpfad = @"..\..\..\..\..\Bilder\Segelboot.jpg";
                    UpdateListe();
                }
            }
        }

        private void BtnMutieren_Click(object sender, EventArgs e)
        {
            Boot findeTyp = LbxBootsliste.SelectedItem as Boot;
            if (findeTyp.Typ == Typ.Kajak)
            {
                KajakMutieren();
            }
            else
            {
                MotorbootMutieren();
            }
        }

        // Bildet die ID für ein neues Boot, ausgehend von der letzten vorhandenen ID
        public void IndexNeu()
        {
            try
            {
                LastIndex = bootmodell.bootsListe.Count;
                BootId = bootmodell.bootsListe.ElementAt(LastIndex - 1).ID;
                BootId++;
            }
            catch (System.NullReferenceException e)
            {
                MessageBox.Show("Die Felder müssen ausgefüllt werden.");
            }
        }

        // Ermittelt die ID eines Bootes, das mutiert werden soll, aufgrund Markierung
        public void IndexMutation()
        {
            Boot mutation;
            // as Boot > Wandelt Item in den Typ Boot
            mutation = (LbxBootsliste.SelectedItem as Boot);
            id = mutation.ID;
            Index = bootmodell.bootsListe.FindIndex(r => r.ID == id);
            // Löscht markiertes Item aus Bootsliste
            if ((LbxBootsliste.SelectedIndex >= 0 && (LbxBootsliste.SelectedIndex < bootmodell.bootsListe.Count)))
                bootmodell.bootsListe.RemoveAt(LbxBootsliste.SelectedIndex);
        }

        // Speichert die Daten eines Bootes in der Klasse Boot, abhängig vom Typ
        // (alle ausser Kajak haben 3 zursätzliche Felder)
        public Boot BootErfassen()
        {
            try
            {
                Boot boot = new Boot()  // = Kajak!
                {
                    ID = BootId,
                    Typ = typ,
                    Marke = TxbMarke.Text,
                    Modell = TxbModell.Text,
                    Farbe = farbe,
                    Nummernschild = Convert.ToInt32(TxbNummernschild.Text),
                    Laenge = Convert.ToDouble(TxBLaenge.Text),
                    Breite = Convert.ToDouble(TxbBreite.Text),
                    Hoehe = Convert.ToDouble(TxBHoehe.Text),
                    Tagesmiete = Convert.ToDouble(TxbTagesmiete.Text),
                    AnzahlPersonen = Convert.ToInt32(TxbAnzahlPersonen.Text),
                };
                Loeschen();
                return boot;
            }
            catch (FormatException e)
            {
                MessageBox.Show("Das Feld darf nicht leer sein!");
            }
            return null;
        }

        public Motorboot MotorbootErfassen()
        {
            try
            {
                Motorboot motorboot = new Motorboot()
                {
                    ID = BootId,
                    Typ = typ,
                    Marke = TxbMarke.Text,
                    Modell = TxbModell.Text,
                    Farbe = farbe,
                    Nummernschild = Convert.ToInt32(TxbNummernschild.Text),
                    Laenge = Convert.ToDouble(TxBLaenge.Text),
                    Breite = Convert.ToDouble(TxbBreite.Text),
                    Hoehe = Convert.ToDouble(TxBHoehe.Text),
                    Tagesmiete = Convert.ToDouble(TxbTagesmiete.Text),
                    AnzahlPersonen = Convert.ToInt32(TxbAnzahlPersonen.Text),
                    PS = Convert.ToInt32(TxbPS.Text),
                    MaxSpeedMotor = Convert.ToInt32(TxbSpeedMotor.Text),
                    MaxSpeedSegel = Convert.ToInt32(TxbSpeedMotor.Text)
                };
                Loeschen();
                return motorboot;
            }
            catch (FormatException e)
            {
                MessageBox.Show("Das Feld darf nicht leer sein!");
            }
            return null;
        }
    
        // Die Daten in den Textfeldern werden nach der allfälligen Aenderung
        // in der Klasse Boot abgespeichert
        // Bereitstellung der Daten in die Textfelder siehe unten unter ....mutieren()
        public Boot BootMutationSpeichern()
        {
            Boot boot = new Boot()  // = Kajak
            {
                ID = id,
                Typ = typ,
                Marke = TxbMarke.Text,
                Modell = TxbModell.Text,
                Farbe = farbe,
                Nummernschild = Convert.ToInt32(TxbNummernschild.Text),
                Laenge = Convert.ToDouble(TxBLaenge.Text),
                Breite = Convert.ToDouble(TxbBreite.Text),
                Hoehe = Convert.ToDouble(TxBHoehe.Text),
                Tagesmiete = Convert.ToDouble(TxbTagesmiete.Text),
                AnzahlPersonen = Convert.ToInt32(TxbAnzahlPersonen.Text),
            };
            Status = 0;
            Loeschen();
            return boot;
        }
        public Motorboot MotorbootMutationSpeichern()
        {
            Motorboot motorboot = new Motorboot()
            {
                ID = id,
                Typ = typ,
                Marke = TxbMarke.Text,
                Modell = TxbModell.Text,
                Farbe = farbe,
                Nummernschild = Convert.ToInt32(TxbNummernschild.Text),
                Laenge = Convert.ToDouble(TxBLaenge.Text),
                Breite = Convert.ToDouble(TxbBreite.Text),
                Hoehe = Convert.ToDouble(TxBHoehe.Text),
                Tagesmiete = Convert.ToDouble(TxbTagesmiete.Text),
                AnzahlPersonen = Convert.ToInt32(TxbAnzahlPersonen.Text),
                PS = Convert.ToInt32(TxbPS.Text),
                MaxSpeedMotor = Convert.ToInt32(TxbSpeedMotor.Text),
                MaxSpeedSegel = Convert.ToInt32(TxbSpeedMotor.Text)
            };
            Status = 0;
            Loeschen();
            return motorboot;
        }
 
        // Die Daten des jeweils markierten Bootes werden aus der bootsliste ausgelesen
        // und für die Mutation in die Textfelder geschrieben
        public void KajakMutieren()
        {
            Boot mutation;
            mutation = (LbxBootsliste.SelectedItem as Boot);
            id = mutation.ID;
            Loeschen();
            Boot record = bootmodell.bootsListe.Find(x => x.ID == id);
            CmbTyp.SelectedItem = record.Typ;
            TxbMarke.Text = record.Marke;
            TxbModell.Text = record.Modell;
            CmbFarbe.SelectedItem = record.Farbe;
            TxbNummernschild.Text = Convert.ToString(record.Nummernschild);
            TxBLaenge.Text = Convert.ToString(record.Laenge);
            TxbBreite.Text = Convert.ToString(record.Breite);
            TxBHoehe.Text = Convert.ToString(record.Hoehe);
            TxbTagesmiete.Text = Convert.ToString(record.Tagesmiete);
            TxbAnzahlPersonen.Text = Convert.ToString(record.AnzahlPersonen);
            // Status 1 = Mutation
            Status = 1;

            MessageBox.Show("Bitte Mutation eintragen und \"Speichern\" drücken");

        }
        public void MotorbootMutieren()
        {
            Motorboot mutation;
            mutation = (LbxBootsliste.SelectedItem as Motorboot);
            id = mutation.ID;
            Loeschen();
            Motorboot record = bootmodell.bootsListe.Find(x => x.ID == id) as Motorboot;
            CmbTyp.SelectedItem = record.Typ;
            TxbMarke.Text = record.Marke;
            TxbModell.Text = record.Modell;
            CmbFarbe.SelectedItem = record.Farbe;
            TxbNummernschild.Text = Convert.ToString(record.Nummernschild);
            TxBLaenge.Text = Convert.ToString(record.Laenge);
            TxbBreite.Text = Convert.ToString(record.Breite);
            TxBHoehe.Text = Convert.ToString(record.Hoehe);
            TxbTagesmiete.Text = Convert.ToString(record.Tagesmiete);
            TxbAnzahlPersonen.Text = Convert.ToString(record.AnzahlPersonen);
            TxbPS.Text = Convert.ToString(record.PS);
            TxbSpeedMotor.Text = Convert.ToString(record.MaxSpeedMotor);
            TxbSpeedSegel.Text = Convert.ToString(record.MaxSpeedSegel);

            MessageBox.Show("Bitte Mutation eintragen und \"Speichern\" drücken");

            Status = 1;
        }

        // Die Textfelder werden geleert und die ENUMs auf den Ausgangswert gestellt
        public void Loeschen()
        {
            CmbTyp.SelectedItem = Typ.Kajak;
            TxbMarke.Clear();
            TxbModell.Clear();
            CmbFarbe.SelectedItem = Farbe.weiss;
            TxbNummernschild.Clear();
            TxBLaenge.Clear();
            TxbBreite.Clear();
            TxBHoehe.Clear();
            TxbTagesmiete.Clear();
            TxbAnzahlPersonen.Clear();
            TxbPS.Clear();
            TxbSpeedMotor.Clear();
            TxbSpeedSegel.Clear();
        }

        // Bootsliste wird in TextBox generiert
        private void BtnListe_Click(object sender, EventArgs e)
        {
            UpdateListe();
            lbxBindingSource.DataSource = bootmodell.bootsListe;
            LbxBootsliste.DataSource = lbxBindingSource;
            if (BootslisteZaehler == 0)
            {
                MessageBox.Show("Bitte für Mutation / Löschung / Bildanzeige die gewünschte Zeile markieren.");
            }
            BootslisteZaehler++;
        }

        // Bootsliste wird aktualisiert
        private void UpdateListe()
        {
            LbxBootsliste.DataSource = null;
            lbxBindingSource.DataSource = bootmodell.bootsListe;
            LbxBootsliste.DataSource = lbxBindingSource;
        }

        // Anzahl Boote in der Liste wird anhand .Count ermittel und angezeigt
        private void LbxBootsliste_SelectedIndexChanged(object sender, EventArgs e)
        {
            TxbAnzBoote.Text = Convert.ToString(bootmodell.bootsListe.Count);
        }

        // Markiertes Boot wird gelöscht
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if ((LbxBootsliste.SelectedIndex >= 0 && (LbxBootsliste.SelectedIndex < bootmodell.bootsListe.Count)))
                bootmodell.bootsListe.RemoveAt(LbxBootsliste.SelectedIndex);
            UpdateListe();
        }

        // Validierung aufgrund von Regex-Vorgaben
        private void TxbNummernschild_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(TxbNummernschild.Text, "[^0-9]"))
            {
                MessageBox.Show("Es können nur ganze Zahlen eingegeben werden! Feld darf nicht leer sein.");
                TxbNummernschild.Text = TxbNummernschild.Text.Remove(TxbNummernschild.Text.Length - 1);
            }
        }

        // Das Programm wird beendet und die Daten in Boat.xlm geschrieben
        private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
           BootController.SerializeXml("Boats.xlm", bootmodell.bootsListe);
                this.Close();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
           BootController.SerializeXml("Boats.xlm", bootmodell.bootsListe);
            
        }

        // Die Angaben für die Bildanzeige werden ermittelt und die Bildanzeige gestartet
        private void BtnBildAnzeigen_Click(object sender, EventArgs e)
        {
            try
            {
                Boot boot = new Boot();
                Boot mutation;
                mutation = (LbxBootsliste.SelectedItem as Boot);
                Bildpfad = mutation.Bildpfad;
                var bildanzeige = new Bildanzeige();
                bildanzeige.ShowDialog();
            }
            catch (System.NullReferenceException f)
            {
                MessageBox.Show("Bitte Zeilenauswahl treffen.");
            }
        }

        // Validierung aufgrund von Regex-Vorgaben
        private void TxBLaenge_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(TxBLaenge.Text, "[^0-9.0-9]"))
            {
                MessageBox.Show("Es können nur Zahlen eingegeben werden! Feld darf nicht leer sein.");
                TxBLaenge.Text = TxBLaenge.Text.Remove(TxBLaenge.Text.Length - 1);
            }
        }

        private void TxbBreite_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(TxbBreite.Text, "[^0-9.0-9]"))
            {
                MessageBox.Show("Es können nur Zahlen eingegeben werden! Feld darf nicht leer sein.");
                TxbBreite.Text = TxbBreite.Text.Remove(TxbBreite.Text.Length - 1);
            }
        }

        private void TxBHoehe_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(TxBHoehe.Text, "[^0-9.0-9]"))
            {
                MessageBox.Show("Es können nur Zahlen eingegeben werden! Feld darf nicht leer sein.");
                TxBHoehe.Text = TxBHoehe.Text.Remove(TxBHoehe.Text.Length - 1);
            }
        }

        private void TxbTagesmiete_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(TxbTagesmiete.Text, "[^0-9.0-9]"))
            {
                MessageBox.Show("Es können nur Zahlen eingegeben werden! Feld darf nicht leer sein.");
                TxbTagesmiete.Text = TxbTagesmiete.Text.Remove(TxbTagesmiete.Text.Length - 1);
            }
        }

        private void TxbAnzahlPersonen_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(TxbAnzahlPersonen.Text, "[^0-9]"))
            {
                MessageBox.Show("Es können nur ganze Zahlen eingegeben werden! Feld darf nicht leer sein.");
                TxbAnzahlPersonen.Text = TxbAnzahlPersonen.Text.Remove(TxbAnzahlPersonen.Text.Length - 1);
            }
        }

        private void TxbPS_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(TxbPS.Text, "[^0-9]"))
            {
                MessageBox.Show("Es können nur ganze Zahlen eingegeben werden! Feld darf nicht leer sein.");
                TxbPS.Text = TxbPS.Text.Remove(TxbPS.Text.Length - 1);
            }
        }

        private void TxbSpeedMotor_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(TxbSpeedMotor.Text, "[^0-9]"))
            {
                MessageBox.Show("Es können nur ganze Zahlen eingegeben werden! Feld darf nicht leer sein.");
                TxbSpeedMotor.Text = TxbSpeedMotor.Text.Remove(TxbSpeedMotor.Text.Length - 1);
            }
        }

        private void TxbSpeedSegel_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(TxbSpeedSegel.Text, "[^0-9]"))
            {
                MessageBox.Show("Es können nur ganze Zahlen eingegeben werden! Feld darf nicht leer sein.");
                TxbSpeedSegel.Text = TxbSpeedSegel.Text.Remove(TxbSpeedSegel.Text.Length - 1);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}

