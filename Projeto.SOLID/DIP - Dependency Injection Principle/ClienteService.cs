using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.SOLID.DIP___Dependency_Injection_Principle
{
    public class ClienteService : IClienteService
    {
        public ClienteService(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        private readonly IClienteRepository _clienteRepository;

        public void Inserir(Cliente cliente)
        {
            _clienteRepository.Incluir(cliente);
        }
    }
}
