namespace Torrefazione
{
    partial class ApprovvigionamentiForm
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
            this.components = new System.ComponentModel.Container();
            this.buttonVenditore = new System.Windows.Forms.Button();
            this.buttonOrigine = new System.Windows.Forms.Button();
            this.labelVenditore = new System.Windows.Forms.Label();
            this.labelNumFattura = new System.Windows.Forms.Label();
            this.labelDataFattura = new System.Windows.Forms.Label();
            this.labelOrgine = new System.Windows.Forms.Label();
            this.labelTipo = new System.Windows.Forms.Label();
            this.labelMarche = new System.Windows.Forms.Label();
            this.labelSacchi = new System.Windows.Forms.Label();
            this.labelKgNetti = new System.Windows.Forms.Label();
            this.labelData = new System.Windows.Forms.Label();
            this.dataPicker = new System.Windows.Forms.DateTimePicker();
            this.dataFatturaPicker = new System.Windows.Forms.DateTimePicker();
            this.comboVenditore = new System.Windows.Forms.ComboBox();
            this.comboOrigine = new System.Windows.Forms.ComboBox();
            this.comboTipo = new System.Windows.Forms.ComboBox();
            this.textNumFattura = new System.Windows.Forms.TextBox();
            this.textMarche = new System.Windows.Forms.TextBox();
            this.numericNumSacchi = new System.Windows.Forms.NumericUpDown();
            this.numericKgNetti = new System.Windows.Forms.NumericUpDown();
            this.buttonTipo = new System.Windows.Forms.Button();
            this.groupAggiungi = new System.Windows.Forms.GroupBox();
            this.buttonAggiungi = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.venditoreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataFatturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.origineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcheDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sacchiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kgNettiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.approvvigionamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.numericNumSacchi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericKgNetti)).BeginInit();
            this.groupAggiungi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.approvvigionamentoBindingSource)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonVenditore
            // 
            this.buttonVenditore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonVenditore.Location = new System.Drawing.Point(480, 34);
            this.buttonVenditore.Name = "buttonVenditore";
            this.buttonVenditore.Size = new System.Drawing.Size(114, 23);
            this.buttonVenditore.TabIndex = 0;
            this.buttonVenditore.Text = "Aggiungi Venditore";
            this.buttonVenditore.UseVisualStyleBackColor = true;
            this.buttonVenditore.Click += new System.EventHandler(this.buttonVenditore_Click);
            // 
            // buttonOrigine
            // 
            this.buttonOrigine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOrigine.Location = new System.Drawing.Point(480, 115);
            this.buttonOrigine.Name = "buttonOrigine";
            this.buttonOrigine.Size = new System.Drawing.Size(114, 23);
            this.buttonOrigine.TabIndex = 1;
            this.buttonOrigine.Text = "Aggiungi Origine";
            this.buttonOrigine.UseVisualStyleBackColor = true;
            this.buttonOrigine.Click += new System.EventHandler(this.buttonOrigine_Click);
            // 
            // labelVenditore
            // 
            this.labelVenditore.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.labelVenditore.AutoSize = true;
            this.labelVenditore.Location = new System.Drawing.Point(27, 39);
            this.labelVenditore.Name = "labelVenditore";
            this.labelVenditore.Size = new System.Drawing.Size(52, 13);
            this.labelVenditore.TabIndex = 2;
            this.labelVenditore.Text = "Venditore";
            // 
            // labelNumFattura
            // 
            this.labelNumFattura.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNumFattura.AutoSize = true;
            this.labelNumFattura.Location = new System.Drawing.Point(14, 66);
            this.labelNumFattura.Name = "labelNumFattura";
            this.labelNumFattura.Size = new System.Drawing.Size(65, 13);
            this.labelNumFattura.TabIndex = 3;
            this.labelNumFattura.Text = "Num Fattura";
            // 
            // labelDataFattura
            // 
            this.labelDataFattura.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDataFattura.AutoSize = true;
            this.labelDataFattura.Location = new System.Drawing.Point(13, 93);
            this.labelDataFattura.Name = "labelDataFattura";
            this.labelDataFattura.Size = new System.Drawing.Size(66, 13);
            this.labelDataFattura.TabIndex = 4;
            this.labelDataFattura.Text = "Data Fattura";
            // 
            // labelOrgine
            // 
            this.labelOrgine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.labelOrgine.AutoSize = true;
            this.labelOrgine.Location = new System.Drawing.Point(39, 120);
            this.labelOrgine.Name = "labelOrgine";
            this.labelOrgine.Size = new System.Drawing.Size(40, 13);
            this.labelOrgine.TabIndex = 5;
            this.labelOrgine.Text = "Origine";
            // 
            // labelTipo
            // 
            this.labelTipo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTipo.AutoSize = true;
            this.labelTipo.Location = new System.Drawing.Point(51, 145);
            this.labelTipo.Name = "labelTipo";
            this.labelTipo.Size = new System.Drawing.Size(28, 13);
            this.labelTipo.TabIndex = 6;
            this.labelTipo.Text = "Tipo";
            // 
            // labelMarche
            // 
            this.labelMarche.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMarche.AutoSize = true;
            this.labelMarche.Location = new System.Drawing.Point(36, 172);
            this.labelMarche.Name = "labelMarche";
            this.labelMarche.Size = new System.Drawing.Size(43, 13);
            this.labelMarche.TabIndex = 7;
            this.labelMarche.Text = "Marche";
            // 
            // labelSacchi
            // 
            this.labelSacchi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSacchi.AutoSize = true;
            this.labelSacchi.Location = new System.Drawing.Point(39, 197);
            this.labelSacchi.Name = "labelSacchi";
            this.labelSacchi.Size = new System.Drawing.Size(40, 13);
            this.labelSacchi.TabIndex = 8;
            this.labelSacchi.Text = "Sacchi";
            // 
            // labelKgNetti
            // 
            this.labelKgNetti.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.labelKgNetti.AutoSize = true;
            this.labelKgNetti.Location = new System.Drawing.Point(34, 223);
            this.labelKgNetti.Name = "labelKgNetti";
            this.labelKgNetti.Size = new System.Drawing.Size(45, 13);
            this.labelKgNetti.TabIndex = 9;
            this.labelKgNetti.Text = "Kg Netti";
            // 
            // labelData
            // 
            this.labelData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.labelData.AutoSize = true;
            this.labelData.Location = new System.Drawing.Point(49, 16);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(30, 13);
            this.labelData.TabIndex = 10;
            this.labelData.Text = "Data";
            // 
            // dataPicker
            // 
            this.dataPicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataPicker.Location = new System.Drawing.Point(85, 12);
            this.dataPicker.Name = "dataPicker";
            this.dataPicker.Size = new System.Drawing.Size(509, 20);
            this.dataPicker.TabIndex = 11;
            // 
            // dataFatturaPicker
            // 
            this.dataFatturaPicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataFatturaPicker.Location = new System.Drawing.Point(85, 89);
            this.dataFatturaPicker.Name = "dataFatturaPicker";
            this.dataFatturaPicker.Size = new System.Drawing.Size(509, 20);
            this.dataFatturaPicker.TabIndex = 12;
            // 
            // comboVenditore
            // 
            this.comboVenditore.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.comboVenditore.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboVenditore.FormattingEnabled = true;
            this.comboVenditore.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboVenditore.Location = new System.Drawing.Point(85, 36);
            this.comboVenditore.Name = "comboVenditore";
            this.comboVenditore.Size = new System.Drawing.Size(389, 21);
            this.comboVenditore.TabIndex = 13;
            // 
            // comboOrigine
            // 
            this.comboOrigine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.comboOrigine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboOrigine.FormattingEnabled = true;
            this.comboOrigine.Location = new System.Drawing.Point(85, 115);
            this.comboOrigine.Name = "comboOrigine";
            this.comboOrigine.Size = new System.Drawing.Size(389, 21);
            this.comboOrigine.TabIndex = 14;
            // 
            // comboTipo
            // 
            this.comboTipo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.comboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTipo.FormattingEnabled = true;
            this.comboTipo.Location = new System.Drawing.Point(85, 142);
            this.comboTipo.Name = "comboTipo";
            this.comboTipo.Size = new System.Drawing.Size(389, 21);
            this.comboTipo.TabIndex = 15;
            // 
            // textNumFattura
            // 
            this.textNumFattura.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textNumFattura.Location = new System.Drawing.Point(85, 63);
            this.textNumFattura.Name = "textNumFattura";
            this.textNumFattura.Size = new System.Drawing.Size(509, 20);
            this.textNumFattura.TabIndex = 16;
            // 
            // textMarche
            // 
            this.textMarche.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textMarche.Location = new System.Drawing.Point(85, 169);
            this.textMarche.Name = "textMarche";
            this.textMarche.Size = new System.Drawing.Size(509, 20);
            this.textMarche.TabIndex = 17;
            // 
            // numericNumSacchi
            // 
            this.numericNumSacchi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.numericNumSacchi.Location = new System.Drawing.Point(85, 195);
            this.numericNumSacchi.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericNumSacchi.Name = "numericNumSacchi";
            this.numericNumSacchi.Size = new System.Drawing.Size(509, 20);
            this.numericNumSacchi.TabIndex = 18;
            // 
            // numericKgNetti
            // 
            this.numericKgNetti.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.numericKgNetti.Location = new System.Drawing.Point(85, 221);
            this.numericKgNetti.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericKgNetti.Name = "numericKgNetti";
            this.numericKgNetti.Size = new System.Drawing.Size(509, 20);
            this.numericKgNetti.TabIndex = 19;
            // 
            // buttonTipo
            // 
            this.buttonTipo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonTipo.Location = new System.Drawing.Point(480, 142);
            this.buttonTipo.Name = "buttonTipo";
            this.buttonTipo.Size = new System.Drawing.Size(114, 23);
            this.buttonTipo.TabIndex = 20;
            this.buttonTipo.Text = "Aggiungi Tipo";
            this.buttonTipo.UseVisualStyleBackColor = true;
            this.buttonTipo.Click += new System.EventHandler(this.buttonTipo_Click);
            // 
            // groupAggiungi
            // 
            this.groupAggiungi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupAggiungi.Controls.Add(this.buttonAggiungi);
            this.groupAggiungi.Controls.Add(this.labelData);
            this.groupAggiungi.Controls.Add(this.buttonTipo);
            this.groupAggiungi.Controls.Add(this.comboTipo);
            this.groupAggiungi.Controls.Add(this.labelOrgine);
            this.groupAggiungi.Controls.Add(this.buttonVenditore);
            this.groupAggiungi.Controls.Add(this.labelDataFattura);
            this.groupAggiungi.Controls.Add(this.labelKgNetti);
            this.groupAggiungi.Controls.Add(this.comboOrigine);
            this.groupAggiungi.Controls.Add(this.numericKgNetti);
            this.groupAggiungi.Controls.Add(this.textNumFattura);
            this.groupAggiungi.Controls.Add(this.dataPicker);
            this.groupAggiungi.Controls.Add(this.labelTipo);
            this.groupAggiungi.Controls.Add(this.buttonOrigine);
            this.groupAggiungi.Controls.Add(this.labelNumFattura);
            this.groupAggiungi.Controls.Add(this.labelSacchi);
            this.groupAggiungi.Controls.Add(this.comboVenditore);
            this.groupAggiungi.Controls.Add(this.numericNumSacchi);
            this.groupAggiungi.Controls.Add(this.textMarche);
            this.groupAggiungi.Controls.Add(this.dataFatturaPicker);
            this.groupAggiungi.Controls.Add(this.labelMarche);
            this.groupAggiungi.Controls.Add(this.labelVenditore);
            this.groupAggiungi.Location = new System.Drawing.Point(12, 12);
            this.groupAggiungi.Name = "groupAggiungi";
            this.groupAggiungi.Size = new System.Drawing.Size(612, 277);
            this.groupAggiungi.TabIndex = 21;
            this.groupAggiungi.TabStop = false;
            this.groupAggiungi.Text = "Aggiungi";
            // 
            // buttonAggiungi
            // 
            this.buttonAggiungi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAggiungi.Location = new System.Drawing.Point(519, 247);
            this.buttonAggiungi.Name = "buttonAggiungi";
            this.buttonAggiungi.Size = new System.Drawing.Size(75, 23);
            this.buttonAggiungi.TabIndex = 21;
            this.buttonAggiungi.Text = "Aggiungi";
            this.buttonAggiungi.UseVisualStyleBackColor = true;
            this.buttonAggiungi.Click += new System.EventHandler(this.buttonAggiungi_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataDataGridViewTextBoxColumn,
            this.venditoreDataGridViewTextBoxColumn,
            this.dataFatturaDataGridViewTextBoxColumn,
            this.origineDataGridViewTextBoxColumn,
            this.tipoDataGridViewTextBoxColumn,
            this.marcheDataGridViewTextBoxColumn,
            this.sacchiDataGridViewTextBoxColumn,
            this.kgNettiDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.approvvigionamentoBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(12, 295);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(613, 322);
            this.dataGridView.TabIndex = 22;
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "Data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            this.dataDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // venditoreDataGridViewTextBoxColumn
            // 
            this.venditoreDataGridViewTextBoxColumn.DataPropertyName = "Venditore";
            this.venditoreDataGridViewTextBoxColumn.HeaderText = "Venditore";
            this.venditoreDataGridViewTextBoxColumn.Name = "venditoreDataGridViewTextBoxColumn";
            this.venditoreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataFatturaDataGridViewTextBoxColumn
            // 
            this.dataFatturaDataGridViewTextBoxColumn.DataPropertyName = "DataFattura";
            this.dataFatturaDataGridViewTextBoxColumn.HeaderText = "DataFattura";
            this.dataFatturaDataGridViewTextBoxColumn.Name = "dataFatturaDataGridViewTextBoxColumn";
            this.dataFatturaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // origineDataGridViewTextBoxColumn
            // 
            this.origineDataGridViewTextBoxColumn.DataPropertyName = "Origine";
            this.origineDataGridViewTextBoxColumn.HeaderText = "Origine";
            this.origineDataGridViewTextBoxColumn.Name = "origineDataGridViewTextBoxColumn";
            this.origineDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            this.tipoDataGridViewTextBoxColumn.DataPropertyName = "Tipo";
            this.tipoDataGridViewTextBoxColumn.HeaderText = "Tipo";
            this.tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            this.tipoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // marcheDataGridViewTextBoxColumn
            // 
            this.marcheDataGridViewTextBoxColumn.DataPropertyName = "Marche";
            this.marcheDataGridViewTextBoxColumn.HeaderText = "Marche";
            this.marcheDataGridViewTextBoxColumn.Name = "marcheDataGridViewTextBoxColumn";
            this.marcheDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sacchiDataGridViewTextBoxColumn
            // 
            this.sacchiDataGridViewTextBoxColumn.DataPropertyName = "Sacchi";
            this.sacchiDataGridViewTextBoxColumn.HeaderText = "Sacchi";
            this.sacchiDataGridViewTextBoxColumn.Name = "sacchiDataGridViewTextBoxColumn";
            this.sacchiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kgNettiDataGridViewTextBoxColumn
            // 
            this.kgNettiDataGridViewTextBoxColumn.DataPropertyName = "KgNetti";
            this.kgNettiDataGridViewTextBoxColumn.HeaderText = "KgNetti";
            this.kgNettiDataGridViewTextBoxColumn.Name = "kgNettiDataGridViewTextBoxColumn";
            this.kgNettiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // approvvigionamentoBindingSource
            // 
            this.approvvigionamentoBindingSource.DataSource = typeof(Torrefazione.Approvvigionamento);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 620);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(637, 22);
            this.statusStrip1.TabIndex = 23;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // ApprovvigionamentiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 642);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.groupAggiungi);
            this.Name = "ApprovvigionamentiForm";
            this.Text = "Approvvigionamenti";
            ((System.ComponentModel.ISupportInitialize)(this.numericNumSacchi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericKgNetti)).EndInit();
            this.groupAggiungi.ResumeLayout(false);
            this.groupAggiungi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.approvvigionamentoBindingSource)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonVenditore;
        private System.Windows.Forms.Button buttonOrigine;
        private System.Windows.Forms.Label labelVenditore;
        private System.Windows.Forms.Label labelNumFattura;
        private System.Windows.Forms.Label labelDataFattura;
        private System.Windows.Forms.Label labelOrgine;
        private System.Windows.Forms.Label labelTipo;
        private System.Windows.Forms.Label labelMarche;
        private System.Windows.Forms.Label labelSacchi;
        private System.Windows.Forms.Label labelKgNetti;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.DateTimePicker dataPicker;
        private System.Windows.Forms.DateTimePicker dataFatturaPicker;
        private System.Windows.Forms.ComboBox comboVenditore;
        private System.Windows.Forms.ComboBox comboOrigine;
        private System.Windows.Forms.ComboBox comboTipo;
        private System.Windows.Forms.TextBox textNumFattura;
        private System.Windows.Forms.TextBox textMarche;
        private System.Windows.Forms.NumericUpDown numericNumSacchi;
        private System.Windows.Forms.NumericUpDown numericKgNetti;
        private System.Windows.Forms.Button buttonTipo;
        private System.Windows.Forms.GroupBox groupAggiungi;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn venditoreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataFatturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn origineDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcheDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sacchiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kgNettiDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource approvvigionamentoBindingSource;
        private System.Windows.Forms.Button buttonAggiungi;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
    }
}