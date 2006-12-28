using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Torrefazione
{
    public partial class MiscelaturaView : Form
    {
        ToolStripDataGridMenu _toolStripMenu;

        private void InitToolStripMenu()
        {
            _toolStripMenu = new ToolStripDataGridMenu(contextMenuStrip, dataGridView);

            ToolStripMenuItem info = new ToolStripMenuItem();
            info.Text = "Info";
            info.Click += new EventHandler(infoClicked);

            ToolStripMenuItem[] items = new ToolStripMenuItem[] { info };
            _toolStripMenu.SetItems(items);
        }

        public MiscelaturaView()
        {
            InitializeComponent();
            InitToolStripMenu();
            IList<Miscelatura> source = new List<Miscelatura>();

            foreach (Miscelatura m in Db.GetAll<Miscelatura>())
            {
                source.Add(m);
            }

            dataGridView.DataSource = source;
            dataGridView.Refresh();
        }

        private void ClearContext(object sender, DataGridViewCellStateChangedEventArgs e)
        {
            _toolStripMenu.Clear();
        }

        private void RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            _toolStripMenu.OnRowHeaderMouseClick(e);
        }

        private void infoClicked(object sender, EventArgs e)
        {
            Miscelatura miscelatura = GetSelectedMiscelatura();
            String str = "";
            foreach (SilosContent sc in miscelatura._silosContent)
            {
                TostaturaToMiscelaturaSilosContent msc = (TostaturaToMiscelaturaSilosContent)sc;
                sc.Activate(Db._data);
                str += String.Format("Data [{0}] Origine [{1}] Tipo [{2}] KgRimanenti [{3}] SilosOrigine [{4}]\n", sc.Data, sc.Origine, sc.Tipo, sc.KgRimanenti, msc.SilosOrigine);
            }
            MessageBox.Show(str);
        }

        private Miscelatura GetSelectedMiscelatura()
        {
            IEnumerator enumerator = _toolStripMenu.GetSelectedRowEnumerator();
            while (enumerator.MoveNext())
            {
                DataGridViewTextBoxCell cell = (DataGridViewTextBoxCell) enumerator.Current;
                if (cell.Value is Miscelatura)
                    return (Miscelatura)cell.Value;
            }
            return null;
        }
    }
}