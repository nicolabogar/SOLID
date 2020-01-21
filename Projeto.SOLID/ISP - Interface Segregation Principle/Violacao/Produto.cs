using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.SOLID.ISP___Interface_Segregation_Principle.Violacao
{
    public class Produto : ICadastro
    {
        public int Id { get; set; }
        public string Descricao { get; set; }

        public void EnviarEmail()
        {
            // Produto não tem email para ser enviado.
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
