using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilaVector
{
    class FilaVectorVaziaException : Exception
    {
        public FilaVectorVaziaException(string? message) : base(message)
        { 
            Console.WriteLine(message);
        }
    }
}
