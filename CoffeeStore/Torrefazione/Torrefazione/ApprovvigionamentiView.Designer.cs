namespace Torrefazione
{
    partial class ApprovvigionamentiView
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.venditoreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numFatturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataFatturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.origineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcheDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sacchiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kgNettiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SacchiRimanenti = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KgRimanenti = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.approvvigionamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.approvvigionamentoBindingSource)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
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
            this.numFatturaDataGridViewTextBoxColumn,
            this.dataFatturaDataGridViewTextBoxColumn,
            this.origineDataGridViewTextBoxColumn,
            this.tipoDataGridViewTextBoxColumn,
            this.marcheDataGridViewTextBoxColumn,
            this.sacchiDataGridViewTextBoxColumn,
            this.kgNettiDataGridViewTextBoxColumn,
            this.SacchiRimanenti,
            this.KgRimanenti});
            this.dataGridView.ContextMenuStrip = this.contextMenuStrip;
            this.dataGridView.DataSource = this.approvvigionamentoBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(12, 81);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(672, 518);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.RowHeaderMouseClick);
            this.dataGridView.CellStateChanged += new System.Windows.Forms.DataGridViewCellStateChangedEventHandler(this.ClearContext);
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
            // numFatturaDataGridViewTextBoxColumn
            // 
            this.numFatturaDataGridViewTextBoxColumn.DataPropertyName = "NumFattura";
            this.numFatturaDataGridViewTextBoxColumn.HeaderText = "NumFattura";
            this.numFatturaDataGridViewTextBoxColumn.Name = "numFatturaDataGridViewTextBoxColumn";
            this.numFatturaDataGridViewTextBoxColumn.ReadOnly = true;
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
            // SacchiRimanenti
            // 
            this.SacchiRimanenti.DataPropertyName = "SacchiRimanenti";
            this.SacchiRimanenti.HeaderText = "SacchiRimanenti";
            this.SacchiRimanenti.Name = "SacchiRimanenti";
            this.SacchiRimanenti.ReadOnly = true;
            // 
            // KgRimanenti
            // 
            this.KgRimanenti.DataPropertyName = "KgRimanenti";
            this.KgRimanenti.HeaderText = "KgRimanenti";
            this.KgRimanenti.Name = "KgRimanenti";
            this.KgRimanenti.ReadOnly = true;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Name = "contextMenuStrip1";
            this.contextMenuStrip.Size = new System.Drawing.Size(61, 4);
            // 
            // approvvigionamentoBindingSource
            // 
            this.approvvigionamentoBindingSource.DataSource = typeof(Torrefazione.Approvvigionamento);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip.Location = new System.Drawing.Point(0, 602);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(696, 22);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(12, 12);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(95, 17);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Visualizza tutto";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(12, 58);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(172, 17);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Visualizza se non ha rimanenze";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(12, 35);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(151, 17);
            this.radioButton3.TabIndex = 4;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Visualizza se ha rimanenze";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // ApprovvigionamentiView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 624);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.dataGridView);
            this.Name = "ApprovvigionamentiView";
            this.Text = "ApprovvigionamentiView";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.approvvigionamentoBindingSource)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.BindingSource approvvigionamentoBindingSource;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn venditoreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numFatturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataFatturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn origineDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcheDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sacchiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kgNettiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SacchiRimanenti;
        private System.Windows.Forms.DataGridViewTextBoxColumn KgRimanenti;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
    }
}