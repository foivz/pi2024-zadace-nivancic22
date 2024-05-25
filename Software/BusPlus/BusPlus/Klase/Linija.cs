using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusPlus.Klase
{
    public class Linija
    {
        public int ID_linije { get; set; }
        public string PocetnaStanica { get; set; }
        public string ZavrsnaStanica { get; set; }
        public int BrojAutobusa { get; set; }
        public string PocetnoVrijeme { get; set; }
        public string ZavrsnoVrijeme { get; set; }

    }
}
