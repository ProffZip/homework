using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    static class Container<T>
    {
        public static T[] GetArray(MyList<T> list)
        {
            var array = new T[list.data.Count()];

            for (var i = 0; i < list.data.Count(); i++)
            {
                array[i] = list.data[i];
            }
            return array;
        }
    }
}