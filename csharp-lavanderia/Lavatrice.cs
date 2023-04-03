using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_lavanderia
{
    internal class Lavatrice : Macchina
    {
        private int id;
        private int maxCapienzaDetersivo = 1000;
        private int maxCapienzaAmmorbidente = 500;
        private List<ProgrammaLavatrice> programmi;
        private int statoDetersivo;
        private int statoAmmorbidente;
        private bool inUso = false;
        private int guadagno = 0;

        public int Id { get; set; }
        public int MaxCapienzaDetersivo { get { return maxCapienzaDetersivo; } }
        public int MaxCapienzaAmmorbidente { get { return maxCapienzaAmmorbidente;} }
        public List<ProgrammaLavatrice> Programmi { get; set; }
        public int StatoDetersivo { get; set; }
        public int StatoAmmorbidente { get; set; }
        public bool InUso { get { return inUso; } set { inUso = value; } }
        public int Guadagno { get { return guadagno; } set { guadagno += value; } }

        public Lavatrice(int id,List<Programma> programmi) : base(programmi)
        {
            Id = id;
            Programmi = new List<ProgrammaLavatrice>();
            StatoAmmorbidente = MaxCapienzaAmmorbidente;
            StatoDetersivo = MaxCapienzaDetersivo;
            InUso = inUso;
            Guadagno += guadagno;

        }

        public override void ToString()
        {
            Console.WriteLine($"Lavatrice {Id}. Stato ammorbidente: {StatoAmmorbidente}, stato detersivo {StatoDetersivo}.In uso {inUso}. Il guadagno è {Guadagno} ");
        }
    }
}
