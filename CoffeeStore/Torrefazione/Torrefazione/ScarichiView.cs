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
    public partial class ScarichiView : Form
    {
        Approvvigionamento _appr;
        ToolStripDataGridMenu _toolStripMenu;

        public ScarichiView(Approvvigionamento appr)
        {
            InitializeComponent();
            InitToolStripMenu();

            _appr = appr;

            dataGridView.DataSource = CreateScarichiCopy( _appr.Scarichi);
            dataGridView.Refresh();
        }

        IList<Scarico> CreateScarichiCopy(IList<Scarico> scarichi)
        {
            IList<Scarico> copy = new List<Scarico>();
            foreach (Scarico s in scarichi)
                copy.Add(s);
            return copy;
        }

        private void InitToolStripMenu()
        {
            _toolStripMenu = new ToolStripDataGridMenu(contextMenuStrip, dataGridView);

            ToolStripMenuItem elimina = new ToolStripMenuItem();
            elimina.Text = "Elimina";
            elimina.Click += new EventHandler(eliminaClicked);

            ToolStripMenuItem[] items = new ToolStripMenuItem[] { elimina };
            _toolStripMenu.SetItems(items);
        }

        private void ClearContext(object sender, DataGridViewCellStateChangedEventArgs e)
        {
            _toolStripMenu.Clear();
        }

        private void RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            _toolStripMenu.OnRowHeaderMouseClick(e);
        }

        private void eliminaClicked(object sender, EventArgs e)
        {
            Scarico scarico = GetSelectedScarico();
            Form f = new ConfirmDialog("Vuoi veramente eliminare lo scarico selezionato.\nAnche la tostatura relativa sara' eliminata.\nE quindi l'elemento nel silos, ecc. ecc.\nAnche se credo che forse e' meglio fare eliminare una tostatura,piuttosto che lo scarico.\nE'la tostatatura che poi si occupata di eliminare lo scarico.\nLo scarico per ora non conosce la tostatura.\n");
            if (f.ShowDialog() == DialogResult.OK)
            {
                if (_appr.Scarichi.Remove(scarico))
                {
                    _appr.KgRimanenti += scarico.KgNetti;
                    _appr.SacchiRimanenti++;
                    Db.Set(_appr.Scarichi);
                    Db.Set(_appr);

                    MessageBox.Show("Scarico eliminato");

                    dataGridView.DataSource = CreateScarichiCopy(_appr.Scarichi);
                    dataGridView.Refresh();
                }
                else
                    MessageBox.Show("Qualche errore nel rimuovere lo scarico");
            }
        }

        private void FillField(Scarico scarico, object value, string property)
        {
            PropertyInfo propertyInfo = scarico.GetType().GetProperty(property);
            propertyInfo.SetValue(scarico, value, null);
        }

        private Scarico GetSelectedScarico()
        {
            Scarico scarico = new Scarico();
            IEnumerator enumerator = _toolStripMenu.GetSelectedRowEnumerator();
            while (enumerator.MoveNext())
            {
                DataGridViewTextBoxCell cell = (DataGridViewTextBoxCell)enumerator.Current;
                FillField(scarico, cell.Value, cell.OwningColumn.DataPropertyName);
            }
            return scarico;
        }
    }
}