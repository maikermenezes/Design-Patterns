using DesignPatternSamples.Application.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSamples.Application.Repository
{
    public interface DetranVerificarPontosRepository
    {
        Task<IEnumerable<Carteira>> ConsultarDebitos(Carteira carteira);
    }
}
