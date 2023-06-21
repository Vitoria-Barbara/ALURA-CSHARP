class Musica //Creat a class
{
    //No C#, as propriedades ("regras"|"recursos") devem seguir a convenção Pascal Case>> Letra maiuscula no inicio
    //(Convenção de nomes)

    //propriedade >> get|set

    //ctrl + R + R >> renomeia em all lugares
    public string Nome { get; set; } //propriedade permite ler(get) e escrever(set), em classes externas por ser public
    //public string Nome //atributos
    public string Artista { get; set; } //propriedade
    public int Duracao { get; set; }//propriedade

    //prop + TAB >>
   /* public string DescricaoResumida 
    {
        get //propriedade só permite LEITURA (get), nega a escrita (set).
        {
            return $"A música {Nome} pertence a banda {Artista}";
        }
     }*/

    public string DescricaoResumida => //GET (LAMBDA) >> arrow function (função de seta)
        $"A música {Nome} pertence a banda {Artista}"; 

    //set - escreve 
    //get - lê

    public bool Disponivel { get; set; } //atributo | public - dispinivel para classes extrenas 
                                         //privado - so acessa dentro das chaves 

    /*
    public void EscreveDisponivel(bool value)
    {
        disponivel = value;
    }    

    public bool LerDisponivel()
    {
        return disponivel;
    }
    */

    public void ExibirFichaTecnica()//Creat a method - "função" (comportamento para os atributos)
    {
        //ATALHO >> cw + TAB = Write >> Console.WriteLine();
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Duração: {Duracao}");
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
