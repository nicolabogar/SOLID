using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.SOLID.OCP___Open_Closed_Principle
{
    public class Poupanca : ContaBase
    {
        public Poupanca(IPoupancaRepository poupancaRepository)
        {
            _popupancaRepository = poupancaRepository;
        }

        private const decimal _valorOperacaoCreditar = 0.20M;
        private const decimal _valorOperacaoDebitar = 0.50M;

        private readonly IPoupancaRepository _popupancaRepository;

        public override void Creditar(string agencia, string numeroConta, decimal valor)
        {
            _popupancaRepository.Creditar(agencia, numeroConta, valor, _valorOperacaoCreditar);
        }

        public override void Debitar(string agencia, string numeroConta, decimal valor)
        {
            _popupancaRepository.Debitar(agencia, numeroConta, valor, _valorOperacaoDebitar);
        }
    }
}
