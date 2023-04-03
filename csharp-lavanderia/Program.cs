﻿namespace csharp_lavanderia
{
    internal class Program
    {
        public const double Gettone = 0.50;
        public const string Spacer = "@-----------------------------------------------@";
        static void Main(string[] args)
        {
            Console.WriteLine("Benvenuto nella lavenderia");
            Console.WriteLine("Scegli un opzione?");
            Console.WriteLine("[1]Usa una Lavatrice");
            Console.WriteLine("[2]Usa un' Asciugatrice");
            Console.WriteLine("[3]Ottieni lo stato di tutte le lavatrici");
            Console.WriteLine("[4]Ottieni lo stato di tutte le asciugatrici");
            int scelta = Convert.ToInt32(Console.ReadLine());

            Lavanderia sharpLavanderia = new Lavanderia();
            sharpLavanderia.OttieniLavatrici();
            sharpLavanderia.OttieniAsciugatrici();
            switch (scelta)
            {
                case 1:
                    if (sharpLavanderia.UsaLavatrice() == null)
                    {
                        Console.WriteLine("Nessuna lavatrice libera");
                    };
                    break;
                case 2:
                    if(sharpLavanderia.UsaAsciugatrice() == null)
                    {
                        Console.WriteLine("Nessuna asciugatrice libera");
                    };
                    break;
            }

        }
    }
}