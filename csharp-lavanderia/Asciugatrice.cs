using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_lavanderia
{
    internal class Asciugatrice : Macchina
    {
        private int id;
        private List<Programma> programmi;
        private bool inUso;

        public int Id { get; set; }
        public List<Programma> Programmi { get; set; }
        public bool InUso { get; set; }

        public Asciugatrice(int id,List<Programma> programmi) : base(programmi)
        {
            Id = id;
            Programmi = programmi;
            InUso = inUso;
        }
        public override void ToString()
        {
            Console.WriteLine($"Asciugatrice {Id}. In uso {InUso} ");
        }
    }
}
