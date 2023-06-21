Musica musica1 = new Musica(); // Criação de um objeto do tipo música
musica1.Nome = "Roxane";
musica1.Artista = "The Police";
musica1.Duracao = 254;
musica1.Disponivel = true;
Console.WriteLine(musica1.Disponivel);
Console.WriteLine(musica1.DescricaoResumida);
//musica1.EscreveDisponivel(true);
//Console.WriteLine(musica1.LerDisponivel());

Musica musica2 = new Musica();
musica2.Nome = "Vertigo";
musica2.Artista = "U2";
musica2.Duracao = 367;
musica2.Disponivel = false;
Console.WriteLine(musica2.Disponivel);
//musica2.EscreveDisponivel(true);
//Console.WriteLine(musica1.LerDisponivel());

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();

/*
Console.WriteLine($"Nome: {musica2.nome}");
Console.WriteLine($"Artista: {musica2.artista}");
*/