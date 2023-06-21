var notasAlunos = new Dictionary<string, Dictionary<string, List<int>>> {
    { "Ana", new Dictionary<string, List<int>> {
        { "C#", new List<int> { 8, 7, 6 } },
        { "Java", new List<int> { 7, 6, 5 } },
        { "Python", new List<int> { 9, 8, 8 } }
    }},
    { "Maria", new Dictionary<string, List<int>> {
        { "C#", new List<int> { 6, 5, 4 } },
        { "Java", new List<int> { 8, 7, 6 } },
        { "Python", new List<int> { 6, 10, 5 } }
    }},
    { "Luiza", new Dictionary<string, List<int>> {
        { "C#", new List<int> { 2, 3, 10 } },
        { "Java", new List<int> { 8, 8, 8 } },
        { "Python", new List<int> { 7, 7, 7 } }
    }}
};

/*List<int> notasPythonMaria = notasAlunos["Maria"]["Python"];*/
double mediaMariaEmPython = notasAlunos["Maria"]["Python"].Average();//calcula a média
Console.WriteLine("Media: " + mediaMariaEmPython);

foreach (var aluno in notasAlunos) // {ana ...} 
{
    Console.WriteLine($"Aluno: {aluno.Key}"); // ana
    foreach (var disciplina in aluno.Value) // Acessou o Value do primeiro dicionário, que é um dicionário com uma lista, no estilo {string, lista}
    {
        /*
        { "C#", new List<int> { 8, 7, 6 } },
        { "Java", new List<int> { 7, 6, 5 } },
        { "Python", new List<int> { 9, 8, 8 } }
         */
        Console.WriteLine($"Disciplina: {disciplina.Key}"); // C#,  Java, Python
        Console.WriteLine("Notas:"); // string notas
        foreach (var nota in disciplina.Value) // Percorre o segundo parâmetro do dicionario, que é o Value do segundo dicionário
        {
            Console.WriteLine(nota); // Exibe o Value
        }
    }
    Console.WriteLine();
}

