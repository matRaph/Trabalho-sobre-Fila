using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilaEncadeada
{
    public interface ILine
    {
        public bool IsEmpty();
        public void Enqueue(object value);
        public object Dequeue();

        public object Peek();
    }
}
