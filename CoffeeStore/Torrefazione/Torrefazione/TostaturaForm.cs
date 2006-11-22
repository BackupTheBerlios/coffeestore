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
            nbags.Maximum = _appr.Sacchi;
            nbags.Minimum = 0;
            coffeekg.Minimum = 0;
            coffeekg.Maximum = _appr.KgRimanenti;
            toastedkg.Minimum = 0;
            //nbags.Value = 0;
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
            _appr.AddScarico(new Scarico(toastdate.Value,(int) nbags.Value,(int) toastedkg.Value));
            Db.Set(_appr);
            Tostatura tost = new Tostatura(_appr, toastdate.Value, (int)nbags.Value, (int)coffeekg.Value, (int)toastedkg.Value, (int)silos.Value);
            Db.Set<Tostatura>(tost);
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