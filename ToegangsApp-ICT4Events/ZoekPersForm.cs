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
            string naam = toegang.ZoekPersoon(tbDocNr.Text);
            lblNaam.Text = naam;
            btnLinkRFID.Enabled = true;
        }

        private void btnLinkRFID_Click(object sender, EventArgs e)
        {
            string antwoord = toegang.LinkRFID(tbDocNr.Text);
            lblNaam.Text = antwoord;
        }

        private void ZoekPersForm_Load(object sender, EventArgs e)
        {

        }

        private void Close_Click(object sender, FormClosingEventArgs e)
        {
            ToegangsAppForm toegang = new ToegangsAppForm();
            toegang.Show();
        }


    }
}
