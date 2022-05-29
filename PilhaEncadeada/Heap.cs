using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilhaEncadeada
{
    public class Heap : IHeap
    {
        //Classe nó
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
        private Cell sentry;

        //Construtor
        public Heap()
        {
            this.size = 0;
            //Instancia da célula sentinela da lista
            this.sentry = new Cell();
            //valueo da célula sentinela é nulo
            this.sentry.value = null;
            //Ponteiro para próxima célula é nulo
            this.sentry.next = null;
            //Última célula também é a primeira
        }

        //Métodos
        public bool IsEmpty()
        {
            //Retorna true se a pilha estiver vazia
            return size == 0;
        }

        public void Push(object value)
        {
            //Instanciando o novo nó
            Cell newNode = new();
            //Atribuindo a referência da célula nova à primeira célula,
            //tornando ela a primeira célula
            newNode.next = this.sentry.next;
            //Atribuindo o novo elemento à nova célula
            newNode.value = value;
            //Ligando a sentinela ao novo nó
            this.sentry.next = newNode;
            //Aumentando o tamanho da fila
            this.size++;
        }

        public object Pop()
        {
            if (IsEmpty())
            {
                throw new PilhaVaziaException("Pìlha vazia");
            }
            //Atribui à variável retorno o valor do primeiro elemento
            object ret = this.sentry.next.value;
            //Exclui o elemento a ser retornado
          this.sentry.next = this.sentry.next.next;
            //Diminiu o tamanho da pilha
            this.size--;
            return ret;
        }

        public object Top()
        {
            if (IsEmpty())
            {
                throw new PilhaVaziaException("Pilha cheia");
            }
            //Retorna o value da primeira célula
            return this.sentry.next.value;
        }

    }
}
