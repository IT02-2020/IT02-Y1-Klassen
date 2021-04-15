using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT02_Y1_Klassen
{
    class Person
    {
        public int Personalnummer { get; set; }
        public string Nachnahme { get; set; }
        public string Ort { get; set; }
        public int PLZ { get; private set; }
        public string StrNr { get; set; }

        //private int _personalnummer;

        //public void Setprnr(int nr) { this._personalnummer = nr  } 

        public Person(int personalnumber, string nachnahme, string ort, int plz, string strNr)
        {
            Personalnummer = personalnumber;
            Nachnahme = nachnahme;
            Ort = ort;
            SetPlz(plz);
            StrNr = strNr;
        }

        bool SetPlz(int plz)
        {
            if(plz.ToString().Length == 5)
            {
                PLZ = plz;
                return true;
            }
            PLZ = 00000;
            return false;
        }
    }
}
