using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToegangsApp_ICT4Events
{
    public class Huurder
    {
        protected bool aanwezig;
        protected string adres;
        protected string documentnr;
        protected string geboortedatum;
        protected string naam;
        protected int RFIDcode;
        protected string woonplaats;

        public Huurder(bool aanwezig, string adres, string documentnr, string geboortedatum, string naam, int rfidCode, string woonplaats)
        {
            this.aanwezig = aanwezig;
            this.adres = adres;
            this.documentnr = documentnr;
            this.geboortedatum = geboortedatum;
            this.naam = naam;
            this.RFIDcode = rfidCode;
            this.woonplaats = woonplaats;
        }
    }
}
