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
            long valor = 2;
            CalculadoraServico calculadoraServico = new CalculadoraServico();
            calculadoraServico.CalcularDivisao(valor);

        }

        [TestMethod]
        public void TestMethod()
        {
            List<long> valor = new List<long> {1,2,3,4,5 };
            CalculadoraServico calculadoraServico = new CalculadoraServico();
            calculadoraServico.CalcularPrimos(valor);

        }
    }
}
