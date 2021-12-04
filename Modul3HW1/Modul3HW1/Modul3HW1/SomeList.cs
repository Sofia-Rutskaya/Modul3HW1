using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul3HW1
{
    public class SomeList<T>
    {
        private T[] _value;
        private int _index;
        private int _capacity;

        public SomeList()
        {
            _capacity = 4;
            _value = new T[_capacity];
            _index = 0;
        }

        public T this[int index]
        {
            get { return _value[index]; }
            set { _value[index] = value; }
        }

        public void Add(T item)
        {
            if (_index >= _capacity)
            {
                _capacity *= 2;
                _value = ChangeList();
            }

            _value[_index] = item;
            _index++;
        }

        public void AddRange(ICollection collection)
        {
            try
            {
                foreach (var item in collection)
                {
                    Add((T)item);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}");
                return;
            }
        }

        public IEnumerator GetEnumerator()
        {
            return _value.GetEnumerator();
        }

        public bool Remove(T value)
        {
            try
            {
                for (var i = 0; i < _index; i++)
                {
                    if (_value[i].Equals(value))
                    {
                        _value[i] = default(T);
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}");
                return false;
            }

            return false;
        }

        public void RemoveAt(int index)
        {
            try
            {
                _value[index] = default(T);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}");
                return;
            }
        }

        public void Sort()
        {
            try
            {
                Array.Sort<T>(_value, new SortInt<T>());
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}");
                return;
            }
        }

        private T[] ChangeList()
        {
            var value = new T[_capacity];

            for (var i = 0; i < _value.Length; i++)
            {
                value[i] = _value[i];
            }

            return value;
        }
    }
}
