namespace Torrefazione
{
    partial class ScarichiView
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
            this.scaricoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.kgNettiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sacchiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scaricoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.scaricoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scaricoBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // scaricoBindingSource
            // 
            this.scaricoBindingSource.DataSource = typeof(Torrefazione.Scarico);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kgNettiDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn,
            this.sacchiDataGridViewTextBoxColumn});
            this.dataGridView.ContextMenuStrip = this.contextMenuStrip;
            this.dataGridView.DataSource = this.scaricoBindingSource1;
            this.dataGridView.Location = new System.Drawing.Point(12, 12);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(344, 531);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.RowHeaderMouseClick);
            this.dataGridView.CellStateChanged += new System.Windows.Forms.DataGridViewCellStateChangedEventHandler(this.ClearContext);
            // 
            // kgNettiDataGridViewTextBoxColumn
            // 
            this.kgNettiDataGridViewTextBoxColumn.DataPropertyName = "KgNetti";
            this.kgNettiDataGridViewTextBoxColumn.HeaderText = "KgNetti";
            this.kgNettiDataGridViewTextBoxColumn.Name = "kgNettiDataGridViewTextBoxColumn";
            this.kgNettiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "Data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            this.dataDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sacchiDataGridViewTextBoxColumn
            // 
            this.sacchiDataGridViewTextBoxColumn.DataPropertyName = "Sacchi";
            this.sacchiDataGridViewTextBoxColumn.HeaderText = "Sacchi";
            this.sacchiDataGridViewTextBoxColumn.Name = "sacchiDataGridViewTextBoxColumn";
            this.sacchiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // scaricoBindingSource1
            // 
            this.scaricoBindingSource1.DataSource = typeof(Torrefazione.Scarico);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(61, 4);
            // 
            // ScarichiView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 602);
            this.Controls.Add(this.dataGridView);
            this.Name = "ScarichiView";
            this.Text = "ScarichiView";
            ((System.ComponentModel.ISupportInitialize)(this.scaricoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scaricoBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource scaricoBindingSource;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn kgNettiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sacchiDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource scaricoBindingSource1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;

    }
}