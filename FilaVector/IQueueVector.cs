using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilaVector
{
    public interface IQueueVector
    {
        public void Enqueue(object value);
        public object Dequeue();
        public object Peek();
        
    }
}
