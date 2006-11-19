using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Torrefazione
{
    public partial class OriginiForm : Form
    {
        private string _origine;

        public OriginiForm()
        {
            _origine = "";
            InitializeComponent();
        }

        private void buttonAggiungi_Click(object sender, EventArgs e)
        {
            if (textBoxOrigine.Text.Length == 0)
            {
                MessageBox.Show("Elementi vuoti non validi");
                return;
            }

            if (Db.GetOrigine(textBoxOrigine.Text) != null)
                MessageBox.Show("Db inconsistente: Origine {" + textBoxOrigine.Text + "}");
            else
            {
                _origine = textBoxOrigine.Text;
                Db.Set(new Origine(_origine));
                Close();
            }
        }

        public string Origine
        {
            get { return _origine; }
        }
    }
}