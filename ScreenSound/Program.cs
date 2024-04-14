Artista artista = new Artista("Drake");
Album albumDoDrake = new Album("Certified Lover Boy");

Musica musica1 = new Musica(artista, "Champagne Poetry")
{
    Duracao = 250,
    Disponivel = true
};


Musica musica2 = new Musica(artista, "Papi's Home")
{
    Duracao = 300,
    Disponivel = false
};

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();

albumDoDrake.AdicionarMusica(musica1);
albumDoDrake.AdicionarMusica(musica2);
artista.AdicionarAlbum(albumDoDrake);

artista.ExibirDiscografia();

Console.WriteLine("\n\n");
Podcast podcast = new Podcast("DelfinoCast", "Delfino");

Episodio episodio1 = new Episodio(60, 1, "Delfino convida o Drake para o podcast");
episodio1.AdicionarConvidado("Drake");
Episodio episodio2 = new Episodio(60, 2, "Delfino convida o Kanye West para o podcast");
episodio2.AdicionarConvidado("Kanye West");

podcast.AdicionarEpisodio(episodio1);
podcast.AdicionarEpisodio(episodio2);

podcast.ExibirDetalhes();