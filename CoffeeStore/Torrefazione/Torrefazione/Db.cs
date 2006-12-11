using System;
using System.Collections.Generic;
using System.Text;

using com.db4o;

namespace Torrefazione
{
    static public class Db
    {
        private static ObjectContainer _data;

        public static void initialize()
        {
            _data = Db4o.OpenFile("db.db");
        }

        public static void Close()
        {
            _data.Close();
        }

        public static void Set<T>(T obj)
        {
            _data.Set(obj);
        }

        public static void viewApprovvigionamenti()
        {
            foreach (Approvvigionamento app in _data.Query<Approvvigionamento>(typeof(Approvvigionamento)))
            {
                
            }
        }

        public static IList<T> GetAll<T>()
        {
            return _data.Query<T>(typeof(T));
        }

        public static bool Del(object obj)
        {
            ObjectSet objectSet = _data.Get(obj);
            if (objectSet.Count == 0)
                return false;      
            _data.Delete(objectSet.Next());
            return true;
        }

        public static T GetByValue<T>(string value) where T : ValueHolder<string>, new()
        {
            T obj = new T();
            obj.Value = value;
            ObjectSet objectSet = _data.Get(obj);
            if (objectSet.Count == 0)
                return null;

            return (T)objectSet.Next();
        }

        public static object GetUnique(object obj)
        {
            ObjectSet objectSet = _data.Get(obj);
            if (objectSet.Count == 0)
                return null;

            return objectSet.Next();
        }

        public static Venditore GetVenditore(string value)
        {
            ObjectSet objectSet = _data.Get(new Venditore(value));
            if (objectSet.Count == 0)
                return null;

            return (Venditore)objectSet.Next();
        }

        public static Tipo GetTipo(string value)
        {
            ObjectSet objectSet = _data.Get(new Tipo(value));
            if (objectSet.Count == 0)
                return null;

            return (Tipo)objectSet.Next();
        }

        public static Origine GetOrigine(string value)
        {
            ObjectSet objectSet = _data.Get(new Origine(value));
            if (objectSet.Count == 0)
                return null;

            return (Origine)objectSet.Next();
        }
    }
}
