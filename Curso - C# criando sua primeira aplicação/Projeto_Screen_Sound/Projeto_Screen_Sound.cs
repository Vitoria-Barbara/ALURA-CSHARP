//casesensitive
//Screen Sound

string mensagemDeBoasVindas = "\nBoas Vindas ao Screen Sound";
List<string> ListaDasBandas = new List<string>  { "U2", "The Beatles", "Calypson" } ;   

void ExibirLogo()
{
    //Verbatim Literal
    Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███╗░░██╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝████╗░██║████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░██╔██╗██║██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██║╚████║██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗██║░╚███║██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚═╝░░╚══╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");
    Console.WriteLine(mensagemDeBoasVindas);
}

void ExibirOpçõesDoMenu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas oa bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida =  Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumerica)
    {
        case 1 : RegistrarBandas();
            break; 
        case 2 : MostrarBandasRegistradas();
            break;
        case 3 : Console.WriteLine("Você escolheu a opção :" + opcaoEscolhidaNumerica);
            break;
        case 4 : Console.WriteLine("Você escolheu a opção :" + opcaoEscolhidaNumerica);
            break;
        case -1 : Console.WriteLine("xau xau xau");
            break;
        default: Console.WriteLine("Opção invállida");
            break;
    }

}

void RegistrarBandas() 
{
    Console.Clear();
    Console.WriteLine("**************************");
    Console.WriteLine("Registro de bandas:");
    Console.WriteLine("**************************\n");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;//nao nulo
    ListaDasBandas.Add(nomeDaBanda);
    //interpolação de string 
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpçõesDoMenu();
}

void MostrarBandasRegistradas()
{
    Console.Clear();
    Console.WriteLine("********************************************");
    Console.WriteLine("Exibindo todas as bandas Registradas:");
    Console.WriteLine("********************************************\n");
    /*for(int i = 0; i < ListaDasBandas.Count; i++ )
    {
        Console.WriteLine($"Banda: {ListaDasBandas[i]}");
    }*/

    //ForEach - para somente percorrer a lista sem usar o indice.
    foreach (string banda in ListaDasBandas)
    {
        Console.WriteLine($"Banda: {banda}");
    }


    Console.WriteLine("\nDigite uma tecla para voltar ao menu:");
    Console.ReadKey(); //qualquer tecla 
    Console.Clear();
    ExibirOpçõesDoMenu();
}

ExibirOpçõesDoMenu();