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
        }

        void rfid_Attach(object sender, AttachEventArgs e)
        {
            RFID attached = (RFID)sender;
            rfid.Antenna = Enabled;
            btnBetaal.Enabled = true;
            rfid.LED = true;
        }

        void rfid_Detach(object sender, DetachEventArgs e)
        {
            btnBetaal.Enabled = false;
        }

        void rfid_Tag(object sender, TagEventArgs e)
        {
            bool aanwezigheid = toegang.VeranderAanAfwezig(e.Tag);
            if (aanwezigheid == false)
            {
                lblCheckin.Text = "Check in";
                lblCheckin.ForeColor = System.Drawing.Color.Green;
            }
            else if (aanwezigheid == true)
            {
                lblCheckin.Text = "Check uit";
                lblCheckin.ForeColor = System.Drawing.Color.Red;
            }
            System.Threading.Thread.Sleep(2000);
        }

        void rfid_TagLost(object sender, TagEventArgs e)
        {
            lblCheckin.Text = "Check -in/-uit";
            lblCheckin.ForeColor = System.Drawing.Color.Black;
            System.Threading.Thread.Sleep(2000);
        }

        private void btnZoekPersForm_Click(object sender, EventArgs e)
        {
            ZoekPersForm zoekpersoon = new ZoekPersForm();
            zoekpersoon.Show();
            this.Hide();
        }

    }
}
