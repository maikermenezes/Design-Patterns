using DesignPatternSamples.Application.DTO;
using DesignPatternSamples.Application.Repository;
using DesignPatternSamples.Application.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DesignPatternSamples.Application.Implementations
{
    public class DetranVerificarPontos : VerificarPontos
    {
        private readonly IDetranVerificadorDebitosFactory _Factory;

        public DetranVerificarPontos(IDetranVerificadorDebitosFactory factory)
        {
            _Factory = factory;
        }

        public Task<IEnumerable<Carteira>> ConsultarDebitos(Carteira carteira)
        {
            DetranVerificarPontosRepository repository = (DetranVerificarPontosRepository)_Factory.Create(carteira.UF);
            return repository.ConsultarDebitos(carteira);
        }

        public Task<IEnumerable<Carteira>> Verificar(Carteira carteira)
        {
            throw new System.NotImplementedException();
        }
    }
}
