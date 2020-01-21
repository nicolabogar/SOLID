using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.SOLID.LSP___Principle_Liskov
{
    public abstract class Cachorro
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        
        public virtual string Latir()
        {
            return "Au Au Au";
        }

        public virtual void Correr()
        {

        }

        public virtual void Comer()
        {

        }

        public virtual void BeberAgua()
        {

        }
    }
}
