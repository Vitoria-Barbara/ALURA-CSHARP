List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

List<int> numerosPares = numeros.FindAll(numero => numero % 2 == 0);
numerosPares.ForEach(numero => Console.WriteLine(numero));

/*
List<int> numerosPares = numeros.FindAll(BuscarNumerosQueSaoPares);

bool BuscarNumerosQueSaoPares(int numero)
{
    return numero % 2 == 0;
}

foreach (int numero in numerosPares)
{
    Console.WriteLine(numero);
}

List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
*/

//No C#, uma função lambda pode ser aplicada em atributos, propriedades ou na forma como escrevemos funções. Abaixo, existe uma função que soma 2 valores inteiros e retorna o resultado da soma, como mostra o trecho de código a seguir:
/*
public int Somar(int a, int b)
{
    int resultado = a + b;
    return resultado;
}*/

//Código refeito com este método Somar() usando uma função lambda retornando o resultado da operação.

public int Somar(int a, int b) => a + b;
