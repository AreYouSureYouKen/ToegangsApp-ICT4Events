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
            this.lblCheckin = new System.Windows.Forms.Label();
            this.btnZoekPersForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCheckin
            // 
            this.lblCheckin.AutoSize = true;
            this.lblCheckin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckin.Location = new System.Drawing.Point(12, 9);
            this.lblCheckin.Name = "lblCheckin";
            this.lblCheckin.Size = new System.Drawing.Size(38, 31);
            this.lblCheckin.TabIndex = 1;
            this.lblCheckin.Text = "...";
            // 
            // btnZoekPersForm
            // 
            this.btnZoekPersForm.AutoSize = true;
            this.btnZoekPersForm.Location = new System.Drawing.Point(194, 9);
            this.btnZoekPersForm.Name = "btnZoekPersForm";
            this.btnZoekPersForm.Size = new System.Drawing.Size(107, 27);
            this.btnZoekPersForm.TabIndex = 3;
            this.btnZoekPersForm.Text = "Zoek Persoon";
            this.btnZoekPersForm.UseVisualStyleBackColor = true;
            this.btnZoekPersForm.Click += new System.EventHandler(this.btnZoekPersForm_Click);
            // 
            // ToegangsAppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 53);
            this.Controls.Add(this.btnZoekPersForm);
            this.Controls.Add(this.lblCheckin);
            this.Name = "ToegangsAppForm";
            this.Text = "Toegang";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClosingForm);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCheckin;
        private System.Windows.Forms.Button btnZoekPersForm;
    }
}

