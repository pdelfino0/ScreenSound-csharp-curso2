Album albumDoDrake = new Album();
albumDoDrake.Nome = "Certified Lover Boy";
Musica musica1 = new Musica();
musica1.Nome = "Champagne Poetry";
musica1.Duracao = 260;

Musica musica2 = new Musica();
musica2.Nome = "Papi's Home";
musica2.Duracao = 300;

albumDoDrake.AdicionarMusica(musica1);
albumDoDrake.AdicionarMusica(musica2);

albumDoDrake.ExibirMusicas();