using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculadoraDivPrimoAPI.Model
{
    public class ModelCalculadora
    {
        public long NumeroDeEntrada { get; set; }
        public List<long> NumerosDivisores { get; set; }

        public List<long> DivisoresPrimos { get ; set ; }
    }
}
