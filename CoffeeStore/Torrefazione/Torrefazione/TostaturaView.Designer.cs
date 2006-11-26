namespace Torrefazione
{
    partial class TostaturaView
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tostaturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataApprov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Orig = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.originalKgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toastedKgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Silos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tostaturaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataApprov,
            this.Orig,
            this.Tip,
            this.Data,
            this.originalKgDataGridViewTextBoxColumn,
            this.toastedKgDataGridViewTextBoxColumn,
            this.Silos});
            this.dataGridView1.DataSource = this.tostaturaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-2, -1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(743, 523);
            this.dataGridView1.TabIndex = 0;
            // 
            // tostaturaBindingSource
            // 
            this.tostaturaBindingSource.DataSource = typeof(Torrefazione.Tostatura);
            // 
            // DataApprov
            // 
            this.DataApprov.DataPropertyName = "DataApprov";
            this.DataApprov.HeaderText = "Data Approv.";
            this.DataApprov.Name = "DataApprov";
            this.DataApprov.ReadOnly = true;
            // 
            // Orig
            // 
            this.Orig.DataPropertyName = "Origine";
            this.Orig.HeaderText = "Origine";
            this.Orig.Name = "Orig";
            // 
            // Tip
            // 
            this.Tip.DataPropertyName = "Tipo";
            this.Tip.HeaderText = "Tipo";
            this.Tip.Name = "Tip";
            // 
            // Data
            // 
            this.Data.DataPropertyName = "Data";
            this.Data.HeaderText = "Data Tost.";
            this.Data.Name = "Data";
            // 
            // originalKgDataGridViewTextBoxColumn
            // 
            this.originalKgDataGridViewTextBoxColumn.DataPropertyName = "OriginalKg";
            this.originalKgDataGridViewTextBoxColumn.HeaderText = "Kg Crudo";
            this.originalKgDataGridViewTextBoxColumn.Name = "originalKgDataGridViewTextBoxColumn";
            // 
            // toastedKgDataGridViewTextBoxColumn
            // 
            this.toastedKgDataGridViewTextBoxColumn.DataPropertyName = "ToastedKg";
            this.toastedKgDataGridViewTextBoxColumn.HeaderText = "Kg Tostato";
            this.toastedKgDataGridViewTextBoxColumn.Name = "toastedKgDataGridViewTextBoxColumn";
            // 
            // Silos
            // 
            this.Silos.DataPropertyName = "Silos";
            this.Silos.HeaderText = "Silos";
            this.Silos.Name = "Silos";
            // 
            // TostaturaView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 568);
            this.Controls.Add(this.dataGridView1);
            this.Name = "TostaturaView";
            this.Text = "TostaturaView";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tostaturaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource tostaturaBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataApprov;
        private System.Windows.Forms.DataGridViewTextBoxColumn Orig;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tip;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn originalKgDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toastedKgDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Silos;


    }
}