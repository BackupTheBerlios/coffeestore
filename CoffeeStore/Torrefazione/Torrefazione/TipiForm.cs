using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Torrefazione
{
    public partial class TipiForm : Form
    {
        private string _tipo;

        public TipiForm()
        {
            _tipo = "";
            InitializeComponent();
        }      

        private void buttonAggiungi_Click(object sender, EventArgs e)
        {
            if (textBoxTipo.Text.Length == 0)
            {
                MessageBox.Show("Elementi vuoti non validi");
                return;
            }

            if (Db.GetTipo(textBoxTipo.Text) != null)
                MessageBox.Show("Db inconsistente: Tipo {" + textBoxTipo.Text + "}");
            else
            {
                _tipo = textBoxTipo.Text;
                Db.Set(new Tipo(_tipo));
                Close();
            }
        }

        public string Tipo
        {
            get { return _tipo; }
        }
    }
}