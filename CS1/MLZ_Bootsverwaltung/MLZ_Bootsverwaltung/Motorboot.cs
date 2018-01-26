using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLZ_Bootsverwaltung
{
    [Serializable]
    public class Motorboot : Boot
    {
        public int PS { get; set; }
        public int MaxSpeedMotor { get; set; }
        public int MaxSpeedSegel { get; set; }

        public override string ToString()
        {
            return $"Id:{ID}, Typ:{Typ}, Marke:{Marke}, Mod:{Modell}, Farbe: {Farbe}," +
                  $"Num: {Nummernschild}, Miete: {Tagesmiete} Pers.:" +
                  $" {AnzahlPersonen} PS: {PS}, Spd. M: {MaxSpeedMotor} Spd. S {MaxSpeedSegel}";

        }   
    }
}
