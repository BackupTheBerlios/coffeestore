using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Torrefazione
{
    public partial class TostaturaForm : Form
    {
        private Approvvigionamento _appr;

        public TostaturaForm(Approvvigionamento appr)
        {
            _appr = appr;
            InitializeComponent();
            apprlabel.Text = "Venditore: " + _appr.Venditore + " - Origine: " + _appr.Origine + " - Tipo: " + _appr.Tipo;
            nbags.Maximum = _appr.SacchiRimanenti;
            nbags.Minimum = 0;
            coffeekg.Minimum = 0;
            coffeekg.Maximum = _appr.KgRimanenti;
            toastedkg.Minimum = 0;
        }

        private void nbags_ValueChanged(object sender, EventArgs e)
        {
            if (nbags.Value < nbags.Maximum)
            {
                int val = (int) nbags.Value;
                int tmp = 70 * (int)nbags.Value;
                if (tmp < _appr.KgRimanenti)
                {
                    coffeekg.Value = tmp;
                    toastedkg.Maximum = tmp;
                    toastedkg.Value = tmp;
                }
            }
        }

        private void okbutton_Click(object sender, EventArgs e)
        {          
            Tostatura tost = new Tostatura(_appr, toastdate.Value.Date, (int)coffeekg.Value, (int)toastedkg.Value, (int)silos.Value);
            _appr.AddScarico(new Scarico(tost.Data, 1, tost.KgCrudo));
            Close();
        }

        private void resetbutton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void coffeekg_ValueChanged(object sender, EventArgs e)
        {
            toastedkg.Maximum = coffeekg.Value;
        }
    }
}