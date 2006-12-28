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
            label.Text = "";
            foreach (SilosContent sc in SilosContainer.GetEnumerable(i))
            {
                sc.Activate(Db._data);
                label.Text += String.Format("Data [{0}] Origine [{1}] Tipo [{2}] KgRimanenti [{3}]\n", sc.Data, sc.Origine, sc.Tipo, sc.KgRimanenti);
            }
        }
    }
}