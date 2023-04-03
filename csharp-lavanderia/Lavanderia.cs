using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_lavanderia
{
    internal class Lavanderia
    {
        private string nome;

        public string Nome { get; set; }

        public Lavanderia(string nome)
        {
            Nome = nome;
        }
    }
}
