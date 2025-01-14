using System;

namespace Exercicios
{
    internal class Program_Exercicio_1
    {
        private static int Soma(int primeiroNumero, int segundoNumero)
        {
            return primeiroNumero + segundoNumero;
        }

        private static int Subtracao(int primeiroNumero, int segundoNumero)
        {
            return primeiroNumero - segundoNumero;
        }

        private static int Multiplicacao(int primeiroNumero, int segundoNumero)
        {
            return primeiroNumero * segundoNumero;
        }

        private static double Divisao(int primeiroNumero, int segundoNumero, out bool erro)
        {
            erro = false;

            if (segundoNumero != 0)
                return (double)primeiroNumero / segundoNumero;
            else
            {
                erro = true;
                return 0;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro número: ");
            int numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            int numero2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"A soma é: {Soma(numero1, numero2)}");

            Console.WriteLine($"A subtração é: {Subtracao(numero1, numero2)}");

            Console.WriteLine($"A multiplicação é: {Multiplicacao(numero1, numero2)}");

            bool erro = false;
            double divisao = Divisao(numero1, numero2, out erro);

            if (erro)
                Console.WriteLine("Não é possível dividir por zero.");
            else
                Console.WriteLine("A divisão é: " + divisao);

            Console.ReadLine();
        }
    }
}

