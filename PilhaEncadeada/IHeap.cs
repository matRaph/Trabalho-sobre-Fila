using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilhaEncadeada
{
    public interface IHeap
    {
        public bool IsEmpty();
        public object Pop();
        public void Push(object value);
        public object Top();

    }
}
