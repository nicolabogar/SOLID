using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.SOLID.OCP___Open_Closed_Principle
{
    public interface IContaBaseRespository
    {
        decimal ObterSaldo(string agencia, string numeroConta);
        decimal Debitar(string agencia, string numeroConta, decimal valor, decimal valorOperacao);
        decimal Creditar(string agencia, string numeroConta, decimal valor, decimal valorOperacao);
    }
}
