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
        }

        private void nbags_ValueChanged(object sender, EventArgs e)
        {
            nbags.Maximum = _appr.Sacchi;
            nbags.Minimum = 0;
            if (nbags.Value < nbags.Maximum)
            {
                nbags.Value = nbags.Value + 1;
                int tmp = 70 * (int)nbags.Value;
                if (tmp < _appr.KgNetti)
                    coffeekg.Value = tmp;
            }

        }

        private void okbutton_Click(object sender, EventArgs e)
        {
            _appr.AddScarico(new Scarico(toastdate.Value,(int) nbags.Value,(int) coffeekg.Value));
            Close();
        }

        private void resetbutton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}