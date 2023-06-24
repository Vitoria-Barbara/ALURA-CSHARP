class Album
{
    private List<Musica> musicas = new List<Musica>();

    public Album(string nome)
    {
        Nome = nome;
    }



    //prop 
    public string Nome { get; }
    public int DuracaoTotal => musicas.Sum(m => m.Duracao); //soma na lista Musica

    //method >> behavior
    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }

    public void ExibirMusicasDoAlbum()
    {
        Console.WriteLine($"Lista de músicas do álbum {Nome}"); //alt + cima = leva para cima...
        foreach (var musica in musicas) ///Para cada música na lista Musica
        {
            Console.WriteLine($"Música: {musica.Nome}");
        }
        Console.WriteLine($"Para ouvir este álbum inteiro vôce precisa de: {DuracaoTotal}");
    }
}
