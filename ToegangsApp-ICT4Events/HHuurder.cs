using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToegangsApp_ICT4Events
{
    public class HHuurder : Huurder
    {
        private string emailadres;
        private string rekeningnummer;

        public HHuurder(string emailadres, string rekeningnummer, bool aanwezig, string adres, string documentnr, string geboortedatum, string naam, int rfidCode, string woonplaats)
            : base(aanwezig,adres,documentnr,geboortedatum,naam,rfidCode,woonplaats)
        {
            this.emailadres = emailadres;
            this.rekeningnummer = rekeningnummer;
        }
    }
}
