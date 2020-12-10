using System;
using System.Collections.Generic;
using System.Text;

namespace beadando2
{
    class Element<T>
    {
        T values;
        Element<T> next;
        public T Data {
            get
            {
                return values;
            }
            set
            {
                values = value;
            }
        }

        internal Element<T> Next
        {
            get
            {
                return next;
            }
            set { next = value; }
        }
    }
}
