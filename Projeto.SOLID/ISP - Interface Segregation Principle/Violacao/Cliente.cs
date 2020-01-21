using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.SOLID.ISP___Interface_Segregation_Principle.Violacao
{
    public class Cliente : ICadastro
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }

        public void EnviarEmail()
        {
            // Enviar email assim que cadastro for concluido
        }

        public void PersistirDados()
        {
            // Persistir Dados
        }

        public bool ValidarDados()
        {
            // Validar Dados

            return true;
        }
    }
}
