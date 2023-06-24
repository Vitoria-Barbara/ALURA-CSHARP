//ctrl + shift + a = Cria um novo item no projeto
//Convenção Pascal Case>> Letra maiuscula no inicio
//propriedade >> get|set
//ATALHO >> cw + TAB = Write >> Console.WriteLine();
//ctrl + R + R >> renomeia em all 
////public string Nome - atributossssssss
///CTRL + ARQUIVO Q QUER  >> VAI PRO OUTRO ARQUIVO
///ATALHO CRIAR CONSTRUTOR > ctor + TAB
class Musica
{
    public Musica(Banda artista, string nome, Genero genero)  // quando chamar no Program, a classe Musica, vai ter que dizer o artista.
                                               // nao vai conseguir instanciar uma musica sem passar o parametro banda.
    {
        Artista = artista; ;//a propriedade artista recebe o argumento da clase Musica com agumento class Banda que recebe artista.
        Nome = nome;
        Genero = genero;
    }
    public string Nome { get;} //propriedade permite ler(get) e escrever(set), em classes externas (public)
    public Banda Artista { get; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    public string DescricaoResumida => $"A música {Nome} pertence a banda {Artista}"; //GET (LAMBDA) >> arrow function (função de seta)
    public Genero Genero { get; }
    public void ExibirFichaTecnica() //Creat a method - "função" (comportamento para os atributos)
    {
        //ATALHO >> cw + TAB = Write >> Console.WriteLine();
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista.Nome}");
        Console.WriteLine($"Duração: {Duracao}");
        Console.WriteLine($"Genero: {Genero.Nome}");
        if (Disponivel)
        {
            Console.WriteLine("Disponivel no plano.\n");
        }
        else
        {
            Console.WriteLine("Adquira o plano Plus+\n");
        }
    }
}
