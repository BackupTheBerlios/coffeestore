using System;
using System.Collections.Generic;
using System.Text;

namespace Torrefazione
{
    class Tostatura
    {
        private int _bags;
        private int _originalkg;
        private int _toastedkg;
        private Approvvigionamento _appr;
        private DateTime _data;

        public Tostatura(Approvvigionamento appr, int originalkg, int toastedkg)
        {
            _originalkg = originalkg;
            _toastedkg = toastedkg;
            _appr = appr;
        }

        public int Bags 
        {
            get { return _bags; }
            set { _bags = value; }
        }

        public int OriginalKg 
        {
            get { return _originalkg; }
            set { _originalkg = value; }
        }

        public int ToastedKg
        {
            get { return _toastedkg; }
            set { _toastedkg = value; }
        }

        public Approvvigionamento Appr
        {
            get { return _appr; }
            set { _appr = value; }
        }

        public DateTime Data
        {
            get {return _data;}
            set { _data = value; }
        }        
    }
}
