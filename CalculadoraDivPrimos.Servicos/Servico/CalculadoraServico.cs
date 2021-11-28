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
        public List<long> CalcularDivisao(long numero)
        {
            List<long> listaDivisao = new List<long>();

            for(int i = 2; i<= numero/2; i++)
            {
                if ( numero % i == 0)
                {
                    listaDivisao.Add(i);
                }
            }

            listaDivisao.Add(1);
            listaDivisao.Add(numero);

            return listaDivisao;
        }

        public List<long> CalcularPrimos(long numero)
        {
            List<long> listaPrimos = new List<long>();

            for (int i = 1; i <= numero; i++)
            {
                if (numero % i == 0)
                {
                    listaPrimos.Add(i);
                }
            }

            return listaPrimos;
        }
    }
}
