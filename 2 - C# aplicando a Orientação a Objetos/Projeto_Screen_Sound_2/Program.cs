Musica musica1 = new Musica(); // Criação de um objeto do tipo música
musica1.nome = "Roxane";
musica1.artista = "The Police";
musica1.duracao = 254;    
musica1.disponivel = true; 

Musica musica2 = new Musica();
musica2.nome = "Vertigo";
musica2.artista = "U2";
musica2.duracao = 367;
musica2.disponivel = false;

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();

/*
Console.WriteLine($"Nome: {musica2.nome}");
Console.WriteLine($"Artista: {musica2.artista}");
*/