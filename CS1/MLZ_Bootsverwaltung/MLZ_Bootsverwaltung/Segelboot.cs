using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLZ_Bootsverwaltung
{
    [Serializable]
    class Segelboot : Boot
    {
        public int PS { get; set; }
        public int MaxSpeedMotor { get; set; }
        public int MaxSpeedSegel { get; set; }
    }
}
