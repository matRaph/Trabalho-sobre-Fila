using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilaVector
{
    public class QueueVector : IQueueVector
    {
        //ArrayList
        public List<object> Queue { get; set; }
        
        //Construtor
        public QueueVector()
        {
            this.Queue = new List<object>();
        }

        //Métodos
        public object Dequeue()
        {
            try
            {
                object ret = this.Queue[0];
                Queue.RemoveAt(0);
                return ret;
            }
            catch (ArgumentOutOfRangeException)
            {
                throw new FilaVectorVaziaException("Fila Vazia");
            }
        }

        public void Enqueue(object value)
        {
            //Adiciona o value ao fim da fila
            this.Queue.Add(value);
        }

        public object Peek()
        {
            try
            {
                return this.Queue[0];
            }
            catch (ArgumentOutOfRangeException)
            {
                throw new FilaVectorVaziaException("Fila Vazia");
            }
        }
    }
}
