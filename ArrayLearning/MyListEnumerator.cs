using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayLearning
{
    public class MyListEnumerator<T> : IEnumerator<T>
    {
        private MyList<T> myList;
        private int index;
        private T current;

        public MyListEnumerator(MyList<T> myList)
        {
            this.myList = myList;
            this.index = -1;

        }
        public T Current => current;

        object IEnumerator.Current => current;

        public void Dispose()
        {

        }

        public bool MoveNext()
        {
            index++;
            this.current = myList[index];
            return index < myList.Count;
        }

        public void Reset()
        {

        }
    }
}
