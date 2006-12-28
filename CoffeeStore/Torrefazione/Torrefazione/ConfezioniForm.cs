using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Torrefazione
{
    public partial class ConfezioniForm : Form
    {
        public ConfezioniForm()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            int siloProv_ = (int)siloProv.Value;
            int pesoNettoTotale_ = (int)pesoTotale.Value;
            string tipoConfezione_ = tipoConfezione.Text;
            int numConfezioni_ = (int)numConfezioni.Value;

            if (pesoNettoTotale_ <= 0 || numConfezioni_ <= 0)
            {
                MessageBox.Show("Peso o numero confezioni non puo essere zero");
                return;
            }

            if (pesoNettoTotale_ <= SilosContainer.ComputeRemaingKilos(siloProv_))
            {
                List<SilosContent> silosContent = SilosContainer.Get(siloProv_, pesoNettoTotale_);

                Confezione conf = new Confezione(siloProv_, pesoNettoTotale_, tipoConfezione_, numConfezioni_, lotto.Text, silosContent);
                Db.Set(conf);

                MessageBox.Show("Confezioni create");
                Close();
            }
            else 
                MessageBox.Show("Non c'e' abbastanza caffe");
        }

        private void infoButton_Click(object sender, EventArgs e)
        {
            String str = "";
            foreach (SilosContent sc in SilosContainer.GetEnumerable((int)siloProv.Value))
            {
                sc.Activate(Db._data);
                MiscelaturaSilosContent msc = (MiscelaturaSilosContent)sc;
                str += String.Format("Data [{0}] KgRimanenti [{1}]\n", sc.Data, sc.KgRimanenti);
                foreach (SilosContent subsc in msc._miscelatura._silosContent)
                {
                    subsc.Activate(Db._data);
                    str += String.Format("\tData [{0}] Origine [{1}] Tipo [{2}] KgRimanenti [{3}]\n", subsc.Data, subsc.Origine, subsc.Tipo, subsc.KgRimanenti);
                }
            }
            MessageBox.Show(str);
        }
    }
}