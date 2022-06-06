using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilaComDuasPilhas
{
    public class DoubleStackQueue : IDoubleStackQueue
    {
        //Criando uma fila com duas pilhas genéricas
        
        //Pilha 1 responsável pelo Enqueue
        Stack<object> stack1;
        //Pilha 2 responsável pelo Dequeue
        Stack<object> stack2;

        public DoubleStackQueue()
        {
            this.stack1 = new Stack<object>();
            this.stack2 = new Stack<object>();
        }

        public object Dequeue()
        {
            if (!IsEmpty())
            {
                //Se a pilha 2 estiver vazia, efetua o Push
                //de todos os elementos da pilha 1 para a pilha 2,
                //invertendo-os
                if (this.stack2.Count == 0)
                {
                    while (this.stack1.Count > 0)
                    {
                        this.stack2.Push(this.stack1.Pop());
                    }
                }
                //Efetua o pop da pilha 2
                return this.stack2.Pop();
            }
            throw new FilaDePilhasVaziaException("Fila vazia");
        }

        public void Enqueue(object item)
        {
            //Adiciona o item à pilha 1
            this.stack1.Push(item);
        }

        public object Front()
        {
            if (!IsEmpty())
            {
                //Se a pilha 2 estiver vazia, efetua o Push
                //de todos os elementos da pilha 1 para a pilha 2,
                //invertendo-os
                if (this.stack2.Count == 0)
                {
                    while (this.stack1.Count > 0)
                    {
                        this.stack2.Push(this.stack1.Pop());
                    }
                }
                //Efetua o pop da pilha 2
                return this.stack2.Peek();
            }
            throw new FilaDePilhasVaziaException("Fila vazia");
        }

        public bool IsEmpty()
        {
            //Retorna se a fila está vazia
            return (this.stack1.Count == 0) && (this.stack2.Count == 0);
        }
        
    }
}
