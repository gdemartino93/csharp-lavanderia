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
        private bool inUso = false;
        private int guadagno = 0;

        public override int Id { get; set; }
        public override bool InUso { get; set; }
        public override int Costo  { get; set; }
        public override int Durata { get; set; }
        public override int Guadagno { get { return guadagno; } set { guadagno += value; } }

        public Asciugatrice(int id)
        {
            Id = id;
            InUso = inUso;
        }
        public override void ToString()
        {
            Console.WriteLine($"Asciugatrice {Id}. In uso {InUso} ");
        }
        public override void Avvia()
        {
            InUso = true;
            Console.WriteLine(Program.Spacer);
            Console.WriteLine("Asciugatrice avviata");
            Console.WriteLine(Program.Spacer);
        }
        public void Rapido()
        {
            Costo = 2;
            Durata = 30;
            Console.WriteLine(Program.Spacer);
            Console.WriteLine("Asciugatura rapida avviata");
            Console.WriteLine(Program.Spacer);
        }
        public void Intenso()
        {
            Costo = 4;
            Durata = 60;
            Console.WriteLine(Program.Spacer);
            Console.WriteLine("Asciugatura intensa avviata");
            Console.WriteLine(Program.Spacer);
        }
        public override int VediGuadagno()
        {
            return Guadagno;
        }
        public override void VisualizzaStato()
        {
            throw new NotImplementedException();
        }
    }
}
