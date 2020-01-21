using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.SOLID.ISP___Interface_Segregation_Principle
{
    public class Cliente : ICadastroEnvioEmail
    {
        public void EnviarEmail()
        {
            // Enviar email
        }

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
