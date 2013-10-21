using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Phidgets;
using Phidgets.Events;
using System.Data;

namespace ToegangsApp_ICT4Events
{
    class ToegangManager
    {        
        private Interface_ICT4events.DBconnect connectie = Interface_ICT4events.DBconnect.Instantie;
        public bool VeranderAanAfwezig(string RFIDtag)
        {
            try
            {
                bool aanwezigheid;
                DataRow AanAfwezig = connectie.SingleSelect("bezoeker", "BezoekerID,Aanwezig", "RFID = '" + RFIDtag + "'");
                if (AanAfwezig["Aanwezig"].ToString() == "Y")
                {
                    connectie.Update("bezoeker", "Aanwezig = 'N'", "BezoekerID = '" + AanAfwezig["BezoekerID"].ToString() + "'");
                    aanwezigheid = false;
                }
                else
                {
                    connectie.Update("bezoeker", "Aanwezig = 'Y'", "BezoekerID = '" + AanAfwezig["BezoekerID"].ToString() + "'");
                    aanwezigheid = true;
                }
                return aanwezigheid;
            }
            catch
            {
                return false;
            }
        }


        public string ZoekPersoon(string DocumentNr)
        {
            DataRow naam = connectie.SingleSelect("Bezoeker", "*", "Documentnr = '" + DocumentNr+"'");
            return naam["Naam"].ToString();
        }
        private RFID rfid = new RFID();
        public string LinkRFID(string DocumentNr)
        {
            try
            {
                rfid.open();
                rfid.waitForAttachment(2000);
                string antwoord = "Geen RFID aangesloten";
                if (rfid.Attached == true)
                {
                    antwoord = "Geen RFID tag gevonden";
                    for (int i = 0; rfid.TagPresent == false; i++ )
                    {
                        if (i == 10000000)
                        {
                            break;
                        }
                        if (rfid.TagPresent == true)
                        {
                            break;
                        }
                    }
                    connectie.Update("Bezoeker", "RFID = '" + rfid.LastTag + "'", "documentnr ='" + DocumentNr + "'");
                    antwoord = "RFID Link succesvol";

                }
                return antwoord;
            }
            catch(PhidgetException)
            {
                return "Error.";
            }
            
        }


    }
}
