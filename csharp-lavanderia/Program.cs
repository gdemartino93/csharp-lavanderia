﻿namespace csharp_lavanderia
{
    internal class Program
    {
        public const double Gettone = 0.50;
        static void Main(string[] args)
        {
            string spacer = "@-----------------------------------------------@";
            List<Macchina> macchine = new List<Macchina>
            {
                new Lavatrice(1),
                new Lavatrice(2),
                new Lavatrice(3),
                new Lavatrice(4),
                new Lavatrice(5),
                new Asciugatrice(1),
                new Asciugatrice(2),
                new Asciugatrice(3),
                new Asciugatrice(4),
                new Asciugatrice(5),
        };
            Console.WriteLine("Benvenuto nella lavenderia");
            Console.WriteLine("Cosa vuoi usare?");
            Console.WriteLine("[1]Lavatrice [2]Asciugatrice");
            int scelta = Convert.ToInt32(Console.ReadLine());
            Macchina macchinaScelta = null;
            if(scelta == 1)
            {
                foreach (Macchina macchina in macchine)
                {
                    if (macchina.InUso == false && macchina is Lavatrice)
                    {
                        //prendiamo la macchina libera
                        macchinaScelta = macchina;
                        macchina.Avvia();
                        Console.WriteLine("Scegli il programma");
                        break;

                    }
                    else
                    {
                        Console.WriteLine("Nessuna lavatrice libera");
                        break;
                    }
                }
        
            }
            if (scelta == 2)
            {
                foreach (Macchina macchina in macchine)
                {
                    if (macchina.InUso == false && macchina is Asciugatrice)
                    {
                        macchinaScelta = macchina;
                        macchina.Avvia();
                        Console.WriteLine("Scegli il programma");
                        break;
                    }
                }

                if (macchinaScelta == null)
                {
                    Console.WriteLine("Nessuna asciugatrice libera");
                    return;
                }
            }

            if (macchinaScelta is Lavatrice && macchinaScelta != null)
            {
                Console.WriteLine("[1] Rinfrescante");
                Console.WriteLine("[2] Rinnovante");
                Console.WriteLine("[3] Sgrassante");
                scelta = Convert.ToInt32(Console.ReadLine());
            }
            if(macchinaScelta is Asciugatrice && macchinaScelta != null)
            {
                Console.WriteLine("[1]Rapido");
                Console.WriteLine("[2]Intenso");
                scelta = Convert.ToInt32(Console.ReadLine());
            }

        }
    }
}