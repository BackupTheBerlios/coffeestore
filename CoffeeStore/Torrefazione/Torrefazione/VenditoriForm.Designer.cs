namespace Torrefazione
{
    partial class VenditoriForm
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
            this.buttonAggiungi = new System.Windows.Forms.Button();
            this.textBoxVenditore = new System.Windows.Forms.TextBox();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAggiungi
            // 
            this.buttonAggiungi.Location = new System.Drawing.Point(157, 45);
            this.buttonAggiungi.Name = "buttonAggiungi";
            this.buttonAggiungi.Size = new System.Drawing.Size(75, 23);
            this.buttonAggiungi.TabIndex = 0;
            this.buttonAggiungi.Text = "Aggiungi";
            this.buttonAggiungi.UseVisualStyleBackColor = true;
            this.buttonAggiungi.Click += new System.EventHandler(this.buttonAggiungi_Click);
            // 
            // textBoxVenditore
            // 
            this.textBoxVenditore.Location = new System.Drawing.Point(13, 19);
            this.textBoxVenditore.Name = "textBoxVenditore";
            this.textBoxVenditore.Size = new System.Drawing.Size(219, 20);
            this.textBoxVenditore.TabIndex = 1;
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.textBoxVenditore);
            this.groupBox.Controls.Add(this.buttonAggiungi);
            this.groupBox.Location = new System.Drawing.Point(9, 12);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(245, 81);
            this.groupBox.TabIndex = 2;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Aggiungi Venditore";
            // 
            // VenditoriForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 109);
            this.Controls.Add(this.groupBox);
            this.MaximumSize = new System.Drawing.Size(274, 136);
            this.MinimumSize = new System.Drawing.Size(274, 136);
            this.Name = "VenditoriForm";
            this.Text = "Venditori";
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAggiungi;
        private System.Windows.Forms.TextBox textBoxVenditore;
        private System.Windows.Forms.GroupBox groupBox;
    }
}