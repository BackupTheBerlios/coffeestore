namespace Torrefazione
{
    partial class MiscelaturaView
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
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.miscelaturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Silos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotKilos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Self = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.miscelaturaBindingSource)).BeginInit();
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
            this.Data,
            this.Silos,
            this.TotKilos,
            this.Nome,
            this.Self});
            this.dataGridView.ContextMenuStrip = this.contextMenuStrip;
            this.dataGridView.DataSource = this.miscelaturaBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(12, 12);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(677, 473);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.RowHeaderMouseClick);
            this.dataGridView.CellStateChanged += new System.Windows.Forms.DataGridViewCellStateChangedEventHandler(this.ClearContext);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(61, 4);
            // 
            // miscelaturaBindingSource
            // 
            this.miscelaturaBindingSource.DataSource = typeof(Torrefazione.Miscelatura);
            // 
            // Data
            // 
            this.Data.DataPropertyName = "Data";
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            // 
            // Silos
            // 
            this.Silos.DataPropertyName = "Silos";
            this.Silos.HeaderText = "Silos";
            this.Silos.Name = "Silos";
            this.Silos.ReadOnly = true;
            // 
            // TotKilos
            // 
            this.TotKilos.DataPropertyName = "TotKilos";
            this.TotKilos.HeaderText = "TotKilos";
            this.TotKilos.Name = "TotKilos";
            this.TotKilos.ReadOnly = true;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // Self
            // 
            this.Self.DataPropertyName = "Self";
            this.Self.HeaderText = "Self";
            this.Self.Name = "Self";
            this.Self.ReadOnly = true;
            // 
            // MiscelaturaView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 497);
            this.Controls.Add(this.dataGridView);
            this.Name = "MiscelaturaView";
            this.Text = "MiscelaturaView";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.miscelaturaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.BindingSource miscelaturaBindingSource;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Silos;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotKilos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Self;
    }
}