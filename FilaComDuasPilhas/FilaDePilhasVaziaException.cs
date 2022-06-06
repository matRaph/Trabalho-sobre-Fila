using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilaComDuasPilhas
{
    public class FilaDePilhasVaziaException :Exception
    {
        public FilaDePilhasVaziaException(string message) : base(message)
        {
            Console.WriteLine(message);
        }
    }
}
