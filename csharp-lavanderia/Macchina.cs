using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_lavanderia
{
    abstract class Macchina
    {
        public abstract int Id { get; set; }
        public abstract bool InUso { get; set; }
        public abstract int Durata { get; set; }
        public abstract int Costo { get; set; }
        public List<Lavatrice> Lavatrici { get; set; }
        public List<Asciugatrice> Asciugatrici { get; set; }

        public virtual void ToString()
        {
            Console.WriteLine("");
        }
        public abstract void Avvia();
        public abstract int VediGuadagno();
        public abstract void VisualizzaStato();
    }
}
