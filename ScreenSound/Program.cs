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