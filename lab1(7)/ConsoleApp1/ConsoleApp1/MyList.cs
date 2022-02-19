using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    class MyList<T>
    {
        public List<T> data = new List<T>();
        public void Add(T item)
        {
            data.Add(item);
        }
        public T this[int index]
        {
            get
            {
                if (index > data.Count())
                {
                    Console.WriteLine("index is out of range");
                    return default(T);
                }
                else return data[index];
            }
        }
        public int mass => data.Count();
    }
}