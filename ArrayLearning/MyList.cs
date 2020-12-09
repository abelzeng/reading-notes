using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayLearning
{
    public class MyList<T>
    {
        public int Capacity { get; set; }

        private int count;
        public int Count { get => count; }


        private T[] items;

        public T this[int index]
        {
            get
            {
                return items[index];
            }
            set
            {
                items[index] = value;
            }
        }

        public MyList()
        {
            items = new T[0];
        }

        public MyList(int capacity)
        {
            Capacity = capacity;
            items = new T[capacity];
        }

        public void Add(T item)
        {
            items[count] = item;
            count++;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new MyListEnumerator<T>(this);
        }


    }
}
