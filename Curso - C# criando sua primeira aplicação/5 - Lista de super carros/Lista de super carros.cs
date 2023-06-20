Dictionary<string, List<int>> vendasCarros = new Dictionary<string, List<int>> {
    { "Bugatti Veyron", new List<int> { 10, 15, 12, 8, 5 } },
    { "Koenigsegg Agera RS", new List<int> { 2, 3, 5, 6, 7 } },
    { "Lamborghini Aventador", new List<int> { 20, 18, 22, 24, 16 } },
    { "Pagani Huayra", new List<int> { 4, 5, 6, 5, 4 } },
    { "Ferrari LaFerrari", new List<int> { 7, 6, 5, 8, 10 } }
};

/*Com base na lista de super carros fornecida acima, onde a chave é o nome do carro e os valores
* são quantas vezes esse carro foi vendido por ano, calcule a média de uma chave específica.*/

/*List<int> notasPythonMaria = notasAlunos["Maria"]["Python"];
double mediaMariaEmPython = notasPythonMaria.Average();//calcula a média
Console.WriteLine(mediaMariaEmPython);*/

/*List<int> vendas = vendasCarros["Bugatti Veyron"];
double media = vendas.Average();
Console.WriteLine(media);*/

double mediaVendasBugatti = vendasCarros["Bugatti Veyron"].Average();
Console.WriteLine("Média de vendas do Bugatti Veyron: " + mediaVendasBugatti);
