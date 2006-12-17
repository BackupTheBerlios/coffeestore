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
    public partial class TostaturaView : Form
    {
        private ToolStripDataGridMenu _toolStripMenu;

        public TostaturaView()
        {
            InitializeComponent();
            RefreshDataGrid();
            InitToolStripMenu();
        }

        public void RefreshDataGrid()
        {
            List<Tostatura> list = new List<Tostatura>();

            foreach (Tostatura t in Db.GetAll<Tostatura>())
                list.Add(t);

            list.Sort(delegate(Tostatura x, Tostatura y)
                {
                    return -1 * x.Data.CompareTo(y.Data);
                }
            );

            dataGridView.DataSource = list;
            dataGridView.Refresh();
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
            Tostatura tostatura = (Tostatura) Db.GetUnique(GetSelectedTostatura());
            if (tostatura != null)
            {
                Form f = new ConfirmDialog("Vuoi veramente eliminare la tostatura selezionata.");
                if (f.ShowDialog() == DialogResult.OK)
                {
                    Scarico scarico = new Scarico(tostatura.Data, 1, tostatura.KgCrudo);
                    Approvvigionamento appr = tostatura.Approvvigionamento;
                    if (SilosContainer.DelByTostatura(tostatura.Silos, tostatura))
                    {
                        Db.Del(tostatura);

                        if (appr.Scarichi.Remove(scarico))
                        {
                            appr.KgRimanenti += scarico.KgNetti;
                            appr.SacchiRimanenti++;

                            Db.Set(appr.Scarichi);
                            Db.Set(appr);
                        }

                        MessageBox.Show("Tostatura eliminata");
                        RefreshDataGrid();
                    }
                    else
                        MessageBox.Show("Qualche errore nel rimuovere i riferimenti della tostatura nel silos");
                }
            }
            else
                MessageBox.Show("Qualche errore nel rimuovere la tostatura");
        }

        private void FillField(Tostatura tostatura, object value, string property)
        {
            PropertyInfo propertyInfo = tostatura.GetType().GetProperty(property);
            if (propertyInfo.CanWrite)
                propertyInfo.SetValue(tostatura, value, null);
        }

        private Tostatura GetSelectedTostatura()
        {
            Tostatura tostatura = new Tostatura();
            IEnumerator enumerator = _toolStripMenu.GetSelectedRowEnumerator();
            while (enumerator.MoveNext())
            {
                DataGridViewTextBoxCell cell = (DataGridViewTextBoxCell)enumerator.Current;
                FillField(tostatura, cell.Value, cell.OwningColumn.DataPropertyName);
            }
            return tostatura;
        }
    }
}