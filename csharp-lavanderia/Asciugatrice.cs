using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_lavanderia
{
    internal class Asciugatrice : Macchina
    {
        private List<Programma> programmi;
        private bool inUso;

        public List<Programma> Programmi { get; set; }
        public bool InUso { get; set; }

        public Asciugatrice(List<Programma> programmi,bool inUso) : base(programmi, inUso)
        {
            Programmi = programmi;
            InUso = inUso;
        }
    }
}
