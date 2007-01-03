using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Torrefazione
{
    public partial class StoricoLotto : Form
    {
        public StoricoLotto()
        {
            InitializeComponent();
        }

        private void ShowLottoInfo(Confezione conf)
        {
            conf.SiloProv;
            conf._contentConfezione
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            foreach (Confezione c in Db.GetAll<Confezione>())
            {
                if (c.Lotto.Equals(textIdLotto.Text))
                {
                    MessageBox.Show("Lotto trovato!");
                    ShowLottoInfo(c);
                    return;
                }
            }
            MessageBox.Show("Lotto non trovato!");
        }
    }
}