using DesignPatternSamples.Application.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSamples.Application.Services
{
    class VerificarPontos
    {
      public Task<IEnumerable<Carteira>> Verificar(Carteira carteira);
    }
}
