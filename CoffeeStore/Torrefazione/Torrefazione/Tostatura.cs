using System;
using System.Collections.Generic;
using System.Text;

namespace Torrefazione
{
    class Tostatura
    {
        private int _originalkg;
        private int _toastedkg;
        private Approvvigionamento _appr;

        public Tostatura(Approvvigionamento appr, int originalkg, int toastedkg)
        {
            _originalkg = originalkg;
            _toastedkg = toastedkg;
            _appr = appr;
        }
    }
}
