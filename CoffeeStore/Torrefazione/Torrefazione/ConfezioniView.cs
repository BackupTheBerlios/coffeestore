using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Torrefazione
{
    public partial class ConfezioniView : Form
    {
        public ConfezioniView()
        {
            InitializeComponent();

            List<Confezione> l = new List<Confezione>();

            foreach (Confezione c in Db.GetAll<Confezione>())
                l.Add(c);

            dataGridView.DataSource = l;

            dataGridView.Refresh();
        }
    }
}