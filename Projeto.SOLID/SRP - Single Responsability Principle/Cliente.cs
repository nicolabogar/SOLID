using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.SOLID.SRP___Single_Responsability
{
    /* Cada classe deve ter sua responsabilidade - Cliente, ClienteRepository, EmailService, Validacao */
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }

        public void EnviarEmail()
        {
            EmailService.Enviar();
        }

        public void ValidarCliente()
        {
            ValidacaoService.ValidarCPF(this.CPF);
        }
    }
}
