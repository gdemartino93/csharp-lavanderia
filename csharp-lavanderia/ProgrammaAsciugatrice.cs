using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_lavanderia
{
    internal class ProgrammaAsciugatrice : Programma
    {
        private string nome;
        private int costo;
        private int durata;

        public string Nome { get; set; }
        public int Costo { get; set; }
        public int Durata { get; set; }

        public ProgrammaAsciugatrice(string nome,int costo,int durata) : base(nome, costo, durata)
        {
            Nome = nome;
            Costo = costo;
            Durata = durata;
        }

        ProgrammaAsciugatrice forzamilan = new ProgrammaAsciugatrice("lavatrice", 1, 10);
    }
}
