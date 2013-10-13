using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Phidgets;
using Phidgets.Events;

namespace ToegangsApp_ICT4Events
{
    class ToegangManager
    {        
        private Interface_ICT4events.DBconnect connectie = Interface_ICT4events.DBconnect.Instantie;
        public bool VeranderAanAfwezig(string RFIDtag)
        {
            bool aanwezigheid;
            string[] AanAfwezig = connectie.Select("bezoeker", "*", "RFID = '" +RFIDtag+"'");
            if (AanAfwezig[6] == "Y")
            {
                connectie.Update("bezoeker", "Aanwezig = N", "BezoekerID = '" +AanAfwezig[0]+"'");
                aanwezigheid = false;
            }
            else
            {
                connectie.Update("bezoeker", "Aanwezig = Y", "BezoekerID = '" +AanAfwezig[0]+"'");
                aanwezigheid = true;
            }
            return aanwezigheid;
        }


        public string ZoekPersoon(string DocumentNr)
        {
            string[] naam = connectie.Select("Bezoeker", "*", "Documentnr = '" + DocumentNr+"'");
            return naam[2];
        }
        private RFID rfid = new RFID();
        public string LinkRFID(string DocumentNr)
        {
            rfid.open();
            string antwoord = "Geen RFID aangesloten";
            if (rfid.Attached == true)
            {
                antwoord = "Geen RFID tag gevonden";
                if (rfid.TagPresent == true)
                {
                    connectie.Update("Bezoeker", "RFID = '" + rfid.LastTag + "'", "documentnr ='" + DocumentNr + "'");
                    antwoord = "RFID Link succesvol";
                }
            }
            return antwoord;
            
        }


    }
}
