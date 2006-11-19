using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Reflection;

namespace Torrefazione
{
    public partial class ApprovvigionamentiView : Form
    {
        ApprovvigionamentoDataBinder _dataBinder;

        ToolStripMenuItem _eliminaRowToolStripMenuItem;
        bool _eliminaRowToolStripMenuItemPopulated;
        int _eliminaClickedRow;

        public ApprovvigionamentiView()
        {
            InitializeComponent();           
            InitToolStripMenu();
            _dataBinder = new ApprovvigionamentoDataBinder(dataGridView);
            RefreshDataGrid();
        }

        private void InitToolStripMenu()
        {
            _eliminaRowToolStripMenuItemPopulated = false;
            _eliminaRowToolStripMenuItem = new ToolStripMenuItem();
            _eliminaRowToolStripMenuItem.Text = "Elimina";
            _eliminaRowToolStripMenuItem.Click += new EventHandler(eliminaClicked);
            _eliminaClickedRow = -1;
        }       

        private void RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            _eliminaClickedRow = e.RowIndex;

            if (e.Button == MouseButtons.Left && !_eliminaRowToolStripMenuItemPopulated)
            {
                _eliminaRowToolStripMenuItemPopulated = true;
                contextMenuStrip.Items.AddRange(new ToolStripItem[] { _eliminaRowToolStripMenuItem });
            }
        }

        private void ClearContext(object sender, DataGridViewCellStateChangedEventArgs e)
        {
            contextMenuStrip.Items.Clear();
            _eliminaRowToolStripMenuItemPopulated = false;
        }

        private void FillField(Approvvigionamento appr, object value, string property)
        {
            PropertyInfo propertyInfo = appr.GetType().GetProperty(property);
            Type type = value.GetType();

            if (type.Equals(typeof(DateTime)))
                propertyInfo.SetValue(appr, value, null);
            else if (type.Equals(typeof(string)))
                propertyInfo.SetValue(appr, value, null);
            else if (type.Equals(typeof(int)))
                propertyInfo.SetValue(appr, value, null);
            else if (type.Equals(typeof(Venditore)))
                propertyInfo.SetValue(appr, value, null);
            else if (type.Equals(typeof(Tipo)))
                propertyInfo.SetValue(appr, value, null);
            else if (type.Equals(typeof(Origine)))
                propertyInfo.SetValue(appr, value, null);
        }

        private void eliminaClicked(object sender, EventArgs e)
        {
            Approvvigionamento appr = new Approvvigionamento();
            IEnumerator enumerator = dataGridView.Rows[_eliminaClickedRow].Cells.GetEnumerator();
            while (enumerator.MoveNext())
            {
                DataGridViewTextBoxCell cell = (DataGridViewTextBoxCell) enumerator.Current;
                FillField(appr, cell.Value, cell.OwningColumn.DataPropertyName);
            }

            if (Db.Del(appr))
            {
                MessageBox.Show("Approvvigionamento eliminato");
                RefreshDataGrid();
            }
            else
                MessageBox.Show("Impossibile eliminare l'approvvigionamento selezionato");
        }

        private void RefreshDataGrid()
        {
            _dataBinder.Refresh();
            toolStripStatusLabel1.Text = "Numero approvvigiomaneti: " + _dataBinder.Count;
        }
    }
}