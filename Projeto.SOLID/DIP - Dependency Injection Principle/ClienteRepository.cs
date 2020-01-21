using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.SOLID.DIP___Dependency_Injection_Principle
{
    public class ClienteRepository : IClienteRepository
    {
        public void Incluir(Cliente cliente)
        {
            // Persistir Cliente
        }
    }
}
