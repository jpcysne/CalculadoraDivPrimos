using CalculadoraDivPrimoAPI.Model;
using CalculadoraDivPrimos.Servicos.Servico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculadoraDivPrimoAPI.Service
{
    public class CalculadoraService
    {
        public ModelCalculadora CalculadoraAPIService(long numeroEscolhido)
        {
            CalculadoraServico calculadoraServico = new CalculadoraServico();

            List<long> listDiv = calculadoraServico.CalcularDivisao(numeroEscolhido);

            List<long> listPrimos = calculadoraServico.CalcularPrimos(listDiv);

            ModelCalculadora listaDivPrimos = new ModelCalculadora
            {
                NumeroDeEntrada = numeroEscolhido,
                DivisoresPrimos = listDiv,
                NumerosDivisores = listDiv
            };

            return listaDivPrimos;
        }
    }
}
