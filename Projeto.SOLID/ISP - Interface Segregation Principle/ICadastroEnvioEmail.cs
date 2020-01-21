using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.SOLID.ISP___Interface_Segregation_Principle
{
    public interface ICadastroEnvioEmail : ICadastro
    {
        void EnviarEmail();
    }
}
