using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Torrefazione
{
    public partial class VenditoriForm : Form
    {
        private string _venditore;

        public VenditoriForm()
        {
            _venditore = "";
            InitializeComponent();
        }

        private void buttonAggiungi_Click(object sender, EventArgs e)
        {
            if (textBoxVenditore.Text.Length == 0)
            {
                MessageBox.Show("Elementi vuoti non validi");
                return;
            }

            if (Db.GetVenditore(textBoxVenditore.Text) != null)
                MessageBox.Show("Db inconsistente: Venditore {" + textBoxVenditore.Text + "}");
            else
            {
                _venditore = textBoxVenditore.Text;
                Db.Set(new Venditore(_venditore));
                Close();
            }
        }

        public string Venditore
        {
            get { return _venditore; }
        }
    }
}