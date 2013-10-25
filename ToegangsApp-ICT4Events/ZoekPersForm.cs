using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToegangsApp_ICT4Events
{
    public partial class ZoekPersForm : Form
    {
        private ToegangManager toegang = new ToegangManager();
        public ZoekPersForm()
        {
            InitializeComponent();
        }

        private void btnZoekPers_Click(object sender, EventArgs e)
        {
            string[] naam = toegang.ZoekPersoon(tbDocNr.Text);
            lblNaam.Text = naam[0];
            lblBetaald.Text = naam[1];
            btnLinkRFID.Enabled = true;
            if (naam[1] == "N")
            {
                btnBetaal.Visible = true;
            }
            else
            {
                btnBetaal.Visible = false;
            }
            /// hiermee word de naam opgehaald van de bezoeker en een aantal gegevens weergegeven
            /// tevens worden er een of meerdere knoppen aan gezet
        }

        private void btnLinkRFID_Click(object sender, EventArgs e)
        {
            string antwoord = toegang.LinkRFID(tbDocNr.Text);
            lblNaam.Text = antwoord;
            /// hiermee krijg je te zien of het linken van de tag is gelukt.
        }

        private void ZoekPersForm_Load(object sender, EventArgs e)
        {

        }

        private void Close_Click(object sender, FormClosedEventArgs e)
        {
            toegang.CloseRFID();
            ToegangsAppForm toegangForm = new ToegangsAppForm();
            toegangForm.Show();
            /// wanneer het zoek persoon formulier gesloten word, word het toegangsformulier
            /// weer weergegeven
        }

        private void btnBetaal_Click(object sender, EventArgs e)
        {
            string betaald = toegang.Betaal(lblNaam.Text);
            lblBetaald.Text = betaald;
            /// hiermee krijg je te zien of het betalen gelukt is.
        }


    }
}
