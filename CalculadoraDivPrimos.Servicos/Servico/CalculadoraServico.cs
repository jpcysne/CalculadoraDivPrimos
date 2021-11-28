using CalculadoraDivPrimos.Servicos.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraDivPrimos.Servicos.Servico
{
    public class CalculadoraServico : ICalculator
    {
        public List<int> CalcularDivisao(int numero)
        {
            List<int> listaDivisao = new List<int>();
            return listaDivisao;
        }

        public List<int> CalcularPrimos(int numero)
        {
            List<int> listaPrimos = new List<int>();
            return listaPrimos;
        }
    }
}
