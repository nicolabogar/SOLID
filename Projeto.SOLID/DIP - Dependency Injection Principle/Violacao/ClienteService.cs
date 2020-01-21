using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.SOLID.DIP___Dependency_Injection_Principle.Violacao
{
    public class ClienteService
    {
        public void Incluir(Cliente cliente)
        {
            var repository = new ClienteRepository();

            repository.Inserir(cliente);
        }
    }
}
