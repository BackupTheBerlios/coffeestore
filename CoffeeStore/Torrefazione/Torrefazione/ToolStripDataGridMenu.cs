using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Torrefazione
{
    class ToolStripDataGridMenu
    {
        bool _toolStripMenuActive;
        int _rowClicked;
        ContextMenuStrip _contextMenuStrip;
        DataGridView _dataGridView;

        ToolStripMenuItem[] _items;

        public ToolStripDataGridMenu(ContextMenuStrip contextMenuStrip, DataGridView dataGridView)
        {
            _rowClicked = -1;
            _toolStripMenuActive = false;
            _contextMenuStrip = contextMenuStrip;
            _dataGridView = dataGridView;
        }

        public void SetItems(ToolStripMenuItem[] items)
        {
            _items = items;
        }

        public void OnRowHeaderMouseClick(DataGridViewCellMouseEventArgs e)
        {
            _rowClicked = e.RowIndex;

            if (e.Button == MouseButtons.Left && !_toolStripMenuActive)
            {
                _toolStripMenuActive = true;
                _contextMenuStrip.Items.AddRange(_items);
            }
        }

        public IEnumerator GetSelectedRowEnumerator()
        {
            return _dataGridView.Rows[_rowClicked].Cells.GetEnumerator();
        }

        public void Clear()
        {
            _contextMenuStrip.Items.Clear();
            _toolStripMenuActive = false;
        }
    }
}
