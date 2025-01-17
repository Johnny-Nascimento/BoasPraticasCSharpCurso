using Alura.Adopet.Console.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Adopet.Console.Util
{
    public static class ConversorCSVParaPet
    {
        public static Pet? ConverteDoTexto(this string linha)
        {
            if (linha == null)
                return null;

            string[] propriedades = linha.Split(';');

            if (propriedades.Length < 2)
                return null;

            return new Pet(Guid.Parse(propriedades[0]),
              propriedades[1],
              TipoPet.Cachorro
             );
        }
    }
}
