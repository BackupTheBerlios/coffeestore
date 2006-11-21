using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Torrefazione
{
    public partial class ScarichiView : Form
    {
        Approvvigionamento _appr;

        public ScarichiView(Approvvigionamento appr)
        {
            InitializeComponent();

            _appr = appr;
            dataGridView.DataSource = _appr.Scarichi;
            dataGridView.Refresh();
        }
    }
}