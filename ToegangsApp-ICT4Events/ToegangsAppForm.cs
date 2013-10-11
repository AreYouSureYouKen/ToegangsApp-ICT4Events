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
        public ToegangsAppForm()
        {
            InitializeComponent();
            rfid = new RFID();
            rfid.Attach += new AttachEventHandler(rfid_attach);
            rfid.Tag += new TagEventHandler(rfid_tag);
            rfid.open();
        }

        void rfid_attach(object sender, AttachEventArgs e)
        {
            RFID attached = (RFID)sender;
            rfid.Antenna = Enabled;
            btnBetaal.Enabled = true;
            btnCheckRFID.Enabled = true;
            rfid.LED = true;
        }

        void rfid_tag(object sender, TagEventArgs e)
        {
            lblCheckin.Text = e.Tag;
        }
        
        private void btnCheckRFID_Click(object sender, EventArgs e)
        {

        }

    }
}
