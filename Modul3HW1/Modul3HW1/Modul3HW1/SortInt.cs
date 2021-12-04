using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul3HW1
{
    public class SortInt<T> : IComparer<T>
    {
        public int Compare(T x, T y)
        {
            if ((int)(object)x > (int)(object)y)
            {
                var a = x;
                x = y;
                y = a;

                return 1;
            }
            else if ((int)(object)x < (int)(object)y)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
