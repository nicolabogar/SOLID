using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.SOLID.OCP___Open_Closed_Principle
{
    public class ContaCorrente : ContaBase
    {
        public ContaCorrente(IContaCorrenteRepository contaCorrenteRepository)
        {
            _contaCorrenteRepository = contaCorrenteRepository;
        }

        private const decimal _valorOperacaoCreditar = 0.10M;
        private const decimal _valorOperacaoDebitar = 0.30M;

        private readonly IContaCorrenteRepository _contaCorrenteRepository;

        public override void Creditar(string agencia, string numeroConta, decimal valor)
        {
            _contaCorrenteRepository.Creditar(agencia, numeroConta, valor, _valorOperacaoCreditar);
        }

        public override void Debitar(string agencia, string numeroConta, decimal valor)
        {
            _contaCorrenteRepository.Debitar(agencia, numeroConta, valor, _valorOperacaoDebitar);
        }
    }
}
