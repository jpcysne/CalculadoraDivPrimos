using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraDivPrimos.Servicos.Validacao
{
    public class ValidacaoCalculadora
    {
        public bool CheckSeENumero(string caractereEscolhido)
        {
            if (IsNotNull(caractereEscolhido))
            {
                return true;
            }
            else
            {
                if (IsNumber(caractereEscolhido))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public bool IsNumber(string numeroEscolhido)
        {
           
            if (long.TryParse(numeroEscolhido, out long numero))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsNotNull(string numeroEscolhido)
        {

            if (numeroEscolhido == null || numeroEscolhido == " ")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
