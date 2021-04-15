using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT02_Y1_Klassen
{
    class Gerät : IGerätModel
    {
        public int Gerätenummer { get; private set; }
        public string Bezeichnung { get; private set; }
        public DateTime Kaufdatum { get; private set; }

        private static int anzahl = 0;

        public Gerät(int nr, string bz)
        {
            Gerätenummer = nr;
            Bezeichnung = bz;
            Kaufdatum = DateTime.Now;
            anzahl++;
        }

        public int getAnzahl()
        {
            return anzahl;
        }

        public string getGeraetedaten()
        {
            return $"Gerätenummer: {Gerätenummer}   Bezeichnung: {Bezeichnung}  Kaufdatum: {Kaufdatum.ToString()}";
        }
    }
}
