namespace Torrefazione
{
    partial class TostaturaForm
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
            this.origineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kgRimanentiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sacchiRimanentiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.venditoreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.approvvigionamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tostaturaData = new System.Windows.Forms.DateTimePicker();
            this.kgCrudo = new System.Windows.Forms.NumericUpDown();
            this.kgCotto = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.kgCrudoLabel = new System.Windows.Forms.Label();
            this.kgCottoLabel = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.labelSilos = new System.Windows.Forms.Label();
            this.silos = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.approvvigionamentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kgCrudo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kgCotto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.silos)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataDataGridViewTextBoxColumn,
            this.origineDataGridViewTextBoxColumn,
            this.tipoDataGridViewTextBoxColumn,
            this.kgRimanentiDataGridViewTextBoxColumn,
            this.sacchiRimanentiDataGridViewTextBoxColumn,
            this.venditoreDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.approvvigionamentoBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(12, 12);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(760, 170);
            this.dataGridView.TabIndex = 0;
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "Data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            this.dataDataGridViewTextBoxColumn.ReadOnly = true;
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
            // kgRimanentiDataGridViewTextBoxColumn
            // 
            this.kgRimanentiDataGridViewTextBoxColumn.DataPropertyName = "KgRimanenti";
            this.kgRimanentiDataGridViewTextBoxColumn.HeaderText = "KgRimanenti";
            this.kgRimanentiDataGridViewTextBoxColumn.Name = "kgRimanentiDataGridViewTextBoxColumn";
            this.kgRimanentiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sacchiRimanentiDataGridViewTextBoxColumn
            // 
            this.sacchiRimanentiDataGridViewTextBoxColumn.DataPropertyName = "SacchiRimanenti";
            this.sacchiRimanentiDataGridViewTextBoxColumn.HeaderText = "SacchiRimanenti";
            this.sacchiRimanentiDataGridViewTextBoxColumn.Name = "sacchiRimanentiDataGridViewTextBoxColumn";
            this.sacchiRimanentiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // venditoreDataGridViewTextBoxColumn
            // 
            this.venditoreDataGridViewTextBoxColumn.DataPropertyName = "Venditore";
            this.venditoreDataGridViewTextBoxColumn.HeaderText = "Venditore";
            this.venditoreDataGridViewTextBoxColumn.Name = "venditoreDataGridViewTextBoxColumn";
            this.venditoreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // approvvigionamentoBindingSource
            // 
            this.approvvigionamentoBindingSource.DataSource = typeof(Torrefazione.Approvvigionamento);
            // 
            // tostaturaData
            // 
            this.tostaturaData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tostaturaData.Location = new System.Drawing.Point(169, 226);
            this.tostaturaData.Name = "tostaturaData";
            this.tostaturaData.Size = new System.Drawing.Size(175, 20);
            this.tostaturaData.TabIndex = 15;
            // 
            // kgCrudo
            // 
            this.kgCrudo.Location = new System.Drawing.Point(169, 272);
            this.kgCrudo.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.kgCrudo.Name = "kgCrudo";
            this.kgCrudo.Size = new System.Drawing.Size(175, 20);
            this.kgCrudo.TabIndex = 16;
            // 
            // kgCotto
            // 
            this.kgCotto.Location = new System.Drawing.Point(169, 313);
            this.kgCotto.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.kgCotto.Name = "kgCotto";
            this.kgCotto.Size = new System.Drawing.Size(175, 20);
            this.kgCotto.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Data";
            // 
            // kgCrudoLabel
            // 
            this.kgCrudoLabel.AutoSize = true;
            this.kgCrudoLabel.Location = new System.Drawing.Point(64, 272);
            this.kgCrudoLabel.Name = "kgCrudoLabel";
            this.kgCrudoLabel.Size = new System.Drawing.Size(48, 13);
            this.kgCrudoLabel.TabIndex = 19;
            this.kgCrudoLabel.Text = "KgCrudo";
            // 
            // kgCottoLabel
            // 
            this.kgCottoLabel.AutoSize = true;
            this.kgCottoLabel.Location = new System.Drawing.Point(64, 313);
            this.kgCottoLabel.Name = "kgCottoLabel";
            this.kgCottoLabel.Size = new System.Drawing.Size(45, 13);
            this.kgCottoLabel.TabIndex = 20;
            this.kgCottoLabel.Text = "KgCotto";
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(604, 468);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 21;
            this.buttonOK.Text = "Aggiungi";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // labelSilos
            // 
            this.labelSilos.AutoSize = true;
            this.labelSilos.Location = new System.Drawing.Point(67, 358);
            this.labelSilos.Name = "labelSilos";
            this.labelSilos.Size = new System.Drawing.Size(29, 13);
            this.labelSilos.TabIndex = 22;
            this.labelSilos.Text = "Silos";
            // 
            // silos
            // 
            this.silos.Location = new System.Drawing.Point(169, 351);
            this.silos.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.silos.Name = "silos";
            this.silos.Size = new System.Drawing.Size(175, 20);
            this.silos.TabIndex = 23;
            // 
            // TostaturaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 607);
            this.Controls.Add(this.silos);
            this.Controls.Add(this.labelSilos);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.kgCottoLabel);
            this.Controls.Add(this.kgCrudoLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kgCotto);
            this.Controls.Add(this.kgCrudo);
            this.Controls.Add(this.tostaturaData);
            this.Controls.Add(this.dataGridView);
            this.Name = "TostaturaForm";
            this.Text = "TostaturaFormReviewed";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.approvvigionamentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kgCrudo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kgCotto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.silos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.BindingSource approvvigionamentoBindingSource;
        private System.Windows.Forms.DateTimePicker tostaturaData;
        private System.Windows.Forms.NumericUpDown kgCrudo;
        private System.Windows.Forms.NumericUpDown kgCotto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label kgCrudoLabel;
        private System.Windows.Forms.Label kgCottoLabel;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn origineDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kgRimanentiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sacchiRimanentiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn venditoreDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label labelSilos;
        private System.Windows.Forms.NumericUpDown silos;

    }
}