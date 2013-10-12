using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToegangsApp_ICT4Events
{
    class ToegangManager
    {
        private Interface_ICT4events.DBconnect connectie = Interface_ICT4events.DBconnect.Instantie;
        public bool VeranderAanAfwezig(string RFIDtag)
        {
            bool aanwezigheid;
            string[] AanAfwezig = connectie.Select("bezoeker", "BezoekerID, Aanwezig", RFIDtag);
            if (AanAfwezig[1] == "Y")
            {
                connectie.Update("bezoeker", "Aanwezig = N", "BezoekerID = " +AanAfwezig[0]);
                aanwezigheid = false;
            }
            else
            {
                connectie.Update("bezoeker", "Aanwezig = Y", "BezoekerID = " +AanAfwezig[0]);
                aanwezigheid = true;
            }
            return aanwezigheid;
        }
    }
}
