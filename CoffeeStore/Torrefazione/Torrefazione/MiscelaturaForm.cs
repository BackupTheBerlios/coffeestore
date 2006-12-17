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
        public MiscelaturaForm()
        {
            InitializeComponent();
        }

        private void InfoSilos0_Click(object sender, EventArgs e)
        {
            new SilosContentView(0).ShowDialog();
        }

        private void InfoSilos1_Click(object sender, EventArgs e)
        {
            new SilosContentView(1).ShowDialog();
        }

        private void InfoSilos2_Click(object sender, EventArgs e)
        {
            new SilosContentView(2).ShowDialog();
        }

        private void InfoSilos3_Click(object sender, EventArgs e)
        {
            new SilosContentView(3).ShowDialog();
        }

        private void InfoSilos4_Click(object sender, EventArgs e)
        {
            new SilosContentView(4).ShowDialog();
        }

        private void InfoSilos5_Click(object sender, EventArgs e)
        {
            new SilosContentView(5).ShowDialog();
        }

        private void InfoSilos6_Click(object sender, EventArgs e)
        {
            new SilosContentView(6).ShowDialog();
        }

        private void InfoSilos7_Click(object sender, EventArgs e)
        {
            new SilosContentView(7).ShowDialog();
        }
    }
}