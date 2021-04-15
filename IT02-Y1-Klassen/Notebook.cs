using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT02_Y1_Klassen
{
    class Notebook : IGerätModel
    {
        public int Gerätenummer { get; set; }
        public string Bezeichnung { get; set; } = "Notebook";
        public DateTime Kaufdatum { get; set; }

        public string getGeraetedaten()
        {
            return $"{Gerätenummer} {Bezeichnung} {Kaufdatum}";
        }
        public int getAnzahl() { return 1; }
    }
}
