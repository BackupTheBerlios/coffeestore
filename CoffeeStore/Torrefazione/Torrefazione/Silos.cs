using System.Collections.Generic;

namespace Torrefazione
{
    public abstract class SilosContent
    {
        public abstract int KgRimanenti
        {
            get;
        }
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
        }
    }

    public class Silos
    {
        private List<SilosContent> _silosContent;

        public Silos()
        {
            _silosContent = new List<SilosContent>();
        }

        public bool Get(int kilosRequired)
        {
            return false;
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
        static private int size = 8;
        static private SilosContainer _instance;

        private List<Silos> c;

        static public IEnumerable<SilosContent> GetEnumerable(int i)
        {
            return _instance.c[i].GetEnumerable();
        }

        static public void Put(int idx, SilosContent silosContent)
        {
            _instance.c[idx].Put(silosContent);
        }

        static public bool DelByTostatura(int idx, Tostatura tostatura)
        {
            return _instance.c[idx].DelByTostatura(tostatura);
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
            silosContainer.c = new List<Silos>(size);
            for (int i = 0; i < size; i++)
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
