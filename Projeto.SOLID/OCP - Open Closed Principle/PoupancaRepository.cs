using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.SOLID.OCP___Open_Closed_Principle
{
    public class PoupancaRepository : IPoupancaRepository
    {
        public decimal _saldoAtual = 800;

        public decimal Creditar(string agencia, string numeroConta, decimal valor, decimal valorOperacao)
        {
            var saldo = ObterSaldo(agencia, numeroConta);

            _saldoAtual = (saldo + valor) - valorOperacao;

            return _saldoAtual;
        }

        public decimal Debitar(string agencia, string numeroConta, decimal valor, decimal valorOperacao)
        {
            var saldo = ObterSaldo(agencia, numeroConta);

            _saldoAtual = (saldo - valor) - valorOperacao;

            return _saldoAtual;
        }

        public decimal ObterSaldo(string agencia, string numeroConta)
        {
            return _saldoAtual;
        }
    }
}
