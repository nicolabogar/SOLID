using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.SOLID.SRP___Single_Responsability.ViolacaoSRP
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }

        public void PersistirCliente()
        {
            //Persistir cliente no banco de dados
        }

        public void EnviarEmail()
        {
            //Todo codigo para relaizar o envio de emails
        }

        public void ValidarCPF()
        {
            if (this.CPF.Length != 11)
                throw new Exception("CPF Inválido.");
        }
    }
}
