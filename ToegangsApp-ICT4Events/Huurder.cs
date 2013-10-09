using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToegangsApp_ICT4Events
{
    class Huurder
    {
        protected bool aanwezig;
        protected string adres;
        protected string documentnr;
        protected string geboortedatum;
        protected string naam;
        protected int RFIDcode;
        protected string woonplaats;

        public Huurder(bool Aanwezig, string Adres, string Documentnr, string Geboortedatum, string Naam, int RFIDCode, string Woonplaats)
        {
            aanwezig = Aanwezig;
            adres = Adres;
            documentnr = Documentnr;
            geboortedatum = Geboortedatum;
            naam = Naam;
            RFIDcode = RFIDCode;
            woonplaats = Woonplaats;
        }
    }
}
