using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilaComDuasPilhas
{
    public interface IDoubleStackQueue
    {
        public bool IsEmpty();
        public void Enqueue(object item);
        public object Dequeue();
        public object Front();
    }
}
