using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collections.part02
{
    internal class FixedSizeList<T>
    {
        private T[] items;
        private int count;

        public FixedSizeList(int capacity)
        {
            if (capacity <= 0)
            {
                Console.WriteLine("Capacity must be greater than zero");
            }
            items = new T[capacity];
            count = 0;
        }
        public int Count
        {
            get { return count; }
        }

        public int Capacity
        {
            get { return items.Length; }
        }

        public void Add(T item)
        {
            if (count >= items.Length)
            {
                Console.WriteLine("Cannot add more items");
            }
            items[count] = item;
            count++;
        }

        public T Get(int index)
        {
            if (index < 0 || index >= count)
            {
                Console.WriteLine("Index is out of range.");
            }
            return items[index];
        }
    }
}
