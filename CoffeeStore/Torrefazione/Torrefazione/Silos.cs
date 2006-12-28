using System.Collections.Generic;
using System.Windows.Forms;
using System;
using com.db4o;

namespace Torrefazione
{
    public abstract class SilosContent
    {
        public abstract int KgRimanenti
        {
            get;
            set;
        }

        public abstract DateTime Data
        {
            get;
        }

        public abstract Origine Origine
        {
            get;
        }

        public abstract Tipo Tipo
        {
            get;
        }

        public abstract void Activate(ObjectContainer data);
    }

    public class TostaturaSilosContent : SilosContent
    {
        public Tostatura _tostatura;
        private int _kgRimanenti;

        public TostaturaSilosContent(Tostatura tostatura)
        {
            _tostatura = tostatura;
            _kgRimanenti = tostatura.KgCotto;
        }

        public override int KgRimanenti
        {
            get { return _kgRimanenti; }
            set { _kgRimanenti = value; }
        }

        public override DateTime Data
        {
            get { return _tostatura.Data; }
        }

        public override Origine Origine
        {
            get { return _tostatura.Origine; }
        }

        public override Tipo Tipo
        {
            get { return _tostatura.Tipo; }
        }

        public override void Activate(ObjectContainer data)
        {
            data.Activate(this, 1);
            data.Activate(_tostatura, 1);
            data.Activate(_tostatura.Approvvigionamento, 2);
        }
    }

    public class TostaturaToMiscelaturaSilosContent : TostaturaSilosContent
    {
        private int _silosOrigine;

        public TostaturaToMiscelaturaSilosContent(Tostatura tostatura, int silosOrigine)
            :   base(tostatura)
        {
            _silosOrigine = silosOrigine;
        }

        public int SilosOrigine
        {
            get { return _silosOrigine; }
        }

        public override void Activate(ObjectContainer data)
        {
            data.Activate(this, 1);
            data.Activate(_tostatura, 1);
            data.Activate(_tostatura.Approvvigionamento, 2);
        }
    };

    public class MiscelaturaSilosContent : SilosContent
    { 
        public Miscelatura _miscelatura;
        protected int _kgRimanenti;

        public MiscelaturaSilosContent(Miscelatura miscelatura)
        {
            _miscelatura = miscelatura;
            _kgRimanenti = miscelatura.TotKilos;
        }

        public override int KgRimanenti
        {
            get { return _kgRimanenti; }
            set { _kgRimanenti = value; }
        }

        public override DateTime Data
        {
            get { return _miscelatura.Data; }
        }

        public override Origine Origine
        {
            get { return null; }
        }

        public override Tipo Tipo
        {
            get { return null; }
        }

        public override void Activate(ObjectContainer data)
        {
            data.Activate(this, 1);
            data.Activate(_miscelatura, 1);
            data.Activate(_miscelatura._silosContent, 1);
        }
    }

    public class MiscelaturaToConfezioniSilosContent : MiscelaturaSilosContent
    {
        public MiscelaturaToConfezioniSilosContent(Miscelatura m, int kgReq)
            :   base(m)
        {
            _kgRimanenti = kgReq;
        }

        public override void Activate(ObjectContainer data)
        {
            data.Activate(this, 1);
            data.Activate(_miscelatura, 1);
            data.Activate(_miscelatura._silosContent, 1);
        }
    };

    public class Silos
    {
        private List<SilosContent> _silosContent;

        public Silos()
        {
            _silosContent = new List<SilosContent>();
        }

        private List<SilosContent> RemoveKilos(int kilosRequired, int silosOrigine)
        {
            List<SilosContent> removed = new List<SilosContent>();

            int downCount = kilosRequired;

            List<SilosContent> contentToRemove = new List<SilosContent>();

            foreach (SilosContent sc in _silosContent)
            {
                if (downCount >= sc.KgRimanenti)
                {
                    int inserted = sc.KgRimanenti;
                    downCount -= inserted;
                    sc.KgRimanenti -= inserted;
                    contentToRemove.Add(sc);
                    addToMiscelaturaList(removed, sc, inserted, silosOrigine);
                }
                else
                {
                    sc.KgRimanenti -= downCount;
                    addToMiscelaturaList(removed, sc, downCount, silosOrigine);
                    break;
                }                
            }

            foreach (SilosContent sc in contentToRemove)
                _silosContent.Remove(sc);

            return removed;
        }

