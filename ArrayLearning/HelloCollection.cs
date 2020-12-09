using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayLearning
{
    public class HelloCollection
    {
        public IEnumerator<String> GetEnumerator()
        {
            yield return "hello";
            yield return "world";
        }
    }
}
