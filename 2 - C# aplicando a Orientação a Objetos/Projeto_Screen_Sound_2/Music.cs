//ctrl + shift + a = Cria um novo item no projeto
//Convenção Pascal Case>> Letra maiuscula no inicio
//propriedade >> get|set
//ATALHO >> cw + TAB = Write >> Console.WriteLine();
//ctrl + R + R >> renomeia em all 
////public string Nome - atributossssssss

class Musica 
{   
    public string Nome { get; set; } //propriedade permite ler(get) e escrever(set), em classes externas (public)
    public string Artista { get; set; } 
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    public string DescricaoResumida => $"A música {Nome} pertence a banda {Artista}"; //GET (LAMBDA) >> arrow function (função de seta)
                                                                                        
    public void ExibirFichaTecnica() //Creat a method - "função" (comportamento para os atributos)
    {
        //ATALHO >> cw + TAB = Write >> Console.WriteLine();
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Duração: {Duracao}");
        if (Disponivel) {
            Console.WriteLine("Disponivel no plano.\n");
        }else {
            Console.WriteLine("Adquira o plano Plus+\n");
        }
    }
}