        private static void addToMiscelaturaList(List<SilosContent> removed, SilosContent sc, int kgRimanenti, int silosOrigine)
        {
            if (sc is TostaturaSilosContent)
            {
                TostaturaToMiscelaturaSilosContent ms = new TostaturaToMiscelaturaSilosContent(((TostaturaSilosContent)sc)._tostatura, silosOrigine);
                ms.KgRimanenti = kgRimanenti;
                removed.Add(ms);
            }
            else if (sc is MiscelaturaSilosContent)
            {
                Miscelatura m = ((MiscelaturaSilosContent)sc)._miscelatura;
                MiscelaturaToConfezioniSilosContent mcs = new MiscelaturaToConfezioniSilosContent(m, kgRimanenti);
                removed.Add(sc);
            }
            else
                MessageBox.Show("sc is not TostaturaToMiscelaturaSilosContent or is not MiscelaturaSilosContent");
        }

        public int ComputeKgRemaining()
        {
            int res = 0;
            foreach (SilosContent sc in _silosContent)
                res += sc.KgRimanenti;
            return res;
        }

        public List<SilosContent> Get(int kilosRequired, int silosOrigine)
        {
            List<SilosContent> removed = RemoveKilos(kilosRequired, silosOrigine);
            Db.Set(_silosContent);
            return removed;
        }

        public void Put(SilosContent silosContent)
        {
            _silosContent.Add(silosContent);
            Db.Set(_silosContent);
        }

        public bool DelByTostatura(Tostatura tostatura)
        {
            int toDel = -1;
            int i = 0;
            foreach (SilosContent s in _silosContent)
            {
                if (s is TostaturaSilosContent)
                {
                    TostaturaSilosContent ts = (TostaturaSilosContent)s;
                    if (ts._tostatura == tostatura)
                    {
                        toDel = i;
                        break;
                    }
                }
                i++;
            }

            if (toDel != -1)
            {
                _silosContent.RemoveAt(i);
                Db.Set(_silosContent);
                return true;
            }
            return false;
        }

        public IEnumerable<SilosContent> GetEnumerable()
        {
            return _silosContent;
        }
    }

    public class SilosContainer
    {
        static public int SizeFirstBlock = 8;
        static public int SizeSecondBlock = 5;
        static private SilosContainer _instance;

        private List<Silos> c;

        static public IEnumerable<SilosContent> GetEnumerable(int idx)
        {
            return _instance.c[idx - 1].GetEnumerable();
        }

        static public void Put(int idx, SilosContent silosContent)
        {
            _instance.c[idx - 1].Put(silosContent);
        }

        static public List<SilosContent> Get(int idx, int kgRequired)
        {
            return _instance.c[idx - 1].Get(kgRequired, idx);
        }

        static public bool DelByTostatura(int idx, Tostatura tostatura)
        {
            return _instance.c[idx - 1].DelByTostatura(tostatura);
        }

        static public int ComputeRemaingKilos(int idx)
        {
            return _instance.c[idx - 1].ComputeKgRemaining();
        }

        static public void Init()
        {
            int numRec = Db.GetAll<SilosContainer>().Count;

            _instance = GetInstanceFromDb();
            if (_instance == null)
                _instance = InitDb();
        }

        static public SilosContainer InitDb()
        {
            SilosContainer silosContainer = new SilosContainer();
            silosContainer.c = new List<Silos>(SizeFirstBlock + SizeSecondBlock);
            for (int i = 0; i < SizeFirstBlock + SizeSecondBlock; i++)
                silosContainer.c.Add(new Silos());

            Db.Set(silosContainer);
            Db.Set(silosContainer.c);

            return GetInstanceFromDb();
        }

        private static SilosContainer GetInstanceFromDb()
        {
            IEnumerator<SilosContainer> it = Db.GetAll<SilosContainer>().GetEnumerator();
            if (it.MoveNext())
                return it.Current;
            else
                return null;
        }
    }
}
