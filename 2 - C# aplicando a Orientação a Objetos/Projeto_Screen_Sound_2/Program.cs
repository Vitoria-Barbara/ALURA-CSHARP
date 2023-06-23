Banda queen = new Banda("QUEEN"); // instancia uma banda 

Album albumDoQueen = new Album("A night at the opera"); // instancia um album

Musica musica1 = new Musica(queen, "Love of my life") //instancia de uma musica com o parametro exigido (OBRIGATORIOS) pelo construtor da class musica
{
    Duracao = 315,
    Disponivel = true,
};
musica1.Duracao = 213; //segundos

Musica musica2 = new Musica(queen, "Bohemian Rhapsody")
{  // informações OPCIONAIS
    Duracao = 253,
    Disponivel = true,
};


Genero genero = new Genero();
genero.Nome = "GGGGGGGG";

//relacinadores
queen.AdcionarAlbum(albumDoQueen); // chama o metodo que add um album x na banda y
albumDoQueen.AdicionarMusica(musica1); // add musica1 no album x
albumDoQueen.AdicionarMusica(musica2); //  ''

//exibição
musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();
queen.ExibirDiscografia(); // chama o metodo que exibe a discografia da banda 
albumDoQueen.ExibirMusicasDoAlbum(); // chama o metodo que exibe a musica do album

Console.ReadKey();

