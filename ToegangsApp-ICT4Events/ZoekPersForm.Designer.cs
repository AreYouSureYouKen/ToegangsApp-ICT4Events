namespace ToegangsApp_ICT4Events
{
    partial class ZoekPersForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbDocNr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnZoekPers = new System.Windows.Forms.Button();
            this.btnLinkRFID = new System.Windows.Forms.Button();
            this.lblNaam = new System.Windows.Forms.Label();
            this.lblBetaald = new System.Windows.Forms.Label();
            this.btnBetaal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbDocNr
            // 
            this.tbDocNr.Location = new System.Drawing.Point(15, 29);
            this.tbDocNr.Name = "tbDocNr";
            this.tbDocNr.Size = new System.Drawing.Size(100, 22);
            this.tbDocNr.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Document Nr";
            // 
            // btnZoekPers
            // 
            this.btnZoekPers.AutoSize = true;
            this.btnZoekPers.Location = new System.Drawing.Point(121, 4);
            this.btnZoekPers.Name = "btnZoekPers";
            this.btnZoekPers.Size = new System.Drawing.Size(107, 27);
            this.btnZoekPers.TabIndex = 2;
            this.btnZoekPers.Text = "Zoek Persoon";
            this.btnZoekPers.UseVisualStyleBackColor = true;
            this.btnZoekPers.Click += new System.EventHandler(this.btnZoekPers_Click);
            // 
            // btnLinkRFID
            // 
            this.btnLinkRFID.AutoSize = true;
            this.btnLinkRFID.Enabled = false;
            this.btnLinkRFID.Location = new System.Drawing.Point(234, 4);
            this.btnLinkRFID.Name = "btnLinkRFID";
            this.btnLinkRFID.Size = new System.Drawing.Size(75, 27);
            this.btnLinkRFID.TabIndex = 3;
            this.btnLinkRFID.Text = "LinkRFID";
            this.btnLinkRFID.UseVisualStyleBackColor = true;
            this.btnLinkRFID.Click += new System.EventHandler(this.btnLinkRFID_Click);
            // 
            // lblNaam
            // 
            this.lblNaam.AutoSize = true;
            this.lblNaam.Location = new System.Drawing.Point(13, 51);
            this.lblNaam.Name = "lblNaam";
            this.lblNaam.Size = new System.Drawing.Size(49, 17);
            this.lblNaam.TabIndex = 4;
            this.lblNaam.Text = "Naam:";
            // 
            // lblBetaald
            // 
            this.lblBetaald.AutoSize = true;
            this.lblBetaald.Location = new System.Drawing.Point(12, 76);
            this.lblBetaald.Name = "lblBetaald";
            this.lblBetaald.Size = new System.Drawing.Size(60, 17);
            this.lblBetaald.TabIndex = 5;
            this.lblBetaald.Text = "Betaald:";
            // 
            // btnBetaal
            // 
            this.btnBetaal.Location = new System.Drawing.Point(239, 77);
            this.btnBetaal.Name = "btnBetaal";
            this.btnBetaal.Size = new System.Drawing.Size(75, 23);
            this.btnBetaal.TabIndex = 6;
            this.btnBetaal.Text = "Betalen";
            this.btnBetaal.UseVisualStyleBackColor = true;
            this.btnBetaal.Visible = false;
            this.btnBetaal.Click += new System.EventHandler(this.btnBetaal_Click);
            // 
            // ZoekPersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 102);
            this.Controls.Add(this.btnBetaal);
            this.Controls.Add(this.lblBetaald);
            this.Controls.Add(this.lblNaam);
            this.Controls.Add(this.btnLinkRFID);
            this.Controls.Add(this.btnZoekPers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbDocNr);
            this.Name = "ZoekPersForm";
            this.Text = "ZoekPersForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Close_Click);
            this.Load += new System.EventHandler(this.ZoekPersForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbDocNr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnZoekPers;
        private System.Windows.Forms.Button btnLinkRFID;
        private System.Windows.Forms.Label lblNaam;
        private System.Windows.Forms.Label lblBetaald;
        private System.Windows.Forms.Button btnBetaal;
    }
}