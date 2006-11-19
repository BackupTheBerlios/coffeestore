using System;
using System.Collections.Generic;
using System.Text;

namespace Torrefazione
{
    public class ValueHolder<T>
    {
        T _value;

        public ValueHolder(T value)
        {
            _value = value;
        }

        public ValueHolder()
        { 
        
        }

        public T Value
        {
            get { return _value; }
            set { _value = Value; }
        }

        public override string ToString()
        {
            return _value.ToString();
        }
    }
}
