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
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.tostaturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Approvvigionamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataApprovvigionametoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.origineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kgCottoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kgCrudoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.silosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tostaturaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(61, 4);
            // 
            // dataGridView
            // 
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataDataGridViewTextBoxColumn,
            this.Approvvigionamento,
            this.dataApprovvigionametoDataGridViewTextBoxColumn,
            this.origineDataGridViewTextBoxColumn,
            this.kgCottoDataGridViewTextBoxColumn,
            this.tipoDataGridViewTextBoxColumn,
            this.kgCrudoDataGridViewTextBoxColumn,
            this.silosDataGridViewTextBoxColumn});
            this.dataGridView.ContextMenuStrip = this.contextMenuStrip;
            this.dataGridView.DataSource = this.tostaturaBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(12, 12);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(716, 544);
            this.dataGridView.TabIndex = 2;
            this.dataGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.RowHeaderMouseClick);
            this.dataGridView.CellStateChanged += new System.Windows.Forms.DataGridViewCellStateChangedEventHandler(this.ClearContext);
            // 
            // tostaturaBindingSource
            // 
            this.tostaturaBindingSource.DataSource = typeof(Torrefazione.Tostatura);
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "Data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            // 
            // Approvvigionamento
            // 
            this.Approvvigionamento.DataPropertyName = "Approvvigionamento";
            this.Approvvigionamento.HeaderText = "Approvvigionamento";
            this.Approvvigionamento.Name = "Approvvigionamento";
            this.Approvvigionamento.Visible = false;
            // 
            // dataApprovvigionametoDataGridViewTextBoxColumn
            // 
            this.dataApprovvigionametoDataGridViewTextBoxColumn.DataPropertyName = "DataApprovvigionameto";
            this.dataApprovvigionametoDataGridViewTextBoxColumn.HeaderText = "DataApprovvigionameto";
            this.dataApprovvigionametoDataGridViewTextBoxColumn.Name = "dataApprovvigionametoDataGridViewTextBoxColumn";
            this.dataApprovvigionametoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // origineDataGridViewTextBoxColumn
            // 
            this.origineDataGridViewTextBoxColumn.DataPropertyName = "Origine";
            this.origineDataGridViewTextBoxColumn.HeaderText = "Origine";
            this.origineDataGridViewTextBoxColumn.Name = "origineDataGridViewTextBoxColumn";
            this.origineDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kgCottoDataGridViewTextBoxColumn
            // 
            this.kgCottoDataGridViewTextBoxColumn.DataPropertyName = "KgCotto";
            this.kgCottoDataGridViewTextBoxColumn.HeaderText = "KgCotto";
            this.kgCottoDataGridViewTextBoxColumn.Name = "kgCottoDataGridViewTextBoxColumn";
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            this.tipoDataGridViewTextBoxColumn.DataPropertyName = "Tipo";
            this.tipoDataGridViewTextBoxColumn.HeaderText = "Tipo";
            this.tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            this.tipoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kgCrudoDataGridViewTextBoxColumn
            // 
            this.kgCrudoDataGridViewTextBoxColumn.DataPropertyName = "KgCrudo";
            this.kgCrudoDataGridViewTextBoxColumn.HeaderText = "KgCrudo";
            this.kgCrudoDataGridViewTextBoxColumn.Name = "kgCrudoDataGridViewTextBoxColumn";
            // 
            // silosDataGridViewTextBoxColumn
            // 
            this.silosDataGridViewTextBoxColumn.DataPropertyName = "Silos";
            this.silosDataGridViewTextBoxColumn.HeaderText = "Silos";
            this.silosDataGridViewTextBoxColumn.Name = "silosDataGridViewTextBoxColumn";
            // 
            // TostaturaView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 568);
            this.Controls.Add(this.dataGridView);
            this.Name = "TostaturaView";
            this.Text = "TostaturaView";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tostaturaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource tostaturaBindingSource;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Approvvigionamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataApprovvigionametoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn origineDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kgCottoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kgCrudoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn silosDataGridViewTextBoxColumn;


    }
}