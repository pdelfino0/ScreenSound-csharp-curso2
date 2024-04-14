class Podcast
{
    public Podcast(string nome, string host)
    {
        Nome = nome;
        Host = host;
    }

    private List<Episodio> episodios = new List<Episodio>();
    public string Host { get; }
    public string Nome { get; }

    public int TotalEpisodios => episodios.Count;


    public void AdicionarEpisodio(Episodio episodio)
    {
        episodios.Add(episodio);
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Podcast: {Nome}, apresentado por {Host}");
        Console.WriteLine($"Esse podcast tem {TotalEpisodios} episódios.\n");
        Console.WriteLine("Episódios:");
        foreach (Episodio episodio in episodios)
        {
            Console.WriteLine(episodio.Resumo);
        }
    }
}