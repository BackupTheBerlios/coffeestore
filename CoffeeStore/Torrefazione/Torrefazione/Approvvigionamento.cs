using System;
using System.Collections.Generic;
using System.Text;

namespace Torrefazione
{
    public class Origine : ValueHolder<string>
    {
        public Origine(string value)
            : base(value)
        {

        }
    }

    public class Tipo : ValueHolder<string>
    {
        public Tipo(string value)
            : base(value)
        {

        }
    }

    public class Venditore : ValueHolder<string>
    {
        public Venditore(string value)
            : base(value)
        {

        }
    }

    public class Approvvigionamento
    {
        DateTime _data;
        Venditore _venditore;
        string _numFattura;
        DateTime _dataFattura;
        Origine _origine;
        Tipo _tipo;
        string _marche;
        int _sacchi;
        int _kgNetti;

        public Approvvigionamento()
        { 

        }

        public Approvvigionamento(DateTime data, Venditore venditore, string numFattura, DateTime dataFattura, Origine origine, Tipo tipo, String marche, int sacchi, int kgNetti)
        {
            _data = data;
            _venditore = venditore;
            _numFattura = numFattura;
            _dataFattura = dataFattura;
            _origine = origine;
            _tipo = tipo;
            _marche = marche;
            _sacchi = sacchi;
            _kgNetti = kgNetti;
        }

        public DateTime Data
        {
            get { return _data; }
            set { _data = value; }
        }

        public Venditore Venditore
        {
            get { return _venditore; }
            set { _venditore = value; }
        }

        public string NumFattura
        {
            get { return _numFattura; }
            set { _numFattura = value; }
        }

        public DateTime DataFattura
        {
            get { return _dataFattura; }
            set { _dataFattura = value; }
        }

        public Origine Origine
        {
            get { return _origine; }
            set { _origine = value; }
        }

        public Tipo Tipo
        {
            get { return _tipo; }
            set { _tipo = value; }
        }

        public string Marche
        {
            get { return _marche; }
            set { _marche = value; }
        }

        public int Sacchi
        {
            get { return _sacchi; }
            set { _sacchi = value; }
        }

        public int KgNetti
        {
            get { return _kgNetti; }
            set { _kgNetti = value; }
        }
    }
}
