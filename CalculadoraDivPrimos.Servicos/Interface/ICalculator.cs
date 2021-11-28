using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraDivPrimos.Servicos.Interface
{
    public interface ICalculator
    {
        List<int> CalcularDivisao(int numero);

        List<int> CalcularPrimos(int numero);
    }
}
