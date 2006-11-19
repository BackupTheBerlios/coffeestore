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
        ApprovvigionamentoDataBinder _dataBinder;

        public ApprovvigionamentiForm()
        {
            InitializeComponent();

            _dataBinder = new ApprovvigionamentoDataBinder(dataGridView);

            PopulateVenditoreCombo();
            PopulateOrigineCombo();
            PopulateTipoCombo();

            RefreshDataGrid();
        }

        private void buttonAggiungi_Click(object sender, EventArgs e)
        {
            if (!isFormValid())
                return;

            Venditore venditore = Db.GetVenditore(comboVenditore.Text);
            Origine origine = Db.GetOrigine(comboOrigine.Text);
            Tipo tipo = Db.GetTipo(comboTipo.Text);

            if (venditore == null || origine == null || tipo == null)
            {
                MessageBox.Show("Internal DB error");
                return;
            }

            Db.Set(new Approvvigionamento(dataPicker.Value.Date, venditore, textNumFattura.Text, dataFatturaPicker.Value.Date, origine, tipo, textMarche.Text, Decimal.ToInt32(numericNumSacchi.Value), Decimal.ToInt32(numericKgNetti.Value)));

            MessageBox.Show("Approvvigionamento aggiunto");
            ResetForm();

            RefreshDataGrid();
        }

        private bool isFormValid()
        {
            if (comboVenditore.Text.Length == 0)
            {
                MessageBox.Show("Seleziona un venditore");
                return false;
            }

            if (comboOrigine.Text.Length == 0)
            {
                MessageBox.Show("Seleziona un'origine");
                return false;
            }

            if (comboTipo.Text.Length == 0)
            {
                MessageBox.Show("Seleziona un tipo");
                return false;
            }

            if (textNumFattura.Text.Length == 0)
            {
                MessageBox.Show("Riempi numero fattura");
                return false;
            }

            if (textMarche.Text.Length == 0)
            {
                MessageBox.Show("Riempi marche");
                return false;
            }

            if (numericNumSacchi.Value == 0)
            {
                MessageBox.Show("Numero di sacchi non valido");
                return false;
            }

            if (numericKgNetti.Value == 0)
            {
                MessageBox.Show("Kg netti non validi");
                return false;
            }

            return true;
        }

        private void ResetForm()
        {
            dataPicker.Value = DateTime.Today;
            comboVenditore.Text = ""; //FIXME: mettere un default
            textNumFattura.Text = "";
            dataFatturaPicker.Value = DateTime.Today;
            comboOrigine.Text = ""; //FIXME: mettere un default
            comboTipo.Text = "";
            textMarche.Text = ""; //FIXME: mettere un default
            numericNumSacchi.Value = 0;
            numericKgNetti.Value = 0;
        }

        private void RefreshDataGrid()
        {
            _dataBinder.Refresh();
            toolStripStatusLabel.Text = "Numero approvvigiomaneti: " + _dataBinder.Count;
        }

        private void PopulateVenditoreCombo()
        {
            foreach (Venditore v in Db.GetAll<Venditore>())
                comboVenditore.Items.Add(v.Value);
        }

        private void PopulateOrigineCombo()
        {
            foreach (Origine v in Db.GetAll<Origine>())
                comboOrigine.Items.Add(v.Value);
        }

        private void PopulateTipoCombo()
        {
            foreach (Tipo v in Db.GetAll<Tipo>())
                comboTipo.Items.Add(v.Value);
        }

        private void buttonVenditore_Click(object sender, EventArgs e)
        {
            VenditoriForm venditoriForm = new VenditoriForm();
            venditoriForm.ShowDialog();
            if (venditoriForm.Venditore.Length != 0)
                comboVenditore.Items.Add(venditoriForm.Venditore);
        }

        private void buttonOrigine_Click(object sender, EventArgs e)
        {
            OriginiForm originiForm = new OriginiForm();
            originiForm.ShowDialog();
            if (originiForm.Origine.Length != 0)
                comboOrigine.Items.Add(originiForm.Origine);
        }

        private void buttonTipo_Click(object sender, EventArgs e)
        {
            TipiForm tipoForm = new TipiForm();
            tipoForm.ShowDialog();
            if (tipoForm.Tipo.Length != 0)
                comboTipo.Items.Add(tipoForm.Tipo);
        }
    }
}