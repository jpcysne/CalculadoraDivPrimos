using CalculadoraDivPrimos.Servicos.Servico;
using CalculadoraDivPrimos.Servicos.Validacao;
using System;
using System.Collections.Generic;

namespace CalculadoraDivPrimos.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculadoraServico calculadoraServico = new CalculadoraServico();
            ValidacaoCalculadora validacaoCalculadora = new ValidacaoCalculadora();

            Console.WriteLine("Favor colocar um numero para saber os Números divisores e os Divisores Primos");

            string caractereEscolhido = Console.ReadLine();
            
            bool validacao = validacaoCalculadora.CheckSeENumero(caractereEscolhido);

            if (validacao)
            {
                long numeroEscolhido = Convert.ToInt64(Console.ReadLine());

                List<long> listDiv = calculadoraServico.CalcularDivisao(numeroEscolhido);

                var listPrimos = calculadoraServico.CalcularPrimos(listDiv);

                Console.WriteLine("Número de Entrada = " + numeroEscolhido);

                Console.WriteLine("Números divisores = " + string.Join(" ", listDiv));

                Console.WriteLine("Divisores Primos = " + string.Join(" ", listPrimos));

                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Não é um Numero");

                Console.ReadLine();
            }
            
        }
    }
}
