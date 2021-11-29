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

            for(int i = 1; i<= numero/2; i++)
            {
                if ( numero % i == 0)
                {
                    listaDivisao.Add(i);
                }
            }

            listaDivisao.Add(numero);

            return listaDivisao;
        }

        public List<long> CalcularPrimos(List<long> numeros)
        {
            List<long> listaPrimos = new List<long>();

            for (int contList = 0; contList < numeros.Count; contList++)
            {
                int countPrimos = 0;

                if(numeros[contList] == 1)
                {
                    listaPrimos.Add(numeros[contList]);
                }
                else
                {
                    for (int i = 1; i <= numeros[contList]; i++)
                    {
                        if (numeros[contList] % i == 0)
                        {
                            countPrimos++;
                        }
                    }

                    if (countPrimos == 2)
                    {
                        listaPrimos.Add(numeros[contList]);
                    }
                }
            }
            return listaPrimos;
        }
    }
}
