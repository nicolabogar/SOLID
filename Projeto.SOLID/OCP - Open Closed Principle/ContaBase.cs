using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.SOLID.OCP___Open_Closed_Principle
{
    public abstract class ContaBase
    {
        public ContaBase()
        {
            
        }

        public abstract void Debitar(string agencia, string numeroConta, decimal valor);

        public abstract void Creditar(string agencia, string numeroConta, decimal valor);
    }
}
