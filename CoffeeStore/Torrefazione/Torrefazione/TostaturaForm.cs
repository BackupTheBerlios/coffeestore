using System;
using System.Reflection;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Torrefazione
{
    public partial class TostaturaForm : Form
    {
        ApprovvigionamentoDataBinder _dataBinder;

        bool myFilter(Approvvigionamento app)
        {
            return (app.KgRimanenti > 0 && app.SacchiRimanenti > 0);
        }

        public TostaturaForm()
        {
            InitializeComponent();
            _dataBinder = new ApprovvigionamentoDataBinder(dataGridView, myFilter);
            _dataBinder.Refresh();
        }

        private void FillField(Approvvigionamento appr, object value, string property)
        {
            PropertyInfo propertyInfo = appr.GetType().GetProperty(property);
            propertyInfo.SetValue(appr, value, null);
        }

        private Approvvigionamento GetSelectedApprovvigionamento(DataGridViewCellCollection cells)
        {
            Approvvigionamento appr = new Approvvigionamento();
            IEnumerator enumerator = cells.GetEnumerator();
            while (enumerator.MoveNext())
            {
                DataGridViewTextBoxCell cell = (DataGridViewTextBoxCell)enumerator.Current;
                FillField(appr, cell.Value, cell.OwningColumn.DataPropertyName);
            }
            return appr;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 1)
            {
                MessageBox.Show("Seleziona una riga per volta");
                return;
            }

            IEnumerator en = dataGridView.SelectedRows.GetEnumerator();
            if (en.MoveNext())
            {
                DataGridViewRow firstRow = (DataGridViewRow) en.Current;
                Approvvigionamento appr = (Approvvigionamento) Db.GetUnique(GetSelectedApprovvigionamento(firstRow.Cells));

                Tostatura tost = new Tostatura(appr, tostaturaData.Value.Date, (int)kgCrudo.Value, (int)kgCotto.Value, (int)silos.Value - 1);
                if (appr.AddScarico(new Scarico(tost.Data, 1, tost.KgCrudo)))
                {
                    if (appr.SacchiRimanenti == 0 && appr.KgRimanenti > 0)
                    {
                        MessageBox.Show("Sacchi finiti, ma ci sono kg rimanenti. Li azzero");
                        appr.KgRimanenti = 0;
                    }
                    if (appr.KgRimanenti == 0 && appr.SacchiRimanenti > 0)
                    {
                        MessageBox.Show("Kg finiti, ma ci sono sacchi rimanenti. Aumento i kg in maniera fittizzia.");
                        appr.KgRimanenti = appr.SacchiRimanenti * 70;
                    }

                    Db.Set(appr.Scarichi);
                    Db.Set(appr);
                    Db.Set(tost);

                    SilosContainer.Put((int)tost.Silos, new TostaturaSilosContent(tost));

                    MessageBox.Show("Aggiunta tostatura");
                    _dataBinder.Refresh();
                }
                else
                    MessageBox.Show("Il caffe' e' finito o non e' abbastanza!");
            }
            else
                MessageBox.Show("Seleziona un approvvigionamento");
        }
    }
}