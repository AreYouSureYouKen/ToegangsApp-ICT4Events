using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Phidgets;
using Phidgets.Events;

namespace ToegangsApp_ICT4Events
{
    public partial class ToegangsAppForm : Form
    {
        private RFID rfid;
        private ToegangManager toegang = new ToegangManager();
        public ToegangsAppForm()
        {
            InitializeComponent();
            rfid = new RFID();
            rfid.Attach += new AttachEventHandler(rfid_Attach);
            rfid.Detach += new DetachEventHandler(rfid_Detach);
            rfid.Tag += new TagEventHandler(rfid_Tag);
            rfid.TagLost += new TagEventHandler(rfid_TagLost);
            rfid.open();
            // initialiseren van de rfid functies en hier een event aan koppelen
        }

        void rfid_Attach(object sender, AttachEventArgs e)
        {
            RFID attached = (RFID)sender;
            rfid.Antenna = Enabled;
            rfid.LED = true;
            lblCheckin.Text = "Check -in/-uit";
            // wanneer er een rfid aangesloten is word de antenna aangezet en de LED om aan te geven dat deze aangesloten is
        }

        void rfid_Detach(object sender, DetachEventArgs e)
        {
            lblCheckin.Text = "...";
            // als de rfid er uit gehaald word veranderd de tekst om aan te geven dat er geen aangesloten is.
        }

        void rfid_Tag(object sender, TagEventArgs e)
        {
            bool aanwezigheid = toegang.VeranderAanAfwezig(e.Tag);
            if (aanwezigheid == false)
            {
                lblCheckin.ForeColor = System.Drawing.Color.Red;
                lblCheckin.Text = "Check uit";
            }
            else if (aanwezigheid == true)
            {
                lblCheckin.ForeColor = System.Drawing.Color.Green;
                lblCheckin.Text = "Check in";
            }
            // hiermee word weergegeven of dat de persoon in of uit checkt d.m.v. tekst en kleur.
        }

        void rfid_TagLost(object sender, TagEventArgs e)
        {
            System.Threading.Thread.Sleep(500);
            lblCheckin.Text = "Check -in/-uit";
            lblCheckin.ForeColor = System.Drawing.Color.Black;
            // Als de rfid tag weg is van de scanner dan word het hiermee weer terug gezet
        }

        private void btnZoekPersForm_Click(object sender, EventArgs e)
        {
            ZoekPersForm zoekpersoon = new ZoekPersForm();
            zoekpersoon.Show();
            this.Hide();
            rfid.close();
            // Hiermee word het andere formulier geopend voor het zoeken van personen
        }

        private void ClosingForm(object sender, FormClosingEventArgs e)
        {
            if (rfid.Attached == true)
            {
                rfid.LED = false;
            }
            //Hiermee word de LED op de rfid uit geschakeld wanneer het programma afgesloten word
        }

        private void btnToonAanwezig_Click(object sender, EventArgs e)
        {
            toegang.Aanwezigen();
            MessageBox.Show("Bestand succesvol naar uw desktop geschreven.");
            //Wanneer het succesvol uitgevoerd is word er een box getoond met dit bericht
        }

    }
}
