using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilhaEncadeada
{
    class PilhaVaziaException : Exception
    {
        public PilhaVaziaException(string? message) : base(message) {
            Console.WriteLine(message);
        }
    }
}
