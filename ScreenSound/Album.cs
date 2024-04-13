class Album
{
    public Album(string nome)
    {
        Nome = nome;
    }

    private List<Musica> musicas = new List<Musica>();
    public string Nome { get; }
    public int DuracaoTotal => musicas.Sum(m => m.Duracao);

    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }

    public void ExibirMusicas()
    {
        Console.WriteLine($"Músicas do álbum {Nome}:");
        foreach (Musica musica in musicas)
        {
            Console.WriteLine("Música: " + musica.Nome);
        }

        Console.WriteLine($"Para ouvir o álbum inteiro, você levará {DuracaoTotal} segundos.");
    }
}