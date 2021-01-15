using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSamples.Application.DTO
{
    [Serializable]
    public class Carteira
    {
        public string Placa { get; set; }
        public string CPF { get; set; }
        public string UF { get; internal set; }
    }
}
