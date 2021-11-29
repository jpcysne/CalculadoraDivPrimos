using CalculadoraDivPrimoAPI.Model;
using CalculadoraDivPrimos.Servicos.Servico;
using CalculadoraDivPrimos.Servicos.Validacao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculadoraDivPrimoAPI.Service
{
    public class CalculadoraService
    {
        public ModelCalculadora CalculadoraAPIService(string caractereEscolhido)
        {
            CalculadoraServico calculadoraServico = new CalculadoraServico();
            ValidacaoCalculadora validacaoCalculadora = new ValidacaoCalculadora();

            bool validacao = validacaoCalculadora.CheckSeENumero(caractereEscolhido);

            if (validacao)
            {
                long numeroEscolhido = Convert.ToInt64(caractereEscolhido);

                List<long> listDiv = calculadoraServico.CalcularDivisao(numeroEscolhido);

                List<long> listPrimos = calculadoraServico.CalcularPrimos(listDiv);

                ModelCalculadora listaDivPrimos = new ModelCalculadora
                {
                    NumeroDeEntrada = numeroEscolhido,
                    NumerosDivisores = listDiv,
                    DivisoresPrimos = listPrimos,
                   
                };

                return listaDivPrimos;
            }
            else
            {
                throw new Exception();
            }

            
        }
    }
}
