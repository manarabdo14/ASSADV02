using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSADV02
{
    public class FixedSizeList<T>
    {
        private T[] _items;
        private int _count;
        public FixedSizeList(int capacity)
        {
            if (capacity <= 0)
            {
                throw new ArgumentException("Capacity must be greater than zero.", nameof(capacity));
            }

            _items = new T[capacity];
            _count = 0;
        }
        public int Count => _count;
        public int Capacity => _items.Length;
        public void Add(T item)
        {
            if (_count >= Capacity)
            {
                throw new InvalidOperationException("List capacity exceeded. Cannot add more elements.");
            }

            _items[_count] = item;
            _count++;
        }
        public T Get(int index)
        {
            if (index < 0 || index >= _count)
            {
                throw new IndexOutOfRangeException("Index is out of range.");
            }

            return _items[index];
        }
    }
    
}
