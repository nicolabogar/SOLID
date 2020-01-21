using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.SOLID.ISP___Interface_Segregation_Principle.Violacao
{
    public interface ICadastro
    {
        bool ValidarDados();
        void PersistirDados();
        void EnviarEmail();
    }
}
