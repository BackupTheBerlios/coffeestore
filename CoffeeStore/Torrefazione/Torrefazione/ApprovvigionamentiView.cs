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
        ToolStripDataGridMenu _toolStripMenu;

        public ApprovvigionamentiView()
        {
            InitializeComponent();           
            InitToolStripMenu();
            _dataBinder = new ApprovvigionamentoDataBinder(dataGridView);
            RefreshDataGrid();
        }

        private void InitToolStripMenu()
        {
            _toolStripMenu = new ToolStripDataGridMenu(contextMenuStrip, dataGridView);

            ToolStripMenuItem elimina = new ToolStripMenuItem();
            elimina.Text = "Elimina";
            elimina.Click += new EventHandler(eliminaClicked);

            ToolStripMenuItem scarica = new ToolStripMenuItem();
            scarica.Text = "Effettua Scarico";
            scarica.Click += new EventHandler(scaricaClicked);

            ToolStripMenuItem viewScarichi = new ToolStripMenuItem();
            viewScarichi.Text = "Visualizza Scarichi";
            viewScarichi.Click += new EventHandler(visualizzaScarichiClicked);

            ToolStripMenuItem[] items = new ToolStripMenuItem[] { elimina, scarica, viewScarichi };
            _toolStripMenu.SetItems(items);
        }

        private void RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            _toolStripMenu.OnRowHeaderMouseClick(e);
        }

        private void ClearContext(object sender, DataGridViewCellStateChangedEventArgs e)
        {
            _toolStripMenu.Clear();
        }

        private void FillField(Approvvigionamento appr, object value, string property)
        {
            PropertyInfo propertyInfo = appr.GetType().GetProperty(property);
            propertyInfo.SetValue(appr, value, null);
        }

        private void eliminaClicked(object sender, EventArgs e)
        {
            Approvvigionamento appr = GetSelectedApprovvigionamento();
            Form confirm = new ConfirmDialog("Vuoi veramente eliminare l'approvvigionamento selezionato?");
            if (confirm.ShowDialog() == DialogResult.OK)
                eliminaApprovvigionamento(appr);
        }

        private void eliminaApprovvigionamento(Approvvigionamento appr)
        {
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
            IEnumerator enumerator = _toolStripMenu.GetSelectedRowEnumerator();
            while (enumerator.MoveNext())
            {
                DataGridViewTextBoxCell cell = (DataGridViewTextBoxCell)enumerator.Current;
                FillField(appr, cell.Value, cell.OwningColumn.DataPropertyName);
            }
            return appr;
        }

        private void scaricaClicked(object sender, EventArgs e)
        {
            Approvvigionamento appr = (Approvvigionamento)Db.GetUnique(GetSelectedApprovvigionamento());

            if (appr.SacchiRimanenti <= 0 || appr.KgRimanenti <= 0)
            {
                MessageBox.Show("Il caffe' e' finito!");
                return;
            }
            TostaturaForm tost = new TostaturaForm(appr);
            tost.ShowDialog();
            Db.Set(appr.Scarichi);
            Db.Set(appr);
        }

        private void visualizzaScarichiClicked(object sender, EventArgs e)
        {
            Approvvigionamento appr = (Approvvigionamento)Db.GetUnique(GetSelectedApprovvigionamento());
            new ScarichiView(appr).ShowDialog();
        }

        private void RefreshDataGrid()
        {
            _dataBinder.Refresh();
            toolStripStatusLabel1.Text = "Numero approvvigiomaneti: " + _dataBinder.Count;
        }
    }
}