using System;
using System.Collections.Generic;
using System.Text;

using com.db4o;

namespace Torrefazione
{
    static public class Db
    {
        public static ObjectContainer data;

        public static void initialize()
        {
            data = Db4o.OpenFile("db.db");
        }
    }
}
