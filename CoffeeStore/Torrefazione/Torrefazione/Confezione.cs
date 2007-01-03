using System;
using System.Collections.Generic;
using System.Text;

namespace Torrefazione
{
    public class Confezione
    {
        private int _siloProv;
        private int _pesoNettoTotale;
        private string _tipoConfezione;
        private int _numConfezioni;
        private string _lotto;

        public List<SilosContent> _contentConfezione;



        public Confezione(int siloProv, int pesoNettoTotale, string tipoConfezione, int numConfezioni, string lotto, List<SilosContent> contentConfezione)
        {
            _siloProv = siloProv;
            _pesoNettoTotale = pesoNettoTotale;
            _tipoConfezione = tipoConfezione;
            _numConfezioni = numConfezioni;
            _contentConfezione = contentConfezione;
            _lotto = lotto;
        }

        public int SiloProv
        {
            get { return _siloProv; }
        }

        public int PesoNettoTot
        {
            get { return _pesoNettoTotale; }
        }

        public string PesoConfezione
        {
            get { return _tipoConfezione; }
        }

        public int NumConfezioni
        {
            get { return _numConfezioni; }
        }

        public string Lotto
        {
            get { return _lotto; }
        }

        public Confezione Self
        {
            get { return this; }
        }
    }
}
