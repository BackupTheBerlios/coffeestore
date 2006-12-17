using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Torrefazione
{
    public partial class SilosContentView : Form
    {
        public SilosContentView(int i)
        {
            InitializeComponent();

            label1.Text = "";
            foreach (SilosContent sc in SilosContainer.GetEnumerable(i))
                label1.Text += sc.GetType() + " - " + sc.KgRimanenti + "\n";
        }
    }
}