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

            if (propriedades.Length < 3)
                return null;

            Guid guid = new Guid();
            if (!Guid.TryParse(propriedades[0], out guid))
                return null;

            TipoPet tipoPet = (TipoPet)Convert.ToInt32(propriedades[2]);
            if (tipoPet >= TipoPet.Ultimo || tipoPet < TipoPet.Primeiro)
                return null;

            return new Pet(guid,
              propriedades[1],
              tipoPet
             );
        }
    }
}
