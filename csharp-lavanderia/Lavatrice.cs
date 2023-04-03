using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_lavanderia
{
    internal class Lavatrice : Macchina
    {
        private int maxCapienzaDetersivo = 1000;
        private int maxCapienzaAmmorbidente = 500;
        private List<ProgrammaLavatrice> programmi;
        private int statoDetersivo;
        private int statoAmmorbidente;
        private bool inUso;

        public int MaxCapienzaDetersivo { get; }
        public int MaxCapienzaAmmorbidente { get; }
        public List<ProgrammaLavatrice> Programmi { get; set; }
        public int StatoDetersivo { get; set; }
        public int StatoAmmorbidente { get; set; }
        public bool InUso { get; set; }
        public Lavatrice(List<Programma> programmi, int statoDetersivo, int statoAmmorbidente,bool inUso) : base(programmi,inUso)
        {
            Programmi = new List<ProgrammaLavatrice>();
            StatoAmmorbidente = statoAmmorbidente;
            StatoDetersivo = statoDetersivo;
            InUso = inUso;
        }
    }
}
