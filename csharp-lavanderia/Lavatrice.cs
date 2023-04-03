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
        private int statoDetersivo;
        private int statoAmmorbidente;
        private bool inUso = false;
        private int guadagno = 0;

        public override int Id { get; set; }
        public override int Costo { get; set; }
        public override bool InUso { get; set; }
        public override int Durata { get; set; }

        public int MaxCapienzaDetersivo { get { return maxCapienzaDetersivo; } }
        public int MaxCapienzaAmmorbidente { get { return maxCapienzaAmmorbidente;} }
        public int StatoDetersivo { get; set; }
        public int StatoAmmorbidente { get; set; }
        public int ConsumoDetersivo { get; set; }
        public int ConsumoAmmorbidente { get; set; }
        public int Guadagno { get { return guadagno; } set { guadagno += value; } }

        public Lavatrice(int id)
        {
            Id = id;
            StatoAmmorbidente = MaxCapienzaAmmorbidente;
            StatoDetersivo = MaxCapienzaDetersivo;
            InUso = inUso;
            Guadagno += guadagno;
        }

        public override void ToString()
        {
            Console.WriteLine($"Lavatrice {Id}. Stato ammorbidente: {StatoAmmorbidente}, stato detersivo {StatoDetersivo}.In uso {inUso}. Il guadagno è {Guadagno} ");
        }
        public void Rinfrescante()
        {
            Costo = 2;
            Durata = 20;
            ConsumoDetersivo = 20;
            ConsumoAmmorbidente = 5;
        }
        public void Rinnovante()
        {
            Costo = 3;
            Durata = 60;
            ConsumoDetersivo = 40;
            ConsumoAmmorbidente = 5;
        }
        public void Sgrassante()
        {
            Costo = 4;
            Durata = 60;
            ConsumoDetersivo = 60;
            ConsumoAmmorbidente = 15;
        }
        

    }
}
