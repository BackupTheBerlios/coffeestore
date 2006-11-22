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
            this.apprDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bagsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.originalKgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toastedKgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tostaturaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.apprDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn,
            this.bagsDataGridViewTextBoxColumn,
            this.originalKgDataGridViewTextBoxColumn,
            this.toastedKgDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tostaturaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // tostaturaBindingSource
            // 
            this.tostaturaBindingSource.DataSource = typeof(Torrefazione.Tostatura);
            // 
            // apprDataGridViewTextBoxColumn
            // 
            this.apprDataGridViewTextBoxColumn.DataPropertyName = "Appr";
            this.apprDataGridViewTextBoxColumn.HeaderText = "Appr";
            this.apprDataGridViewTextBoxColumn.Name = "apprDataGridViewTextBoxColumn";
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "Data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            // 
            // bagsDataGridViewTextBoxColumn
            // 
            this.bagsDataGridViewTextBoxColumn.DataPropertyName = "Bags";
            this.bagsDataGridViewTextBoxColumn.HeaderText = "Bags";
            this.bagsDataGridViewTextBoxColumn.Name = "bagsDataGridViewTextBoxColumn";
            // 
            // originalKgDataGridViewTextBoxColumn
            // 
            this.originalKgDataGridViewTextBoxColumn.DataPropertyName = "OriginalKg";
            this.originalKgDataGridViewTextBoxColumn.HeaderText = "OriginalKg";
            this.originalKgDataGridViewTextBoxColumn.Name = "originalKgDataGridViewTextBoxColumn";
            // 
            // toastedKgDataGridViewTextBoxColumn
            // 
            this.toastedKgDataGridViewTextBoxColumn.DataPropertyName = "ToastedKg";
            this.toastedKgDataGridViewTextBoxColumn.HeaderText = "ToastedKg";
            this.toastedKgDataGridViewTextBoxColumn.Name = "toastedKgDataGridViewTextBoxColumn";
            // 
            // TostaturaView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.dataGridView1);
            this.Name = "TostaturaView";
            this.Text = "TostaturaView";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tostaturaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn apprDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bagsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn originalKgDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toastedKgDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tostaturaBindingSource;


    }
}