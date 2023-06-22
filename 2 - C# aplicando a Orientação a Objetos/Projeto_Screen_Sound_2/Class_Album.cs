class Album
{
    private List<Musica> musicas = new List<Musica>();

    //prop 
    public string Nome { get; set; }
    public int DuracaoTotal => musicas.Sum(m => m.Duracao); //soma na lista Musica

    //method >> behavior
    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }

    public void ExibirMusicasDoAlbum()
    {
        Console.WriteLine($"Lista de músicas do álbum {Nome}\n"); //alt + cima = leva para cima...
        foreach (var musica in musicas) ///Para cada música na lista Musica
        {
            Console.WriteLine($"Música: {musica.Nome}");
        }
        Console.WriteLine($"\nPara ouvir este álbum inteiro vôce precisa de: {DuracaoTotal}");
    }
}
