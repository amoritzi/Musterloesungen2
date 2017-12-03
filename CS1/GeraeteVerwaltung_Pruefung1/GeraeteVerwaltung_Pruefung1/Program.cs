using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace GeraeteVerwaltung_Pruefung1
{
    class Program
        {
        public static int index;
        public static int GeraeteID { get; set; }
        static void Main(string[] args)
        {
            
            int anzahlGeraete = 0;
            Geraet[] geraeteListe = new Geraet[40];
            string eingabe;


            // Autoinitalizer

            geraeteListe[0] = new Smartphone()
            {
                Id = 1,
                Akkulaufzeit = 5,
                AnzahlProzessoren = 2,
                Arbeitsspeicher = "2 GB",
                Bildschirmgroesse = "6,3'",
                Farbe = Farbe.grün,
                Kaufpreis = 599.00,
                Marke = "Samsung",
                MaxSpeichererweiterung = "128 KB",
                MicroSDCardSlot = true,
                Model = "S12",
                OS = "Windows",
                Prozessortyp = "Intel",
                Speicherkapazitaet = "64 GB"
            };
            geraeteListe[1] = new Smartphone()
            {
                Id = 2,
                Akkulaufzeit = 7,
                AnzahlProzessoren = 1,
                Arbeitsspeicher = "4 GB",
                Bildschirmgroesse = "5,3'",
                Farbe = Farbe.grau,
                Kaufpreis = 999.00,
                Marke = "Apple",
                MaxSpeichererweiterung = "0",
                MicroSDCardSlot = false,
                Model = "IPhone 8",
                OS = "iOS",
                Prozessortyp = "AMD",
                Speicherkapazitaet = "128 GB"
            };
            geraeteListe[2] = new Smartphone()
            {
                Id = 3,
                Akkulaufzeit = 4,
                AnzahlProzessoren = 1,
                Arbeitsspeicher = "3 GB",
                Bildschirmgroesse = "12'",
                Farbe = Farbe.weiss,
                Kaufpreis = 350.00,
                Marke = "Huawei",
                MaxSpeichererweiterung = "0",
                MicroSDCardSlot = false,
                Model = "2",
                OS = "Android",
                Prozessortyp = "AMD",
                Speicherkapazitaet = "256 GB"
            };
            geraeteListe[3] = new Tablet()
            {
                Id = 4,
                Farbe = Farbe.grün,
                Speicherkapazitaet = "128 GB",
                Prozessortyp = "Intel",
                Akkulaufzeit = 12,
                AnzahlProzessoren = 2,
                Arbeitsspeicher = "2 GB",
                Bildschirmgroesse = "9,7'",
                Kaufpreis = 1299,
                Marke = "HP",
                MicroSDCardSlot = true,
                Model = "1500",
                OS = "Android",
                _4G = false
            };
            geraeteListe[4] = new Tablet()
            {
                Id = 5,
                Farbe = Farbe.rot,
                Speicherkapazitaet = "256 GB",
                Prozessortyp = "AMD",
                Akkulaufzeit = 15,
                AnzahlProzessoren = 3,
                Arbeitsspeicher = "4 GB",
                Bildschirmgroesse = "19'",
                Kaufpreis = 1500,
                Marke = "Lenovo",
                MicroSDCardSlot = false,
                Model = "X220",
                OS = "Windows",
                _4G = true
            };
            geraeteListe[5] = new Tablet()
            {
                Id = 6,
                Farbe = Farbe.schwarz,
                Speicherkapazitaet = "1 TB",
                Prozessortyp = "AMD",
                Akkulaufzeit = 12,
                AnzahlProzessoren = 1,
                Arbeitsspeicher = "512 MB",
                Bildschirmgroesse = "15'",
                Kaufpreis = 800,
                Marke = "Huawei",
                MicroSDCardSlot = false,
                Model = "GS",
                OS = "Windows",
                _4G = false
            };
            geraeteListe[6] = new Notebook()
            {
                Id = 7,
                OS = "iOS",
                Model = "MacBook",
                Akkulaufzeit = 14,
                AnzahlProzessoren = 4,
                Arbeitsspeicher = "16 GB",
                BeleuchteteTastatur = true,
                Bildschirmgroesse = "15,6'",
                Farbe = Farbe.weiss,
                HDMIAnschluss = true,
                Kaufpreis = 2697.00,
                Marke = "Apple",
                Prozessortyp = "CoreIntel",
                Speicherkapazitaet = "128 GB",
                SSDGroesse = "512 GB"
            };
            geraeteListe[7] = new Notebook()
            {
                Id = 8,
                OS = "Windows",
                Model = "FB120",
                Akkulaufzeit = 12,
                AnzahlProzessoren = 4,
                Arbeitsspeicher = "8 GB",
                BeleuchteteTastatur = false,
                Bildschirmgroesse = "12,3'",
                Farbe = Farbe.rot,
                HDMIAnschluss = true,
                Kaufpreis = 1599.00,
                Marke = "ASUS",
                Prozessortyp = "CoreIntel",
                Speicherkapazitaet = "1 TB",
                SSDGroesse = "0"
            };
            geraeteListe[8] = new Notebook()
            {
                Id = 9,
                OS = "Windows",
                Model = "VivoBook",
                Akkulaufzeit = 24,
                AnzahlProzessoren = 2,
                Arbeitsspeicher = "16 GB",
                BeleuchteteTastatur = false,
                Bildschirmgroesse = "16'",
                Farbe = Farbe.blau,
                HDMIAnschluss = true,
                Kaufpreis = 1899.00,
                Marke = "OMEN",
                Prozessortyp = "CoreIntel",
                Speicherkapazitaet = "768 MB",
                SSDGroesse = "1 TB"
            };

            anzahlGeraete = 9;
            GeraeteID = 1;
            GeraeteID = (Array.FindLastIndex(geraeteListe, n => n != null) + 2);
            

            // Menu

            do
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Clear();
                Console.WriteLine("");
                Console.WriteLine("--- Geräteverwaltung [{0}]---", anzahlGeraete);
                Console.WriteLine("");

                Console.WriteLine("1 - Smartphone erfassen");
                Console.WriteLine("2 - Tablet erfassen");
                Console.WriteLine("3 - Notebook erfassen");
                Console.WriteLine("4 - Geräteliste anzeigen");
                Console.WriteLine("5 - Gerät modifizieren");
                Console.WriteLine("6 - Gerät löschen");
                Console.WriteLine("9 - Beenden");

                eingabe = Console.ReadLine();
                Console.ResetColor();

                switch (eingabe)
                {
                    case "1":
                        Console.WriteLine("");
                        geraeteListe[anzahlGeraete] = ErfasseSmartphone();
                        anzahlGeraete++;
                        break;
                    case "2":
                        Console.WriteLine("");
                        geraeteListe[anzahlGeraete] = ErfasseTablet();
                        anzahlGeraete++;
                        break;
                    case "3":
                        Console.WriteLine("");
                        geraeteListe[anzahlGeraete] = ErfasseNotebook();
                        anzahlGeraete++;
                        break; 
                    case "4":
                        GeraeteListeAusgeben(geraeteListe);
                        Console.ReadLine();
                        break;
                    case "5":
                        Console.WriteLine("");
                        ModifiziereGeraet(geraeteListe);
                        Console.ReadLine();
                        break;
                    case "6":
                        Console.WriteLine("");
                        LoescheGeraet(geraeteListe);
                        Console.ReadLine();
                        break; 
                    case "9":
                        Console.WriteLine("Programm wird beendet");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Kein gültiger Befehl!");
                        Console.WriteLine("Drücke eine Taste");
                        Console.ReadLine();
                        break;
                }

            } while (true);
        }

        
        static void ErfasseGeraeteDaten(Geraet geraet)
        {
            geraet.Id = GeraeteID++;
            Console.Write("Bitte geben Sie die Marke ein: ");
            geraet.Marke = Console.ReadLine();
            Console.Write("Bitte geben Sie das Modell ein: ");
            geraet.Model = Console.ReadLine();
            Console.Write("Bitte geben Sie das Operating System ein: ");
            geraet.OS = Console.ReadLine();
            Console.Write("Bitte geben Sie den Arbeitsspeicher ein: ");
            geraet.Arbeitsspeicher = Console.ReadLine();
            Console.Write("Bitte geben Sie die Speicherkapazität ein: ");
            geraet.Speicherkapazitaet = Console.ReadLine();
            Console.Write("Bitte geben Sie die Bildschirmgrösse ein: ");
            geraet.Bildschirmgroesse = Console.ReadLine();
            Console.Write("Bitte geben Sie die Akkulaufzeit in Stunden ein: ");
            try
            {
                string akkulaufzeit = Console.ReadLine();
                geraet.Akkulaufzeit = Convert.ToDouble(akkulaufzeit);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Falsche Eingabe, möglich sind nur Zahlen (allenfalls mit Dezimalstellen). Neuer Versuch: " );
                Console.Write("Bitte geben Sie die Akkulaufzeit in Stunden ein: ");
                try
                {
                    string akkulaufzeit = Console.ReadLine();
                    geraet.Akkulaufzeit = Convert.ToDouble(akkulaufzeit);
                }
                catch (FormatException e1)
                {
                    Console.WriteLine("Falsche Eingabe, möglich sind nur Zahlen (allenfalls mit Dezimalstellen).");

                }
            }
            Console.Write("Bitte geben Sie den Prozessortyp ein: ");
            geraet.Prozessortyp = Console.ReadLine();
            Console.Write("Bitte geben Sie die Anzahl Prozessoren ein: ");
            try
            {
                string anzahlprozessoren = Console.ReadLine();
                geraet.AnzahlProzessoren = Convert.ToInt32(anzahlprozessoren);
                
            }
            catch (FormatException e)
            {
                Console.WriteLine("Falsche Eingabe, möglich sind nur ganze Zahlen. Neuer Versuch: ");
                Console.Write("Bitte geben Sie die Anzahl Prozessoren ein: ");
                try
                {
                    string anzahlprozessoren = Console.ReadLine();
                    geraet.AnzahlProzessoren = Convert.ToInt32(anzahlprozessoren);
                }
                catch (FormatException e1)
                {
                    Console.WriteLine("Falsche Eingabe, möglich sind nur ganze Zahlen.");

                }
            }
            
            Console.Write("Bitte geben Sie die Farbe ein (0: schwarz, 1: grau, 2: weiss, 3: blau, 4: rot, 5: grün): ");
            try
            {
                string farbe = Console.ReadLine();
                geraet.Farbe = (Farbe)Enum.Parse(typeof(Farbe), farbe);
                int f = Convert.ToInt32(farbe);
                if (f < 0 || f > 5)
                {
                    Console.WriteLine("Falsche Eingabe: Nur Zahlen zwischen 0 und 5 möglich! Neuer Versuch: ");
                    Console.Write("Bitte geben Sie die Farbe ein (0: schwarz, 1: grau, 2: weiss, 3: blau, 4: rot, 5: grün): ");
                    farbe = Console.ReadLine();
                    geraet.Farbe = (Farbe)Enum.Parse(typeof(Farbe), farbe);
                    int f1 = Convert.ToInt32(farbe);
                    if (f1 < 0 || f1 > 5)
                    {
                        Console.WriteLine("Falsche Eingabe: Nur Zahlen zwischen 0 und 5 möglich!");
                    }
                }
            }
            catch (FormatException e)
            {
                Console.WriteLine("Falsche Eingabe: Nur Zahlen zwischen 0 und 5 möglich! Neuer Versuch: ");
                Console.Write("Bitte geben Sie die Farbe ein (0: schwarz, 1: grau, 2: weiss, 3: blau, 4: rot, 5: grün): ");
                try
                {
                    string farbe = Console.ReadLine();
                    geraet.Farbe = (Farbe)Enum.Parse(typeof(Farbe), farbe);
                    int f = Convert.ToInt32(farbe);
                    if (f < 0 || f > 5)
                    {
                        Console.WriteLine("Falsche Eingabe: Nur Zahlen zwischen 0 und 5 möglich! Neuer Versuch: ");
                        Console.Write("Bitte geben Sie die Farbe ein (0: schwarz, 1: grau, 2: weiss, 3: blau, 4: rot, 5: grün): ");
                        farbe = Console.ReadLine();
                        geraet.Farbe = (Farbe)Enum.Parse(typeof(Farbe), farbe);
                        int f1 = Convert.ToInt32(farbe);
                        if (f1 < 0 || f1 > 5)
                        {
                            Console.WriteLine("Falsche Eingabe: Nur Zahlen zwischen 0 und 5 möglich!");
                        }
                    }
                }
                catch (FormatException e1)
                {
                    Console.WriteLine("Falsche Eingabe: Nur Zahlen zwischen 0 und 5 möglich!");

                }
            }
            Console.Write("Bitte geben Sie den Kaufpreis ein: ");
            try
            {
                string preis = Console.ReadLine();
                geraet.Kaufpreis = Convert.ToDouble(preis);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Falsche Eingabe: Nur Zahlen mit Dezimalstellen erlaubt! Neuer Versuch: ");
                Console.Write("Bitte geben Sie den Kaufpreis ein: ");
                try
                {
                    string preis = Console.ReadLine();
                    geraet.Kaufpreis = Convert.ToDouble(preis);
                }
                catch (FormatException e1)
                {
                    Console.WriteLine("Falsche Eingabe: Nur Zahlen mit Dezimalstellen erlaubt!");

                }
            }
        }
        static Smartphone ErfasseSmartphone()
        {
            Console.WriteLine("Smartphone erfassen");
            Console.WriteLine("-------------------");

            Smartphone smartphone = new Smartphone();
            ErfasseGeraeteDaten(smartphone);

            Console.Write("Bitte geben Sie an, ob das Smartphone über eine MicroSD-Card Slot verfügt (J / N): ");
            string sdcardslot = Console.ReadLine();
            if (sdcardslot != "J" || sdcardslot != "N")
            {
                Console.WriteLine ("Falsche Eingabe: Nur \"J\" oder \"N\" möglich! Neuer Versuch: ");
                Console.Write("Bitte geben Sie an, ob das Smartphone über eine MicroSD-Card Slot verfügt (J / N): ");
                sdcardslot = Console.ReadLine();
                if (sdcardslot != "J" || sdcardslot != "N")
                {
                    Console.WriteLine("Falsche Eingabe: Nur \"J\" oder \"N\" möglich!");

                }
            }
            if (sdcardslot == "J")
            {
                sdcardslot = "true";
                Console.WriteLine("Bitte geben Sie an, wie gross die maximale Speichererweitung sein kann: ");
                smartphone.MaxSpeichererweiterung = Console.ReadLine();
                
            }
            else sdcardslot = "false";
            smartphone.MicroSDCardSlot = Boolean.Parse(sdcardslot);

            return smartphone;
            }

        static Tablet ErfasseTablet()
        {
            Console.WriteLine("Tablet erfassen");
            Console.WriteLine("---------------");

            Tablet tablet = new Tablet();
            ErfasseGeraeteDaten(tablet);

            Console.Write("Bitte geben Sie an, ob das Tablet über eine MicroSD-Card Slot verfügt(J / N): ");
            string sdcardslot = Console.ReadLine();
            if (sdcardslot != "J" || sdcardslot != "N")
            {
                Console.WriteLine("Falsche Eingabe: Nur \"J\" oder \"N\" möglich! Neuer Versuch: ");
                Console.Write("Bitte geben Sie an, ob das Smartphone über eine MicroSD-Card Slot verfügt (J / N): ");
                sdcardslot = Console.ReadLine();
                if (sdcardslot != "J" || sdcardslot != "N")
                {
                    Console.WriteLine("Falsche Eingabe: Nur \"J\" oder \"N\" möglich!");

                }
            }
            if (sdcardslot == "J")
            {
                sdcardslot = "true";
               
            }
            else sdcardslot = "false";
            tablet.MicroSDCardSlot = Boolean.Parse(sdcardslot);

            Console.WriteLine("Bitte geben Sie an, ob das Tablet über 4G verfügt:(J / N: ");
            string _4g = Console.ReadLine();
            if (_4g != "J" || _4g != "N")
            {
                Console.WriteLine("Falsche Eingabe: Nur \"J\" oder \"N\" möglich! Neuer Versuch: ");
                Console.Write("Bitte geben Sie an, ob das Tablet über eine MicroSD-Card Slot verfügt (J / N): ");
                _4g = Console.ReadLine();
                if (_4g != "J" || _4g != "N")
                {
                    Console.WriteLine("Falsche Eingabe: Nur \"J\" oder \"N\" möglich!");

                }
            }
            if (_4g == "J")
            {
                _4g = "true";

            }
            else    _4g = "false";
            tablet._4G = Boolean.Parse(_4g);
            
            return tablet;
        }

        static Notebook ErfasseNotebook()
        {
            Console.WriteLine("Notebook erfassen");
            Console.WriteLine("-----------------");

            Notebook notebook = new Notebook();
            ErfasseGeraeteDaten(notebook);

            Console.Write("Bitte geben Sie die Grösse der SSD an: ");
            notebook.SSDGroesse = Console.ReadLine();

            Console.Write("Bitte geben Sie an, ob das Notebook über eine beleuchtete Tastatur verfügt (J / N): ");
            string beleuchteteTastatur = Console.ReadLine();
            if (beleuchteteTastatur != "J" || beleuchteteTastatur != "N")
            {
                Console.WriteLine("Falsche Eingabe: Nur \"J\" oder \"N\" möglich! Neuer Versuch: ");
                Console.Write("Bitte geben Sie an, ob das Notebook über eine beleuchtete Tastatur verfügt (J / N): ");
                beleuchteteTastatur = Console.ReadLine();
                if (beleuchteteTastatur != "J" || beleuchteteTastatur != "N")
                {
                    Console.WriteLine("Falsche Eingabe: Nur \"J\" oder \"N\" möglich!");

                }
            }
            if (beleuchteteTastatur == "J")
            {
                beleuchteteTastatur = "true";

            }
            else beleuchteteTastatur = "false";
            notebook.BeleuchteteTastatur = Boolean.Parse(beleuchteteTastatur);

            Console.WriteLine("Bitte geben Sie an, ob das Notebook über einen HDMI-Anschluss verfügt (J / N: ");
            string hdmiAnschluss = Console.ReadLine();
            if (hdmiAnschluss != "J" || hdmiAnschluss != "N")
            {
                Console.WriteLine("Falsche Eingabe: Nur \"J\" oder \"N\" möglich! Neuer Versuch: ");
                Console.Write("Bitte geben Sie an, ob das Notebook über einen HDMI-Anschluss verfügt (J / N: ");
                hdmiAnschluss = Console.ReadLine();
                if (hdmiAnschluss != "J" || hdmiAnschluss != "N")
                {
                    Console.WriteLine("Falsche Eingabe: Nur \"J\" oder \"N\" möglich!");

                }
            }
            if (hdmiAnschluss == "J")
            {
                hdmiAnschluss = "true";

            }
            else hdmiAnschluss = "false";
            notebook.HDMIAnschluss = Boolean.Parse(hdmiAnschluss);

            return notebook;
        }

        static void GeraeteListeAusgeben(Geraet[] geraeteListe)
        {
            foreach (Geraet ger in geraeteListe)
            {
                if (ger != null)
                    Console.WriteLine(ger);
            }
        }
        static void ModifiziereSmartphone(Smartphone[] geraeteliste)
        {
            Console.Write("Inhalt Micro-SDCard Slot = {0}", geraeteliste[index].MicroSDCardSlot + " > Aenderung: (J / N): ");
            string sdcardslot = Console.ReadLine();
            if (sdcardslot != "")
            {
                if (sdcardslot != "J" || sdcardslot != "N")
                {
                    Console.WriteLine("Falsche Eingabe: Nur \"J\" oder \"N\" möglich! Neuer Versuch: ");
                    Console.Write("Inhalt Micro-SDCard Slot = {0}", geraeteliste[index].MicroSDCardSlot + " > Aenderung: (J / N): ");
                    sdcardslot = Console.ReadLine();
                    if (sdcardslot != "J" || sdcardslot != "N")
                    {
                        Console.WriteLine("Falsche Eingabe: Nur \"J\" oder \"N\" möglich!");

                    }
                }
                if (sdcardslot == "J")
                {
                    sdcardslot = "true";
                    Console.WriteLine("Inhalt Maximale Speichererweiterung = {0}", geraeteliste[index].MaxSpeichererweiterung + " > Aenderung:");
                    string maxSpeichererweiterung = Console.ReadLine();
                    if (maxSpeichererweiterung != "")
                    {
                        geraeteliste[index].MaxSpeichererweiterung = maxSpeichererweiterung;
                    }
                }
                else sdcardslot = "false";
                geraeteliste[index].MicroSDCardSlot = Boolean.Parse(sdcardslot);
            }
        }


        static void ModifiziereTablet(Tablet[] geraeteliste)
        {
            Console.Write("Inhalt Micro-SDCard Slot = {0}", geraeteliste[index].MicroSDCardSlot + " > Aenderung: (J / N): ");
            string sdcardslot = Console.ReadLine();
            if (sdcardslot != "")
            {
                if (sdcardslot != "J" || sdcardslot != "N")
                {
                    Console.WriteLine("Falsche Eingabe: Nur \"J\" oder \"N\" möglich! Neuer Versuch: ");
                    Console.Write("Inhalt Micro-SDCard Slot = {0}", geraeteliste[index].MicroSDCardSlot + " > Aenderung: (J / N): ");
                    sdcardslot = Console.ReadLine();
                    if (sdcardslot != "J" || sdcardslot != "N")
                    {
                        Console.WriteLine("Falsche Eingabe: Nur \"J\" oder \"N\" möglich!");

                    }
                }
                if (sdcardslot == "J")
                {
                    sdcardslot = "true";

                }
                else sdcardslot = "false";
                geraeteliste[index].MicroSDCardSlot = Boolean.Parse(sdcardslot);
            }
            Console.WriteLine("Inhalt 4G = {0}", geraeteliste[index]._4G + " > Aenderung: (J / N): ");
            string _4g = Console.ReadLine();
            if (_4g != "")
            {
                if (_4g != "J" || _4g != "N")
                {
                    Console.WriteLine("Falsche Eingabe: Nur \"J\" oder \"N\" möglich! Neuer Versuch: ");
                    Console.Write("Inhalt 4G = {0}", geraeteliste[index]._4G + " > Aenderung: (J / N): ");
                    _4g = Console.ReadLine();
                    if (_4g != "J" || _4g != "N")
                    {
                        Console.WriteLine("Falsche Eingabe: Nur \"J\" oder \"N\" möglich!");

                    }
                }
                if (_4g == "J")
                {
                    _4g = "true";
                }
                else _4g = "false";
                geraeteliste[index]._4G = Boolean.Parse(_4g);
            }
            
        }
        static void ModifiziereNotebook(Notebook[] geraeteliste)
        {
            Console.WriteLine("Inhalt SSD-Groesse = {0}", geraeteliste[index].SSDGroesse + " > Aenderung: ");
            string ssdGroesse = Console.ReadLine();
            if (ssdGroesse != "")
            {
                geraeteliste[index].SSDGroesse = ssdGroesse;
            }
            Console.Write("Inhalt Beleuchtete Tastatur = {0}", geraeteliste[index].BeleuchteteTastatur + " > Aenderung: (J / N): ");
            string beleuchteteTastatur = Console.ReadLine();
            if (beleuchteteTastatur != "")
            {
                if (beleuchteteTastatur != "J" || beleuchteteTastatur != "N")
                {
                    Console.WriteLine("Falsche Eingabe: Nur \"J\" oder \"N\" möglich! Neuer Versuch: ");
                    Console.Write("Inhalt Beleuchtete Tastatur = {0}", geraeteliste[index].BeleuchteteTastatur + " > Aenderung: (J / N): ");
                    beleuchteteTastatur = Console.ReadLine();
                    if (beleuchteteTastatur != "J" || beleuchteteTastatur != "N")
                    {
                        Console.WriteLine("Falsche Eingabe: Nur \"J\" oder \"N\" möglich!");

                    }
                }
                if (beleuchteteTastatur == "J")
                {
                    beleuchteteTastatur = "true";

                }
                else beleuchteteTastatur = "false";
                geraeteliste[index].BeleuchteteTastatur = Boolean.Parse(beleuchteteTastatur);
            }
            Console.Write("Inhalt HDMI-Anschluss = {0}", geraeteliste[index].HDMIAnschluss + " > Aenderung: (J / N): ");
            string hdmiAnschluss = Console.ReadLine();
            if (hdmiAnschluss != "")
            {
                if (hdmiAnschluss != "J" || hdmiAnschluss != "N")
                {
                    Console.WriteLine("Falsche Eingabe: Nur \"J\" oder \"N\" möglich! Neuer Versuch: ");
                    Console.Write("Inhalt HDMI-Anschluss = {0}", geraeteliste[index].HDMIAnschluss + " > Aenderung: (J / N): ");
                    hdmiAnschluss = Console.ReadLine();
                    if (hdmiAnschluss != "J" || hdmiAnschluss != "N")
                    {
                        Console.WriteLine("Falsche Eingabe: Nur \"J\" oder \"N\" möglich!");

                    }
                }
                if (hdmiAnschluss == "J")
                {
                    hdmiAnschluss = "true";

                }
                else hdmiAnschluss = "false";
                geraeteliste[index].HDMIAnschluss = Boolean.Parse(hdmiAnschluss);
            }
        }

static void ModifiziereGeraet(Geraet[] geraeteliste)
        {
            Console.WriteLine("Gerät modifizieren");
            Console.WriteLine("------------------");

            
            Console.WriteLine("Bitte geben Sie die ID des zu modifizierenden Geräts an: ");
            try
            {
                string id = Console.ReadLine();
                int ind = Convert.ToInt32(id);
                index = Array.FindIndex(geraeteliste, row => row.Id == ind);
                ModifizereGeraete(geraeteliste);
                Type a = geraeteliste[index].GetType();
                Type b = typeof(Tablet);
                if (a.Equals(b))
                {
                    
                    ModifiziereTablet((Tablet[]) geraeteliste);
                }
                Type c = typeof(Notebook);
                if (a.Equals(c))
                {
                    ModifiziereNotebook((Notebook[]) geraeteliste);
                }
                Type d = typeof(Smartphone);
                if (a.Equals(d))
                {
                    ModifiziereSmartphone((Smartphone[]) geraeteliste);
                }
            }
            catch (FormatException e)
            {
                Console.WriteLine("Es muss eine Eingabe gemacht werden! Bitte eine Taste drücken und neu wählen. ");
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine("Es muss eine Eingabe gemacht werden! Bitte eine Taste drücken und neu wählen. ");
            }
     }
        
        static void ModifizereGeraete(Geraet[] geraeteliste)
        {
            Geraet geraet = new Geraet();

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Es werden Ihnen nachstehend die vorhandenen Felder mit Inhalt aufgelistet. " +
                              "Falls Sie den Inhalt belassen wollen, drücken Sie bitte die Enter-Taste. Andernfalls geben " +
                              "Sie bitte den neuen Inhalt ein und drücken Sie dann die Enter-Taste.");
            Console.WriteLine();
            Console.WriteLine();
            Console.ResetColor();

            Console.WriteLine("Inhalt Marke = {0}", geraeteliste[index].Marke + " > Aenderung: ");
            string marke = Console.ReadLine();
            if (marke != "")
            {
                geraeteliste[index].Marke = marke;
            }
            Console.WriteLine("Inhalt Model = {0}", geraeteliste[index].Model + " > Aenderung: ");
            string model = Console.ReadLine();
            if (model != "")
            {
                geraeteliste[index].Model = model;
            }
            Console.WriteLine("Inhalt OS = {0}", geraeteliste[index].OS + " > Aenderung: ");
            string os = Console.ReadLine();
            if (os != "")
            {
                geraeteliste[index].OS = os;
            }
            Console.WriteLine("Inhalt Arbeitsspeicher = {0}", geraeteliste[index].Arbeitsspeicher + " > Aenderung: ");
            string arbeitsspeicher = Console.ReadLine();
            if (arbeitsspeicher != "")
            {
                geraeteliste[index].Arbeitsspeicher = arbeitsspeicher;
            }
            Console.WriteLine("Inhalt Speicherkapazität = {0}", geraeteliste[index].Speicherkapazitaet + " > Aenderung: ");
            string speicherkapazitaet = Console.ReadLine();
            if (speicherkapazitaet != "")
            {
                geraeteliste[index].Speicherkapazitaet = speicherkapazitaet;
            }
            Console.WriteLine("Inhalt Bildschirmgroesse = {0}", geraeteliste[index].Bildschirmgroesse + " > Aenderung: ");
            string bildschirmgroesse = Console.ReadLine();
            if (bildschirmgroesse != "")
            {
                geraeteliste[index].Bildschirmgroesse = bildschirmgroesse;
            }
            Console.WriteLine("Inhalt Akkulaufzeit = {0}", geraeteliste[index].Akkulaufzeit + " > Aenderung: ");
            try
            {
                string akkulaufzeit = Console.ReadLine();
                if (akkulaufzeit != "")
                {
                    geraeteliste[index].Akkulaufzeit = Convert.ToDouble(akkulaufzeit);
                }
            }
            catch (FormatException e)
            {
                Console.WriteLine("Falsche Eingabe, möglich sind nur Zahlen (allenfalls mit Dezimalstellen). Neuer Versuch: ");
                Console.Write("Inhalt Akkulaufzeit = {0}", geraeteliste[index].Akkulaufzeit + " > Aenderung: ");
                try
                {
                    string akkulaufzeit = Console.ReadLine();
                    if (akkulaufzeit != "")
                    {
                        geraeteliste[index].Akkulaufzeit = Convert.ToDouble(akkulaufzeit);
                    }
                }
                catch (FormatException e1)
                {
                    Console.WriteLine("Falsche Eingabe, möglich sind nur Zahlen (allenfalls mit Dezimalstellen).");

                }
            }
                
            Console.WriteLine("Inhalt Prozessortyp = {0}", geraeteliste[index].Prozessortyp + " > Aenderung: ");
            string prozessortyp = Console.ReadLine();
            if (prozessortyp != "")
            {
                geraeteliste[index].Prozessortyp = prozessortyp;
            }
            Console.WriteLine("Inhalt Anzahl Prozessoren = {0}", geraeteliste[index].AnzahlProzessoren + " > Aenderung: ");
            try
            {
                string anzahlprozessoren = Console.ReadLine();
                if (anzahlprozessoren != "")
                {
                    geraeteliste[index].AnzahlProzessoren = Convert.ToInt32(anzahlprozessoren);
                }

            }
            catch (FormatException e)
            {
                Console.WriteLine("Falsche Eingabe, möglich sind nur ganze Zahlen. Neuer Versuch: ");
                Console.Write("Inhalt Anzahl Prozessoren = {0}", geraeteliste[index].AnzahlProzessoren + " > Aenderung: ");
                try
                {
                    string anzahlprozessoren = Console.ReadLine();
                    if (anzahlprozessoren != "")
                    {
                        geraeteliste[index].AnzahlProzessoren = Convert.ToInt32(anzahlprozessoren);
                    }
                }
                catch (FormatException e1)
                {
                    Console.WriteLine("Falsche Eingabe, möglich sind nur ganze Zahlen.");

                }
            }
            Console.WriteLine("Inhalt Farbe = {0}", geraeteliste[index].Farbe + " > Aenderung (0: schwarz, 1: grau, 2: weiss, 3: blau, 4: rot, 5: grün): ");
            try
            {
                string farbe = Console.ReadLine();
                if (farbe != "")
                {
                    int f = Convert.ToInt32(farbe);
                    if (f < 0 || f > 5)
                    {
                        Console.WriteLine("Falsche Eingabe: Nur Zahlen zwischen 0 und 5 möglich! Neuer Versuch: ");
                        Console.Write("Inhalt Farbe = {0}", geraeteliste[index].Farbe + " > Aenderung (0: schwarz, 1: grau, 2: weiss, 3: blau, 4: rot, 5: grün): ");
                        farbe = Console.ReadLine();
                        if (farbe != "")
                        {
                            int f1 = Convert.ToInt32(farbe);
                            if (f1 < 0 || f1 > 5)
                            {
                                Console.WriteLine("Falsche Eingabe: Nur Zahlen zwischen 0 und 5 möglich!");
                            }
                        }
                    }
                    geraeteliste[index].Farbe = (Farbe)Enum.Parse(typeof(Farbe), farbe);
                }
            }
            catch (FormatException e)
            {
                Console.WriteLine("Falsche Eingabe: Nur Zahlen zwischen 0 und 5 möglich! Neuer Versuch: ");
                Console.Write("Inhalt Farbe = {0}", geraeteliste[index].Farbe + " > Aenderung (0: schwarz, 1: grau, 2: weiss, 3: blau, 4: rot, 5: grün): ");
                try
                {
                    string farbe = Console.ReadLine();
                    if (farbe != "")
                    {
                        int f = Convert.ToInt32(farbe);
                        if (f < 0 || f > 5)
                        {
                            Console.WriteLine("Falsche Eingabe: Nur Zahlen zwischen 0 und 5 möglich! Neuer Versuch: ");
                            Console.Write("Inhalt Farbe = {0}", geraeteliste[index].Farbe + " > Aenderung (0: schwarz, 1: grau, 2: weiss, 3: blau, 4: rot, 5: grün): ");
                            farbe = Console.ReadLine();
                            if (farbe != "")
                            {
                                int f1 = Convert.ToInt32(farbe);
                                if (f1 < 0 || f1 > 5)
                                {
                                    Console.WriteLine("Falsche Eingabe: Nur Zahlen zwischen 0 und 5 möglich!");
                                }
                            }
                        }
                        geraeteliste[index].Farbe = (Farbe)Enum.Parse(typeof(Farbe), farbe);
                    }

                }
                catch (FormatException e1)
                {
                    Console.WriteLine("Falsche Eingabe: Nur Zahlen zwischen 0 und 5 möglich!");

                }
            }
            Console.WriteLine("Inhalt Kaufpreis = {0}", geraeteliste[index].Kaufpreis + " > Aenderung: ");
            try
            {
                string kaufpreis = Console.ReadLine();
                if (kaufpreis != "")
                {
                    geraeteliste[index].Kaufpreis = Convert.ToDouble(kaufpreis);
                }
            }
            catch (FormatException e)
            {
                Console.WriteLine("Falsche Eingabe, möglich sind nur Zahlen (allenfalls mit Dezimalstellen). Neuer Versuch: ");
                Console.Write("Inhalt Kaufpreis = {0}", geraeteliste[index].Kaufpreis + " > Aenderung: ");
                try
                {
                    string kaufpreis = Console.ReadLine();
                    if (kaufpreis != "")
                    {
                        geraeteliste[index].Kaufpreis = Convert.ToDouble(kaufpreis);
                    }
                }
                catch (FormatException e1)
                {
                    Console.WriteLine("Falsche Eingabe, möglich sind nur Zahlen (allenfalls mit Dezimalstellen).");

                }
            }
        }
        

        static Geraet LoescheGeraet(Geraet[] geraeteliste)
        {
            Console.WriteLine("Gerät löschen");
            Console.WriteLine("-------------");

            Geraet geraet = new Geraet();
            GeraeteID = (Array.FindLastIndex(geraeteliste, n => n != null) + 1);
            
            Console.WriteLine("Bitte geben Sie die ID des zu löschenden Geräts an: ");
            try
            {
                string id = Console.ReadLine();
                int ind = Convert.ToInt32(id);
                int index = Array.FindIndex(geraeteliste, row => row.Id == ind);
                Array.Clear(geraeteliste, index, 1);
                Console.WriteLine("Gerät mit ID {0} wurde gelöscht.", ind);

                return geraet;
            }
           
            catch (FormatException e) 
            {Console.WriteLine("Falsche Eingabe: Es sind nur Zahlen zwischen 1 und {0} möglich. Bitte eine Taste drücken und neu wählen.", GeraeteID);}
            catch (NullReferenceException e) 
            { Console.WriteLine("Falsche Eingabe: Es sind nur Zahlen zwischen 1 und {0} möglich. Bitte eine Taste drücken und neu wählen.", GeraeteID); }
            return geraet;
        }

    }
}
    
