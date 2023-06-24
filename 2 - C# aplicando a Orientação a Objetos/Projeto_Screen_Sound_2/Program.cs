/*Usar uma classe sem construtor no C# não garante que o objeto seja inicializado corretamente.
Sem um construtor, não há um ponto de entrada definido para configurar o estado inicial do objeto.
Isso pode levar a objetos em um estado inválido ou inconsistente, o que pode resultar em comportamento inesperado ou erros em tempo de execução.*/

Banda queen = new Banda("QUEEN"); // instancia uma banda 

Album albumDoQueen = new Album("A night at the opera"); // instancia um album

Genero rock = new Genero("Rock");

Musica musica1 = new Musica(queen, "Love of my life",rock ) //instancia de uma musica com o parametro exigido (OBRIGATORIOS) pelo construtor da class musica
{
    Duracao = 315,
    Disponivel = true,
};

Musica musica2 = new Musica(queen, "Bohemian Rhapsody", rock)
{  // informações OPCIONAIS
    Duracao = 253,
    Disponivel = true,
};

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

