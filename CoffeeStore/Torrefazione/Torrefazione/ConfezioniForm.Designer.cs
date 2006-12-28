namespace Torrefazione
{
    partial class ConfezioniForm
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
            this.buttonOK = new System.Windows.Forms.Button();
            this.siloProv = new System.Windows.Forms.NumericUpDown();
            this.numConfezioni = new System.Windows.Forms.NumericUpDown();
            this.pesoTotale = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tipoConfezione = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lotto = new System.Windows.Forms.TextBox();
            this.infoButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.siloProv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numConfezioni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pesoTotale)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(201, 172);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 1;
            this.buttonOK.Text = "Aggiugi";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // siloProv
            // 
            this.siloProv.Location = new System.Drawing.Point(125, 33);
            this.siloProv.Maximum = new decimal(new int[] {
            13,
            0,
            0,
            0});
            this.siloProv.Minimum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.siloProv.Name = "siloProv";
            this.siloProv.Size = new System.Drawing.Size(68, 20);
            this.siloProv.TabIndex = 2;
            this.siloProv.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
            // 
            // numConfezioni
            // 
            this.numConfezioni.Location = new System.Drawing.Point(125, 109);
            this.numConfezioni.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numConfezioni.Name = "numConfezioni";
            this.numConfezioni.Size = new System.Drawing.Size(68, 20);
            this.numConfezioni.TabIndex = 3;
            // 
            // pesoTotale
            // 
            this.pesoTotale.Location = new System.Drawing.Point(125, 59);
            this.pesoTotale.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.pesoTotale.Name = "pesoTotale";
            this.pesoTotale.Size = new System.Drawing.Size(68, 20);
            this.pesoTotale.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Silo Provenienza";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Peso Netto Totale";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Numero Confezioni";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tipo Confezione";
            // 
            // tipoConfezione
            // 
            this.tipoConfezione.Location = new System.Drawing.Point(125, 85);
            this.tipoConfezione.Name = "tipoConfezione";
            this.tipoConfezione.Size = new System.Drawing.Size(151, 20);
            this.tipoConfezione.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(88, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Lotto";
            // 
            // lotto
            // 
            this.lotto.Location = new System.Drawing.Point(125, 135);
            this.lotto.Name = "lotto";
            this.lotto.Size = new System.Drawing.Size(151, 20);
            this.lotto.TabIndex = 11;
            // 
            // infoButton
            // 
            this.infoButton.Location = new System.Drawing.Point(201, 33);
            this.infoButton.Name = "infoButton";
            this.infoButton.Size = new System.Drawing.Size(75, 20);
            this.infoButton.TabIndex = 12;
            this.infoButton.Text = "info";
            this.infoButton.UseVisualStyleBackColor = true;
            this.infoButton.Click += new System.EventHandler(this.infoButton_Click);
            // 
            // ConfezioniForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 207);
            this.Controls.Add(this.infoButton);
            this.Controls.Add(this.lotto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tipoConfezione);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pesoTotale);
            this.Controls.Add(this.numConfezioni);
            this.Controls.Add(this.siloProv);
            this.Controls.Add(this.buttonOK);
            this.Name = "ConfezioniForm";
            this.Text = "ConfezioniForm";
            ((System.ComponentModel.ISupportInitialize)(this.siloProv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numConfezioni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pesoTotale)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.NumericUpDown siloProv;
        private System.Windows.Forms.NumericUpDown numConfezioni;
        private System.Windows.Forms.NumericUpDown pesoTotale;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tipoConfezione;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox lotto;
        private System.Windows.Forms.Button infoButton;
    }
}