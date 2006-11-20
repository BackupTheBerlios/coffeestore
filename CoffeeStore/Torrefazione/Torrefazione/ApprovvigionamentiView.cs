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
        ToolStripMenuItem _eliminaToolStripMenuItem;
        ToolStripMenuItem _effettuaScaricoToolStripMenuItem;
        ToolStripMenuItem _visualizzaScarichiToolStripMenuItem;

        bool _toolStripMenuActive;
        int _rowClicked;

        public ApprovvigionamentiView()
        {
            InitializeComponent();           
            InitToolStripMenu();
            _dataBinder = new ApprovvigionamentoDataBinder(dataGridView);
            RefreshDataGrid();
        }

        private void InitToolStripMenu()
        {
            _toolStripMenuActive = false;
            _eliminaToolStripMenuItem = new ToolStripMenuItem();
            _eliminaToolStripMenuItem.Text = "Elimina";
            _eliminaToolStripMenuItem.Click += new EventHandler(eliminaClicked);

            _effettuaScaricoToolStripMenuItem = new ToolStripMenuItem();
            _effettuaScaricoToolStripMenuItem.Text = "Effettua Scarico";
            _effettuaScaricoToolStripMenuItem.Click += new EventHandler(scaricaClicked);

            _visualizzaScarichiToolStripMenuItem = new ToolStripMenuItem();
            _visualizzaScarichiToolStripMenuItem.Text = "Visualizza Scarichi";
            _visualizzaScarichiToolStripMenuItem.Click += new EventHandler(visualizzaScarichiClicked);

            _rowClicked = -1;
        }

        private void RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            _rowClicked = e.RowIndex;

            if (e.Button == MouseButtons.Left && !_toolStripMenuActive)
            {
                _toolStripMenuActive = true;
                contextMenuStrip.Items.AddRange(new ToolStripItem[] { _eliminaToolStripMenuItem, _effettuaScaricoToolStripMenuItem, _visualizzaScarichiToolStripMenuItem });
            }
        }

        private void ClearContext(object sender, DataGridViewCellStateChangedEventArgs e)
        {
            contextMenuStrip.Items.Clear();
            _toolStripMenuActive = false;
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
            Approvvigionamento appr = GetSelectedApprovvigionamento();
            if (Db.Del(appr))
            {
                MessageBox.Show("Approvvigionamento eliminato");
                RefreshDataGrid();
            }
            else
                MessageBox.Show("Impossibile eliminare l'approvvigionamento selezionato");
        }

        private Approvvigionamento GetSelectedApprovvigionamento()
        {
            Approvvigionamento appr = new Approvvigionamento();
            IEnumerator enumerator = dataGridView.Rows[_rowClicked].Cells.GetEnumerator();
            while (enumerator.MoveNext())
            {
                DataGridViewTextBoxCell cell = (DataGridViewTextBoxCell)enumerator.Current;
                FillField(appr, cell.Value, cell.OwningColumn.DataPropertyName);
            }
            return appr;
        }

        private void scaricaClicked(object sender, EventArgs e)
        {
            Approvvigionamento appr = GetSelectedApprovvigionamento();
            new TostaturaForm().ShowDialog();
        }

        private void visualizzaScarichiClicked(object sender, EventArgs e)
        {
            Approvvigionamento appr = GetSelectedApprovvigionamento();
        }

        private void RefreshDataGrid()
        {
            _dataBinder.Refresh();
            toolStripStatusLabel1.Text = "Numero approvvigiomaneti: " + _dataBinder.Count;
        }
    }
}