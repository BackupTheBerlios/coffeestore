using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Torrefazione
{
    public partial class ConfirmDialog : Form
    {
        public ConfirmDialog(string text)
        {
            InitializeComponent();
            label.Text = text;
        }
    }
}