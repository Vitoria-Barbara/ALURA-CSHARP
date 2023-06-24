class Podcast
{
    private List<Episodio> episodios = new();
    public Podcast(string host, string nome)
    {
        Host = host;
        Nome = nome;  
    }
    
    public string Host { get; }
    public string Nome { get; }
    public int TotalEpisodios => episodios.Count;
   
    public void AdicionarEpsodios(Episodio episodio)
    {
        episodios.Add(episodio);
    }

    public void ExibirDetalhes()
    {
        //Nome e host do podcast
        Console.WriteLine($"Exibindo detalhes do Podcast: ");
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Host: {Host}");
        foreach (Episodio episodio in episodios.OrderBy(e => e.Ordem))
        {
            Console.WriteLine(episodio.Resumo);
        }
        Console.WriteLine($"Este podcast possui: {TotalEpisodios}");
    }

}