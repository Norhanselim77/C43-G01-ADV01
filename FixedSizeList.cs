using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01_C__Advanced
{
    internal class FixedSizeList<T>
    {
        public T[] Items { get; set; }

        public int CurrentIndex;


        public FixedSizeList(int capacity)
        {
            if (capacity <= 0)
            {
                throw new ArgumentException("Capacity must be greater than zero.");
            }

            Items = new T[capacity];
            CurrentIndex = 0;
        }

        public void Add(T item)
        {
            if (CurrentIndex >= Items.Length)
            {
                throw new InvalidOperationException("Cannot add more elements, the list is full.");
            }

            Items[CurrentIndex] = item;
            CurrentIndex++;
        }

        public T Get(int index)
        {
            if (index < 0 || index >= CurrentIndex)
            {
                throw new IndexOutOfRangeException("Invaid index. Please provide a valid index.");
            }

            return Items[index];
        }

        public int count => CurrentIndex;

    }
}