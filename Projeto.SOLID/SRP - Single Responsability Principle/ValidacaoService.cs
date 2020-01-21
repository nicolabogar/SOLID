using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.SOLID.SRP___Single_Responsability
{
    public static class ValidacaoService
    {
        public static void ValidarCPF(string cpf)
        {
            if (cpf.Length != 11)
                throw new Exception("Número de CPF é inválido.");
        }
    }
}
