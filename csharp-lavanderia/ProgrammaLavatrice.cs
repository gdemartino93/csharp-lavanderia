using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_lavanderia
{
    internal class ProgrammaLavatrice : Programma
    {
        private int consumoDetersivo;
        private int consumoAmmorbidente;

        public int ConsumoDetersivo { get; set; }
        public int ConsumoAmmorbidente { get; set; }

        public ProgrammaLavatrice(string nome,int costo, int durata, int consumoDetersivo,int consumoAmmorbidente):base(nome,costo,durata)
        {
            Nome = nome;
            Costo = costo;
            Durata = durata;
            ConsumoDetersivo = consumoDetersivo;
            ConsumoAmmorbidente = consumoAmmorbidente;
        }

        public void ToString()
        {
            Console.WriteLine($"Programma {Nome}, Costo: {Costo}, Durata: {Durata}, Consumo Detersivo: {ConsumoDetersivo}, Consumo Ammorbidente: {consumoAmmorbidente}");
        }
    }
}
