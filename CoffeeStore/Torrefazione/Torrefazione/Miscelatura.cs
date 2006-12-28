using System;
using System.Collections.Generic;

namespace Torrefazione
{
    public class Miscelatura
    {
        private DateTime _date;
        private string _name;
        public int _silosDestinazione;
        public List<SilosContent> _silosContent;
        private int _totKilos;

        public Miscelatura(DateTime date, string name, int silosDestinazione, List<SilosContent> silosContent)
        {
            _date = date;
            _name = name;
            _silosDestinazione = silosDestinazione;
            _silosContent = silosContent;
            _totKilos = ComputeTotKilos();
        }

        private int ComputeTotKilos()
        {
            int res = 0;
            foreach (SilosContent sc in _silosContent)
                res += sc.KgRimanenti;
            return res;
        }

        public DateTime Data
        {
            get { return _date; }
        }

        public string Nome
        {
            get { return _name; }
        }

        public int Silos
        {
            get { return _silosDestinazione; }
        }

        public Miscelatura Self
        {
            get { return this; }
        }

        public int TotKilos
        {
            get { return _totKilos; }
        }
    }
}
