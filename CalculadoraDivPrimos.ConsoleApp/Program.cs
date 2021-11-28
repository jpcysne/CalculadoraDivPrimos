using CalculadoraDivPrimos.Servicos.Servico;
using System;

namespace CalculadoraDivPrimos.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Favor colocar um numero para saber os Números divisores e os Divisores Primos");
            long numeroEscolhido = Convert.ToInt64(Console.ReadLine());

            CalculadoraServico calculadoraServico = new CalculadoraServico();

            var listDiv = calculadoraServico.CalcularDivisao(numeroEscolhido);

            var listPrimos = calculadoraServico.CalcularPrimos(numeroEscolhido);

            Console.WriteLine("Números divisores = " + listDiv);

            Console.WriteLine("Divisores Primos = " + listPrimos);
            Console.ReadLine();
        }
    }
}
