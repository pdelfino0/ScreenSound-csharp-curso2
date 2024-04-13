class Artista
{
    public Artista(string nome)
    {
        Nome = nome;
    }

    private List<Album> discografia = new List<Album>();
    public string Nome { get; }

    public void AdicionarAlbum(Album album)
    {
        discografia.Add(album);
    }

    public void ExibirDiscografia()
    {
        Console.WriteLine($"Discografia do artista {Nome}:");
        foreach (Album album in discografia)
        {
            Console.WriteLine($"Álbum:  {album.Nome} ({album.DuracaoTotal} segundos)");
        }
    }
}