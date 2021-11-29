using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraDivPrimos.Servicos.Interface
{
    public interface ICalculator
    {
        List<long> CalcularDivisao(long numero);

        List<long> CalcularPrimos(List<long> numeros);
    }
}
