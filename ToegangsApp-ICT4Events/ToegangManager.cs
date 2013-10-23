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


        public string[] ZoekPersoon(string DocumentNr)
        {
            List<string> Naam = new List<string>();
            try
            {
                DataRow naam = connectie.SingleSelect("Bezoeker b, reservering r, reservering_bezoeker rb", "b.Naam, r.IsBetaald", "b.bezoekerID = rb.bezoekerID AND r.reserveringid = rb.reserveringid AND Documentnr = '" + DocumentNr + "'");
                Naam.Add(naam["Naam"].ToString());
                Naam.Add(naam["IsBetaald"].ToString());


                return Naam.ToArray();
            }
            catch {
                Naam.Add("Geen persoon gevonden");
                Naam.Add("Geen betaling gevonden");
                return Naam.ToArray();
            }
        }

        public string Betaal(string Naam)
        {
            string gelukt;
            
            try
            {
                connectie.Update("reservering r, bezoeker b, reservering_bezoeker rb", "IsBetaald ='Y'", "b.bezoekerID = rb.bezoekerID AND r.reserveringid = rb.reserveringid AND Naam = '" + Naam + "'");
                gelukt = "Betaald.";
            }
            catch
            {
                gelukt = "Mislukt.";
            }

            return gelukt;
        }
        
        private RFID rfid = new RFID();
        public string LinkRFID(string DocumentNr)
        {
            try
            {
                rfid.open();
                string antwoord = "Geen RFID aangesloten";
                rfid.waitForAttachment(2000);
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

                return antwoord;
            }
            catch(PhidgetException)
            {
                return "Error.";
            }
            
        }


        public void CloseRFID()
        {
            rfid.close();
        }

    }
}
