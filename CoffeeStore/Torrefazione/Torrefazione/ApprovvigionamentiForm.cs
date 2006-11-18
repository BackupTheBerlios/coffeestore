using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Torrefazione
{
    public partial class ApprovvigionamentiForm : Form
    {
        IList<Approvvigionamento> list;
        public ApprovvigionamentiForm()
        {
            InitializeComponent();
            populateVenditoreCombo();

            refreshDataGrid();
        }

        private void ApprovvigionamentiForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonAggiungi_Click(object sender, EventArgs e)
        {
            //comboOrigine.Text; // ??
            //comboTipo.Text; // ??
            Db.data.Set(new Approvvigionamento(dataPicker.Value.Date, new Venditore(comboVenditore.Text), textNumFattura.Text, dataFatturaPicker.Value.Date, null, null, textMarche.Text, Decimal.ToInt32(numericNumSacchi.Value), Decimal.ToInt32(numericKgNetti.Value)));
            MessageBox.Show("Approvvigionamento aggiunto");
            refreshDataGrid();
        }

        private void refreshDataGrid()
        {
            list = new List<Approvvigionamento>();

            foreach (Approvvigionamento app in Db.data.Query<Approvvigionamento>(typeof(Approvvigionamento)))
                list.Add(app);

            dataGridView.DataSource = list;

            toolStripStatusLabel.Text = "Numero approvvigiomaneti: " + list.Count;
        }

        private void populateVenditoreCombo()
        {
            foreach (Venditore v in Db.data.Query<Venditore>(typeof(Venditore)))
                comboVenditore.Items.Add(v.Value);
        }

        private void buttonVenditore_Click(object sender, EventArgs e)
        {
            VenditoriForm venditoriForm = new VenditoriForm();
            venditoriForm.ShowDialog();
            if (venditoriForm.Venditore.Length != 0)
                comboVenditore.Items.Add(venditoriForm.Venditore);
        }
    }
}