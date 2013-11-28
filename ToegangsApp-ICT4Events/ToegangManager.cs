using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Phidgets;
using Phidgets.Events;

namespace ToegangsApp_ICT4Events
{
    public class ToegangManager
    {        
        private Interface_ICT4events.DBconnect connectie = Interface_ICT4events.DBconnect.Instantie;
        private RFID rfid = new RFID();

        /// maakt een instantie aan van de database connectie voor het updaten van de velden.
        /// Maakt tevens ook een rfid instantie aan wat verderop in de klasse gebruikt word
        
        public bool VeranderAanAfwezig(string rfidtag)
        {
            try
            {
                bool aanwezigheid;
                DataRow aanAfwezig = this.connectie.SingleSelect("bezoeker", "BezoekerID,Aanwezig", "RFID = '" + rfidtag + "'");
                if (aanAfwezig["Aanwezig"].ToString() == "Y")
                {
                    this.connectie.Update("bezoeker", "Aanwezig = 'N'", "BezoekerID = '" + aanAfwezig["BezoekerID"].ToString() + "'");
                    aanwezigheid = false;
                }
                else
                {
                    this.connectie.Update("bezoeker", "Aanwezig = 'Y'", "BezoekerID = '" + aanAfwezig["BezoekerID"].ToString() + "'");
                    aanwezigheid = true;
                }
                return aanwezigheid;
            }
            catch
            {
                return false;
            }
            /// probeert de bezoeker te vinden vanuit de database via de RFID tag en zet het over op aanwezig of afwezig
            /// als er geen gevonden word dan word er afwezig teruggegeven naar het formulier
        }

        public string[] ZoekPersoon(string documentNr)
        {
            List<string> naam = new List<string>();
            try
            {
                DataRow sqlnaam = this.connectie.SingleSelect("Bezoeker b, reservering r, reservering_bezoeker rb", "b.Naam, r.IsBetaald", "b.bezoekerID = rb.bezoekerID AND r.reserveringid = rb.reserveringid AND Documentnr = '" + documentNr + "'");
                naam.Add(sqlnaam["Naam"].ToString());
                naam.Add(sqlnaam["IsBetaald"].ToString());
                return naam.ToArray();
            }
            catch {
                naam.Add("Geen persoon gevonden");
                naam.Add("Geen betaling gevonden");
                return naam.ToArray();
            }
            /// probeert een bezoeker uit de database op te halen door middel van zijn/haar documentnr
            /// als dit niet lukt word er terugestuurd dat er niemand gevonden is
        }

        public string Betaal(string naam)
        {
            string gelukt;
            
            try
            {
                this.connectie.Update("reservering r, bezoeker b, reservering_bezoeker rb", "IsBetaald ='Y'", "b.bezoekerID = rb.bezoekerID AND r.reserveringid = rb.reserveringid AND Naam = '" + naam + "'");
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
            aanwezig = this.connectie.SelectMultiple("bezoeker", "Naam", "Aanwezig = 'Y'");
            using (StreamWriter sw = File.CreateText(
                Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Aanwezigen.txt")))
                foreach (DataRow aan in aanwezig.Rows)
                {
                    sw.WriteLine(aan["naam"].ToString());
                }
            /// schrijft een lijst weg van alle aanwezigen in een textbestand op de desktop van de gebruiker
        }
        
        public string LinkRFID(string documentNr)
        {
            try
            {
                this.rfid.open();
                string antwoord = "Geen RFID aangesloten";
                this.rfid.waitForAttachment(2000);
                    antwoord = "Geen RFID tag gevonden";
                    for (int i = 0; this.rfid.TagPresent == false; i++ )
                    {
                        if (i == 10000000)
                        {
                            break;
                        }
                        if (this.rfid.TagPresent == true)
                        {
                            break;
                        }
                    }
                    this.connectie.Update("Bezoeker", "RFID = '" + this.rfid.LastTag + "'", "documentnr ='" + documentNr + "'");
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
            this.rfid.close();
        }

    }
}
