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
            this.btnZoekPers.Location = new System.Drawing.Point(152, 9);
            this.btnZoekPers.Name = "btnZoekPers";
            this.btnZoekPers.Size = new System.Drawing.Size(107, 27);
            this.btnZoekPers.TabIndex = 2;
            this.btnZoekPers.Text = "Zoek Persoon";
            this.btnZoekPers.UseVisualStyleBackColor = true;
            // 
            // btnLinkRFID
            // 
            this.btnLinkRFID.AutoSize = true;
            this.btnLinkRFID.Location = new System.Drawing.Point(152, 42);
            this.btnLinkRFID.Name = "btnLinkRFID";
            this.btnLinkRFID.Size = new System.Drawing.Size(75, 27);
            this.btnLinkRFID.TabIndex = 3;
            this.btnLinkRFID.Text = "LinkRFID";
            this.btnLinkRFID.UseVisualStyleBackColor = true;
            // 
            // ZoekPersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 78);
            this.Controls.Add(this.btnLinkRFID);
            this.Controls.Add(this.btnZoekPers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbDocNr);
            this.Name = "ZoekPersForm";
            this.Text = "ZoekPersForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbDocNr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnZoekPers;
        private System.Windows.Forms.Button btnLinkRFID;
    }
}