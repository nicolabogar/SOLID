using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.SOLID.ISP___Interface_Segregation_Principle
{
    public class Produto : ICadastro
    {
        public void PersistirDados()
        {
            // Persistir Dados
        }

        public void ValidarDados()
        {
            // Validar Dados
        }
    }
}
