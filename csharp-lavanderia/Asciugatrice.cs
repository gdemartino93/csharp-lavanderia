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
        private bool inUso;

        public override int Id { get; set; }
        public override bool InUso { get; set; }
        public override int Costo  { get; set; }
        public override int Durata { get; set; }

        public Asciugatrice(int id)
        {
            Id = id;
            InUso = inUso;
        }
        public override void ToString()
        {
            Console.WriteLine($"Asciugatrice {Id}. In uso {InUso} ");
        }
    }
}
