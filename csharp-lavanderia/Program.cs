namespace csharp_lavanderia
{
    internal class Program
    {
        public const double gettone = 0.50;
        static void Main(string[] args)
        {
            List<Programma> programmiLavatrice = new List<Programma>()
        {
            new ProgrammaLavatrice("Rinfrescante",2,20,20,5),
            new ProgrammaLavatrice("Rinnovante",3,40,40,10),
            new ProgrammaLavatrice("Sgrassante",4,60,60,15)
        };
            List<Programma> programmiAsciugatrici = new List<Programma>()
            {
                new ProgrammaAsciugatrice("Rapido",2,30),
                new ProgrammaAsciugatrice("Intenso",4,60)
            };
            List<Macchina> macchine = new List<Macchina>
            {
                new Lavatrice(1,programmiLavatrice),
                new Lavatrice(2,programmiLavatrice),
                new Lavatrice(3,programmiLavatrice),
                new Lavatrice(4,programmiLavatrice),
                new Lavatrice(5, programmiLavatrice),
                new Asciugatrice(1,programmiAsciugatrici),
                new Asciugatrice(2,programmiAsciugatrici),
                new Asciugatrice(3,programmiAsciugatrici),
                new Asciugatrice(4,programmiAsciugatrici),
                new Asciugatrice(5,programmiAsciugatrici),
        };
   

        }
    }
}