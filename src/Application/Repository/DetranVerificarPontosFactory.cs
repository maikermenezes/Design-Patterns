using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternSamples.Application.Repository
{
    public interface DetranVerificarPontosFactory
    {
        public DetranVerificarPontosFactory Register(string UF, Type repository);
        public DetranVerificarPontosFactory Create(string UF);
    }
}
