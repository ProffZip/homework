using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    class MyDictionary<TKey, TValue>
    {
        protected List<TKey> keys = new List<TKey>();
        protected List<TValue> values = new List<TValue>();
        public void Add(TKey key, TValue value)
        {
            keys.Add(key);
            values.Add(value);
        }
        public TValue this[int index]
        {
            get
            {
                if (index > values.Count())
                {
                    Console.WriteLine("index is out of range");
                    return default(TValue);
                }
                else return values[index];
            }
        }
        public int mass => keys.Count() + values.Count();
    }
}