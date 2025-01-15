using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Adopet.Console.Comandos
{
    interface IComando
    {
        public Task ExecutarAsync(string[] args);
    }
}
