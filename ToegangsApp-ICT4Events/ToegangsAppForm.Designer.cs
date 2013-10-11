namespace ToegangsApp_ICT4Events
{
    partial class ToegangsAppForm
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
            this.lblBetaald = new System.Windows.Forms.Label();
            this.lblCheckin = new System.Windows.Forms.Label();
            this.btnBetaal = new System.Windows.Forms.Button();
            this.btnZoekPersForm = new System.Windows.Forms.Button();
            this.btnCheckRFID = new System.Windows.Forms.Button();
            this.btnGevAanpass = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBetaald
            // 
            this.lblBetaald.AutoSize = true;
            this.lblBetaald.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBetaald.Location = new System.Drawing.Point(12, 9);
            this.lblBetaald.Name = "lblBetaald";
            this.lblBetaald.Size = new System.Drawing.Size(284, 36);
            this.lblBetaald.TabIndex = 0;
            this.lblBetaald.Text = "Betaald/Niet Betaald";
            // 
            // lblCheckin
            // 
            this.lblCheckin.AutoSize = true;
            this.lblCheckin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckin.Location = new System.Drawing.Point(18, 76);
            this.lblCheckin.Name = "lblCheckin";
            this.lblCheckin.Size = new System.Drawing.Size(166, 31);
            this.lblCheckin.TabIndex = 1;
            this.lblCheckin.Text = "Check -in/uit";
            // 
            // btnBetaal
            // 
            this.btnBetaal.AutoSize = true;
            this.btnBetaal.Enabled = false;
            this.btnBetaal.Location = new System.Drawing.Point(427, 12);
            this.btnBetaal.Name = "btnBetaal";
            this.btnBetaal.Size = new System.Drawing.Size(75, 27);
            this.btnBetaal.TabIndex = 2;
            this.btnBetaal.Text = "Betalen";
            this.btnBetaal.UseVisualStyleBackColor = true;
            // 
            // btnZoekPersForm
            // 
            this.btnZoekPersForm.AutoSize = true;
            this.btnZoekPersForm.Location = new System.Drawing.Point(395, 45);
            this.btnZoekPersForm.Name = "btnZoekPersForm";
            this.btnZoekPersForm.Size = new System.Drawing.Size(107, 27);
            this.btnZoekPersForm.TabIndex = 3;
            this.btnZoekPersForm.Text = "Zoek Persoon";
            this.btnZoekPersForm.UseVisualStyleBackColor = true;
            // 
            // btnCheckRFID
            // 
            this.btnCheckRFID.AutoSize = true;
            this.btnCheckRFID.Enabled = false;
            this.btnCheckRFID.Location = new System.Drawing.Point(297, 45);
            this.btnCheckRFID.Name = "btnCheckRFID";
            this.btnCheckRFID.Size = new System.Drawing.Size(92, 27);
            this.btnCheckRFID.TabIndex = 4;
            this.btnCheckRFID.Text = "Check RFID";
            this.btnCheckRFID.UseVisualStyleBackColor = true;
            this.btnCheckRFID.Click += new System.EventHandler(this.btnCheckRFID_Click);
            // 
            // btnGevAanpass
            // 
            this.btnGevAanpass.AutoSize = true;
            this.btnGevAanpass.Location = new System.Drawing.Point(344, 80);
            this.btnGevAanpass.Name = "btnGevAanpass";
            this.btnGevAanpass.Size = new System.Drawing.Size(158, 27);
            this.btnGevAanpass.TabIndex = 5;
            this.btnGevAanpass.Text = "Gegevens Aanpassen";
            this.btnGevAanpass.UseVisualStyleBackColor = true;
            // 
            // ToegangsAppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 123);
            this.Controls.Add(this.btnGevAanpass);
            this.Controls.Add(this.btnCheckRFID);
            this.Controls.Add(this.btnZoekPersForm);
            this.Controls.Add(this.btnBetaal);
            this.Controls.Add(this.lblCheckin);
            this.Controls.Add(this.lblBetaald);
            this.Name = "ToegangsAppForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBetaald;
        private System.Windows.Forms.Label lblCheckin;
        private System.Windows.Forms.Button btnBetaal;
        private System.Windows.Forms.Button btnZoekPersForm;
        private System.Windows.Forms.Button btnCheckRFID;
        private System.Windows.Forms.Button btnGevAanpass;
    }
}

