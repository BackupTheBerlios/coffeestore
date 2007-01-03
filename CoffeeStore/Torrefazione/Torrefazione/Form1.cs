using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Torrefazione
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void esciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void approvvigionamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ApprovvigionamentiForm().ShowDialog();
        }

        private void approvvigionamentoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new ApprovvigionamentiView().ShowDialog();
        }

        private void miscelaturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new MiscelaturaForm().ShowDialog();
        }

        private void tostaturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new TostaturaForm().ShowDialog();
        }

        private void tostaturaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new TostaturaView().ShowDialog();
        }
        
        private void miscelaturaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new MiscelaturaView().ShowDialog();
        }

        private void confezionamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ConfezioniForm().ShowDialog();
        }

        private void confezionamentoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new ConfezioniView().ShowDialog();
        }

        private void dToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new StoricoLotto().ShowDialog();
        }
    }
}