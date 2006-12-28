namespace Torrefazione
{
    partial class ConfezioniView
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
            this.confezioneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Lotto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siloProvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pesoNettoTotDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pesoConfezioneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numConfezioniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Self = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.confezioneBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Lotto,
            this.siloProvDataGridViewTextBoxColumn,
            this.pesoNettoTotDataGridViewTextBoxColumn,
            this.pesoConfezioneDataGridViewTextBoxColumn,
            this.numConfezioniDataGridViewTextBoxColumn,
            this.Self});
            this.dataGridView.DataSource = this.confezioneBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(12, 12);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(605, 449);
            this.dataGridView.TabIndex = 0;
            // 
            // confezioneBindingSource
            // 
            this.confezioneBindingSource.DataSource = typeof(Torrefazione.Confezione);
            // 
            // Lotto
            // 
            this.Lotto.DataPropertyName = "Lotto";
            this.Lotto.HeaderText = "Lotto";
            this.Lotto.Name = "Lotto";
            this.Lotto.ReadOnly = true;
            // 
            // siloProvDataGridViewTextBoxColumn
            // 
            this.siloProvDataGridViewTextBoxColumn.DataPropertyName = "SiloProv";
            this.siloProvDataGridViewTextBoxColumn.HeaderText = "SiloProv";
            this.siloProvDataGridViewTextBoxColumn.Name = "siloProvDataGridViewTextBoxColumn";
            this.siloProvDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pesoNettoTotDataGridViewTextBoxColumn
            // 
            this.pesoNettoTotDataGridViewTextBoxColumn.DataPropertyName = "PesoNettoTot";
            this.pesoNettoTotDataGridViewTextBoxColumn.HeaderText = "PesoNettoTot";
            this.pesoNettoTotDataGridViewTextBoxColumn.Name = "pesoNettoTotDataGridViewTextBoxColumn";
            this.pesoNettoTotDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pesoConfezioneDataGridViewTextBoxColumn
            // 
            this.pesoConfezioneDataGridViewTextBoxColumn.DataPropertyName = "PesoConfezione";
            this.pesoConfezioneDataGridViewTextBoxColumn.HeaderText = "PesoConfezione";
            this.pesoConfezioneDataGridViewTextBoxColumn.Name = "pesoConfezioneDataGridViewTextBoxColumn";
            this.pesoConfezioneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numConfezioniDataGridViewTextBoxColumn
            // 
            this.numConfezioniDataGridViewTextBoxColumn.DataPropertyName = "NumConfezioni";
            this.numConfezioniDataGridViewTextBoxColumn.HeaderText = "NumConfezioni";
            this.numConfezioniDataGridViewTextBoxColumn.Name = "numConfezioniDataGridViewTextBoxColumn";
            this.numConfezioniDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Self
            // 
            this.Self.DataPropertyName = "Self";
            this.Self.HeaderText = "Self";
            this.Self.Name = "Self";
            this.Self.ReadOnly = true;
            // 
            // ConfezioniView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 473);
            this.Controls.Add(this.dataGridView);
            this.Name = "ConfezioniView";
            this.Text = "ConfezioniView";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.confezioneBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.BindingSource confezioneBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lotto;
        private System.Windows.Forms.DataGridViewTextBoxColumn siloProvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pesoNettoTotDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pesoConfezioneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numConfezioniDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Self;

    }
}