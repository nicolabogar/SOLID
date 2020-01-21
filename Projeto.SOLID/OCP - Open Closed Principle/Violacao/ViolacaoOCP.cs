using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.SOLID.OCP___Open_Closed_Principle.Violacao
{
    public class ViolacaoOCP
    {
        public ViolacaoOCP(
            IPoupancaRepository poupancaRepository,
            IContaCorrenteRepository contaCorrenteRepository)
        {
            _poupancaRepository = poupancaRepository;
            _contaCorrenteRepository = contaCorrenteRepository;
        }

        private readonly IContaCorrenteRepository _contaCorrenteRepository;
        private readonly IPoupancaRepository _poupancaRepository;
        
        public enum TipoConta
        {
            Poupanca,
            ContaCorrente
        }

        public enum TipoOperacao
        {
            Creditar,
            Debitar
        }

        public void ExecutarTransacao(string agencia, string numeroConta, decimal valor, TipoConta tipoConta, TipoOperacao tipoOperacao)
        {
            if (tipoConta == TipoConta.ContaCorrente)
            {
                if (tipoOperacao == TipoOperacao.Creditar)
                    _contaCorrenteRepository.Creditar(agencia, numeroConta, valor, 0.20M);
                if (tipoOperacao == TipoOperacao.Debitar)
                    _contaCorrenteRepository.Debitar(agencia, numeroConta, valor, 0.30M);
            }
            else if (tipoConta == TipoConta.Poupanca)
            {
                if (tipoOperacao == TipoOperacao.Creditar)
                    _poupancaRepository.Creditar(agencia, numeroConta, valor, 0.20M);
                if (tipoOperacao == TipoOperacao.Debitar)
                    _poupancaRepository.Debitar(agencia, numeroConta, valor, 0.30M);
            }
        }
    }
}
