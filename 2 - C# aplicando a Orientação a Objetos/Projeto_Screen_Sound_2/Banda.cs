class Banda
{
    private List<Album> albums = new List<Album>();

    public Banda(string nome)
    {
        Nome = nome;
    }

    public string Nome { get;} //com retorno
    public void AdcionarAlbum(Album album) //um método sem retorno que recebe a classe Album como argumento {parametro} de entrada
    {
        albums.Add(album);
    }
    public void ExibirDiscografia() // void = sem retorno
    {
        Console.WriteLine($"Discografia da Banda: {Nome}");
        foreach(Album album in albums)
        {
            Console.WriteLine($"Álbum: {album.Nome} ({album.DuracaoTotal})\n ");
        }
    }
}