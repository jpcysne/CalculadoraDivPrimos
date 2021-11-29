using CalculadoraDivPrimos.Servicos.Servico;
using System;
using System.Collections.Generic;

namespace CalculadoraDivPrimos.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Favor colocar um numero para saber os Números divisores e os Divisores Primos");
            long numeroEscolhido = Convert.ToInt64(Console.ReadLine());

            CalculadoraServico calculadoraServico = new CalculadoraServico();

            List<long> listDiv = calculadoraServico.CalcularDivisao(numeroEscolhido);

            var listPrimos = calculadoraServico.CalcularPrimos(listDiv);

            Console.WriteLine("Números divisores = " + string.Join(" ", listDiv));

            Console.WriteLine("Divisores Primos = " + string.Join(" ", listPrimos));

            Console.ReadLine();
        }
    }
}
