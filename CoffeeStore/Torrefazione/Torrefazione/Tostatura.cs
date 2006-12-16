using System;
using System.Collections.Generic;
using System.Text;

namespace Torrefazione
{
    class Tostatura
    {
        private int _kgCrudo;
        private int _kgCotto;
        private Approvvigionamento _appr;
        private DateTime _data;
        private int _silos;

        public Tostatura(Approvvigionamento appr,DateTime data,int kgCrudo,int kgCotto,int silos)
        {
            _kgCrudo = kgCrudo;
            _kgCotto = kgCotto;
            _appr = appr;
            _data = data;
        }

        public int KgCrudo 
        {
            get { return _kgCrudo; }
            set { _kgCrudo = value; }
        }

        public int KgCotto
        {
            get { return _kgCotto; }
            set { _kgCotto = value; }
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

        public int Silos
        {
            get { return _silos; }
            set { _silos = value; }
        }

        public DateTime DataApprov
        {
            get { return _appr.Data; }
        }

        public Origine Orig
        {
            get { return _appr.Origine; }
        }

        public Tipo Tip
        {
            get { return _appr.Tipo; }
        }
    }
}
