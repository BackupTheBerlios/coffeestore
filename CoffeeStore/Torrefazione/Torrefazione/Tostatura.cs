using System;
using System.Collections.Generic;
using System.Text;

namespace Torrefazione
{
    public class Tostatura
    {
        private int _kgCrudo;
        private int _kgCotto;
        private Approvvigionamento _appr;
        private DateTime _data;
        private int _silos;

        public Tostatura()
        {

        }

        public Tostatura(Approvvigionamento appr,DateTime data,int kgCrudo,int kgCotto,int silos)
        {
            _kgCrudo = kgCrudo;
            _kgCotto = kgCotto;
            _appr = appr;
            _data = data;
            _silos = silos;
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

        public Approvvigionamento Approvvigionamento
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

        public DateTime DataApprovvigionameto
        {
            get { return _appr.Data; }
        }

        public Origine Origine
        {
            get { return _appr.Origine; }
        }

        public Tipo Tipo
        {
            get { return _appr.Tipo; }
        }
    }
}
