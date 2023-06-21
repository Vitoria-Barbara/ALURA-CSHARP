class Musica //Creat a class
{
    public string nome; //atributos
    public string artista; //atributos
    public int duracao;//atributos
    public bool disponivel; //atributos

    public void ExibirFichaTecnica()//Creat a method - "função" (comportamento para os atributos)
    {
        //ATALHO >> cw + TAB = Write >> Console.WriteLine();
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Artista: {artista}");
        Console.WriteLine($"Duração: {duracao}");
        if (disponivel) 
        {
            Console.WriteLine("Disponivel no plano.\n");
        }
        else
        {
            Console.WriteLine("Adquira o plano Plus+\n");
        }
    }
}
