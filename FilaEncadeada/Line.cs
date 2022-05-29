using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilaEncadeada
{
    public class Line : ILine
    {
        class Cell
        {
            //Elemento da célula
            public object? value;
            //Ponteiro da próxima célula
            public Cell? next;
        }

        //Tamanho da lista
        private int size;
        //Célula sentinela e última célula da lista
        private Cell sentry, last;

        //Construtor
        public Line()
        {
            this.size = 0;
            //Instancia da célula sentinela da lista
            this.sentry = new Cell();
            //valueo da célula sentinela é nulo
            this.sentry.value = null;
            //Ponteiro para próxima célula é nulo
            this.sentry.next = null;
            //Última célula também é a primeira
            last = sentry;
        }

        //Métodos
        public object Dequeue()
        {
            if (IsEmpty())
            {
                throw new FilaVaziaException("Fila vazia");
            }
            //Atribui à variável retorno o primeiro valueo da lista
            object ret = this.sentry.next.value;
            //Exclui o primeiro value, ligando a cell sentinela ao próximo valor
            this.sentry.next = this.sentry.next.next;
            //Diminui o tamanho da fila
            this.size--;
            //Retorna retorno
            return ret;
        }

        public object Peek()
        {
            if (IsEmpty())
            {
                throw new FilaVaziaException("Fila vazia");
            }
            //Retorna o value da célula seguinta à célula sentinela
            return this.sentry.next.value;
        }

        public bool IsEmpty()
        {
            //Retorna true se a fila estiver vazia
            return size == 0;
        }

        public void Enqueue(object value)
        {
            //Adiciona uma nova célula no final da fila
            this.last.next = new Cell();
            //Atribui à nova célula, o valueo obj
            this.last.next.value = value;
            //Torna a nova célula a última
            this.last = this.last.next;
            //Aumenta o tamanho da fila
            this.size++;
        }
    }
}
