using System;
using System.Collections;
using System.Collections.Generic;

namespace Modul3HW1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var list = new SomeList<int>();
            list.Add(1);
            list.Add(12);
            list.Add(7);
            list.AddRange(new int[] { 1, 42, 622, 84, 37 });

            list.RemoveAt(2);

            // list.RemoveAt(19);
            list.Sort();
            list[0] = 2;

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
