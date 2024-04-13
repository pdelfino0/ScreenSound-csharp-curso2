class Musica
{
    public Musica(Artista artista, string nome)
    {
        Artista = artista;
        Nome = nome;
    }

    public string Nome { get; }
    public Artista Artista { get; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }

    public string DescricaoDetalhada => $"A música {Nome} é do artista {Artista} e tem duração de {Duracao} segundos.";

    public void ExibirFichaTecnica()

    {
        Console.WriteLine($"Ficha técnica da música: {Nome} ");
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista.Nome}");
        Console.WriteLine($"Duração: {Duracao}");
        if (Disponivel)
        {
            Console.WriteLine("Disponível no plano.\n");
        }
        else
        {
            Console.WriteLine("Não disponível no plano.\n");
        }
    }
}