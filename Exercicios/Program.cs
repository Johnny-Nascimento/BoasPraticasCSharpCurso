using System;
using System.Collections.Generic;

namespace Exercicios
{
    internal class Program_Exercicio_2
    {
        private double Soma(List<double> numeros)
        {
            double soma = 0;

            foreach (double numero in numeros)
            {
                soma += numero;    
            }

            return soma;
        }

        public double CalculaMedia(List<double> numeros)
        {
            return Soma(numeros) / numeros.Count;
        }

        // Função para calcular a mediana de uma lista de números
        public double Mediana(List<double> numeros)
        {
            List<double> sorted = new List<double>(numeros);
            sorted.Sort();

            int meio = sorted.Count / 2;
            if (sorted.Count % 2 == 0)
            {
                List<double> listaMediana = new List<double>();
                listaMediana.Add(sorted[meio - 1]);
                listaMediana.Add(sorted[meio]);

                return Soma(listaMediana) / 2.0;
            }
            else
                return sorted[meio];
        }

        static void Main(string[] args)
        {
            Console.ReadKey();
        }
    }
}

