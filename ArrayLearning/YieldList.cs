using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayLearning
{
    public class YieldList<T>
    {
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

        public int Capacity { get; set; }

        public int Count { get; set; }

        public YieldList()
        {
            items = new T[10];
            Count = 0;
            Capacity = 10;
        }

        public void Add(T item)
        {
            items[Count] = item;
            Count++;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < Count; i++)
            {
                yield return items[i];
            }
            yield break;
        }


    }
}
