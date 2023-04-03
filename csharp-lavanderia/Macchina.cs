using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_lavanderia
{
    abstract class Macchina
    {
        private List<Programma> programmi;
        private bool inUso = false;
        private int guadagno;
        public List<Programma> Programmi { get; set; }
        public bool InUso { get; set; }
        public int Guadagno { get; set; }

        public Macchina(List<Programma> programmi)
        {
            Programmi = programmi;
            InUso = inUso;
            Guadagno = guadagno;
        }
        public virtual void ToString()
        {
            Console.WriteLine("asdsad");
        }
    }
}
