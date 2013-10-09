using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToegangsApp_ICT4Events
{
    class HHuurder : Huurder
    {
        private string emailadres;
        private string rekeningnummer;

        public HHuurder(string Emailadres, string Rekeningnummer, bool Aanwezig, string Adres, string Documentnr, string Geboortedatum, string Naam, int RFIDCode, string Woonplaats)
            : base(Aanwezig,Adres,Documentnr,Geboortedatum,Naam,RFIDCode,Woonplaats)
        {
            emailadres = Emailadres;
            rekeningnummer = Rekeningnummer;
        }
    }
}
