using csharp_lavanderia;

internal class Lavanderia
{
    public string Name { get; set; }
    public List<Asciugatrice> Asciugatrici { get; set; }
    public List<Lavatrice> Lavatrici { get; set; }

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

    public Lavanderia()
    {
        Lavatrici = new List<Lavatrice>();
        Asciugatrici = new List<Asciugatrice>();
    }
    public void StatoMacchine()
    {
        foreach (Macchina macchina in macchine)
        {
            macchina.ToString();
        }
    }
    public List<Lavatrice> OttieniLavatrici()
    {
        foreach (Macchina macchina in macchine)
        {
            if (macchina is Lavatrice)
            {
                Lavatrici.Add((Lavatrice)macchina);
            }
        }
        return Lavatrici;
    }

    public List<Asciugatrice> OttieniAsciugatrici()
    {
        foreach (Macchina macchina in macchine)
        {
            if (macchina is Asciugatrice)
            {
                Asciugatrici.Add((Asciugatrice)macchina);
            }
        }
        return Asciugatrici;
    }
    public Lavatrice UsaLavatrice()
    {
        foreach (Lavatrice lavatrice in Lavatrici)
        {
            if (lavatrice.InUso == false)
            {
                lavatrice.InUso = true;
                lavatrice.Avvia();
                return lavatrice;
            }
        }
        return null;
    }
    public Asciugatrice UsaAsciugatrice()
    {
        foreach(Asciugatrice asciugatrice in Asciugatrici)
        {
            if(asciugatrice.InUso == false)
            {
                asciugatrice.InUso = true;
                asciugatrice.Avvia();
                return asciugatrice;
            }
        }
        return null;
    }
}
