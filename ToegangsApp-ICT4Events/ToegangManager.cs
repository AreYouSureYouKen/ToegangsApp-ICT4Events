using System;
using System.IO;
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
        // maakt een instantie aan van de database connectie voor het updaten van de velden.
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
            // probeert de bezoeker te vinden vanuit de database via de RFID tag en zet het over op aanwezig of afwezig
            // als er geen gevonden word dan word er afwezig teruggegeven naar het formulier
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
            /// probeert een bezoeker uit de database op te halen door middel van zijn/haar documentnr
            /// als dit niet lukt word er terugestuurd dat er niemand gevonden is
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
            /// probeert de betaling om te zetten naar betaald in de database
            /// wanneer dit niet lukt word er teruggegeven dat dit mislukt is.
        }

        public void Aanwezigen()
        {
            DataTable aanwezig = new DataTable();
            aanwezig = connectie.SelectMultiple("bezoeker", "Naam", "Aanwezig = 'Y'");
            using (StreamWriter sw = File.CreateText(
                Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Aanwezigen.txt")))
                foreach (DataRow aan in aanwezig.Rows)
                {
                    sw.WriteLine(aan["naam"].ToString());
                }
            /// schrijft een lijst weg van alle aanwezigen in een textbestand op de desktop van de gebruiker
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
            /// dit probeert een RFID tag toe te voegen aan de gevonden bezoeker, hier word een bepaalde tijd voor
            /// vrijgemaakt voordat dit een error terug geeft als er geen tag gevonden is.
            
        }


        public void CloseRFID()
        {
            rfid.close();
        }

    }
}
