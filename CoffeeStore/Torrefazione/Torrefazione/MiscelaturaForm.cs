using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Torrefazione
{
    public partial class MiscelaturaForm : Form
    {
        private NumericUpDown[] kgSilos;

        public MiscelaturaForm()
        {
            InitializeComponent();
            kgSilos = new NumericUpDown[] { kgSilos0, kgSilos1, kgSilos2, kgSilos3, kgSilos4, kgSilos5, kgSilos6, kgSilos7 };
        }

        private void InfoSilos0_Click(object sender, EventArgs e)
        {
            new SilosContentView(1).ShowDialog();
        }

        private void InfoSilos1_Click(object sender, EventArgs e)
        {
            new SilosContentView(2).ShowDialog();
        }

        private void InfoSilos2_Click(object sender, EventArgs e)
        {
            new SilosContentView(3).ShowDialog();
        }

        private void InfoSilos3_Click(object sender, EventArgs e)
        {
            new SilosContentView(4).ShowDialog();
        }

        private void InfoSilos4_Click(object sender, EventArgs e)
        {
            new SilosContentView(5).ShowDialog();
        }

        private void InfoSilos5_Click(object sender, EventArgs e)
        {
            new SilosContentView(6).ShowDialog();
        }

        private void InfoSilos6_Click(object sender, EventArgs e)
        {
            new SilosContentView(7).ShowDialog();
        }

        private void InfoSilos7_Click(object sender, EventArgs e)
        {
            new SilosContentView(8).ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int miscelaturaKilos = CheckMiscelaturaCreation();
            if (0 == miscelaturaKilos)
                return;

            List<SilosContent> toBeInserted = new List<SilosContent>();
            for (int i = 0; i < SilosContainer.SizeFirstBlock; i++)
            {
                int required = (int)kgSilos[i].Value;
                if (required > 0)
                    toBeInserted.AddRange(SilosContainer.Get(i+1, required));
            }

            Miscelatura miscelatura = new Miscelatura(datePicker.Value.Date, nomeMiscela.Text, (int)silosDestinazione.Value, toBeInserted);
            Db.Set(miscelatura);
            Db.Set(miscelatura._silosContent);

            Miscelatura m = (Miscelatura)Db.GetUnique(miscelatura);
            SilosContainer.Put((int)silosDestinazione.Value, new MiscelaturaSilosContent(m));

            MessageBox.Show("Miscelatura Aggiunta");
            Close();
        }

        private int CheckMiscelaturaCreation()
        {
            int miscelaturaKilos = 0;
            for (int i = 0; i < SilosContainer.SizeFirstBlock; i++)
            {
                int required = (int)kgSilos[i].Value;
                int remaining = SilosContainer.ComputeRemaingKilos(i+1);
                miscelaturaKilos += required;
                if (required > remaining)
                {
                    MessageBox.Show(String.Format("Il silos {0} non ha abbastanza caffe. Required [{1}] Remaining [{2}]", i, required, remaining));
                    return 0;
                }
            }

            if (miscelaturaKilos == 0)
                MessageBox.Show("Miscelatura con zero kg non valida");

            return miscelaturaKilos;
        }
    }
}