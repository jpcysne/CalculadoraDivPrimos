using CalculadoraDivPrimos.Servicos.Servico;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace CalculadoraDivPrimosTeste
{
    [TestClass]
    public class CalculadoraUnitTest
    {
        [TestMethod]
        public void TestMethodCalcularDivisao()
        {
            long valor = 45;
            CalculadoraServico calculadoraServico = new CalculadoraServico();
            List<long> valorteste = new List<long>() { 1, 3, 5, 9, 15, 45 };

            List<long> valorDivisao = calculadoraServico.CalcularDivisao(valor);

            CollectionAssert.AreEquivalent(valorteste, valorDivisao);
            
        }

        [TestMethod]
        public void TestMethodCalcularPrimos()
        {
            List<long> valorteste = new List<long>() { 1, 3, 5, 9, 15, 45 };

            List<long> valorResultado = new List<long>() { 1, 3, 5};

            CalculadoraServico calculadoraServico = new CalculadoraServico();
            List<long> valorPrimos = calculadoraServico.CalcularPrimos(valorteste);

            CollectionAssert.AreEquivalent(valorResultado, valorPrimos);

        }
    }
}
