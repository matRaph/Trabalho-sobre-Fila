using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilaEncadeada
{
    class FilaVaziaException : Exception
    {
        public FilaVaziaException(string? message) : base(message) {
            Console.WriteLine(message);
        }
    }
}
