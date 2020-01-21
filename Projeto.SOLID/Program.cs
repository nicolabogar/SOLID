using System;

namespace Projeto.SOLID
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Principios SOLID");

            Single_Responsability();
            OpenClosedPrinciple();
            PrincipleLiskov();
        }

        private static void PrincipleLiskov()
        {
            LSPCorreto();
        }

        private static void LSPCorreto()
        {
            ExecutarCachorro(new LSP___Principle_Liskov.PastorAlemao());
            ExecutarCachorro(new LSP___Principle_Liskov.HuskSiberiano());
        }

        private static void ExecutarCachorro(LSP___Principle_Liskov.Cachorro cachorro)
        {
            cachorro.Latir();
            cachorro.Comer();
            cachorro.Correr();
            cachorro.BeberAgua();
        }

        private static void OpenClosedPrinciple()
        {
            OCPViolacao();
            OCPCorreto();
        }

        private static void Single_Responsability()
        {
            SRPViolacao();
            SRPCorreto();
        }

        private static void OCPCorreto()
        {
            var contaCorrente = new OCP___Open_Closed_Principle.ContaCorrente(
                new OCP___Open_Closed_Principle.ContaCorrenteRespository());

            contaCorrente.Debitar("0001", "123456", 200);
            contaCorrente.Creditar("0001", "123456", 300);

            var poupanca = new OCP___Open_Closed_Principle.Poupanca(
                new OCP___Open_Closed_Principle.PoupancaRepository());

            poupanca.Debitar("0001", "123456", 200);
            poupanca.Creditar("0001", "123456", 300);

        }

        private static void OCPViolacao()
        {
            var transacao = new OCP___Open_Closed_Principle.Violacao.ViolacaoOCP(
                new OCP___Open_Closed_Principle.PoupancaRepository(), 
                new OCP___Open_Closed_Principle.ContaCorrenteRespository());

            transacao.ExecutarTransacao("0001", "123456", 200, 
                OCP___Open_Closed_Principle.Violacao.ViolacaoOCP.TipoConta.ContaCorrente, 
                OCP___Open_Closed_Principle.Violacao.ViolacaoOCP.TipoOperacao.Creditar);

            transacao.ExecutarTransacao("0001", "123456", 300,
                OCP___Open_Closed_Principle.Violacao.ViolacaoOCP.TipoConta.ContaCorrente,
                OCP___Open_Closed_Principle.Violacao.ViolacaoOCP.TipoOperacao.Debitar);
        }

        private static void SRPCorreto()
        {
            Console.WriteLine("SRP Correto");

            var cliente = new SRP___Single_Responsability.Cliente();

            var repository = new SRP___Single_Responsability.ClienteRepository();

            repository.Inserir(cliente);

            cliente.ValidarCliente();
            cliente.EnviarEmail();

            repository.Atualizar(cliente);
        }

        private static void SRPViolacao()
        {
            Console.WriteLine("SRP Violação");

            var cliente = new SRP___Single_Responsability.ViolacaoSRP.Cliente();

            cliente.PersistirCliente();
            cliente.EnviarEmail();
            cliente.ValidarCPF();
        }
    }
}
