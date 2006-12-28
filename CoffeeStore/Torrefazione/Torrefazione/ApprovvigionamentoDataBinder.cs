using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Torrefazione
{
    public class ApprovvigionamentoDataBinder
    {
        List<Approvvigionamento> _list;
        DataGridView _dataGridView;

        public delegate bool Filter(Approvvigionamento app);

        Filter _filter;

        public ApprovvigionamentoDataBinder(DataGridView dataGridView)
        {
            _dataGridView = dataGridView;
            _filter = null;
        }

        public ApprovvigionamentoDataBinder(DataGridView dataGridView, Filter filter)
        {
            _dataGridView = dataGridView;
            _filter = filter;
        }

        public void Refresh()
        {
            _list = new List<Approvvigionamento>();

            foreach (Approvvigionamento app in Db.GetAll<Approvvigionamento>())
            {
                if (_filter == null || _filter(app))
                    _list.Add(app);
            }

            _list.Sort(delegate(Approvvigionamento x, Approvvigionamento y)
                {
                    return -1 * x.Data.CompareTo(y.Data);
                }
            );

            _dataGridView.DataSource = _list;
            _dataGridView.Refresh();
        }

        public void RefreshInverted()
        {
            _list = new List<Approvvigionamento>();

            foreach (Approvvigionamento app in Db.GetAll<Approvvigionamento>())
            {
                if (_filter == null || _filter(app))
                    _list.Add(app);
            }

            _list.Sort(delegate(Approvvigionamento x, Approvvigionamento y)
                {
                    return x.Data.CompareTo(y.Data);
                }
            );

            _dataGridView.DataSource = _list;
            _dataGridView.Refresh();
        }

        public int Count
        {
            get { return (_list != null) ? _list.Count : 0; }
        }
    }
}
