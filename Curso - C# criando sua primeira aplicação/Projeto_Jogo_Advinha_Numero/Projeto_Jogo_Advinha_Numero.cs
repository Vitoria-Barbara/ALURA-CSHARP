Random aleatorio = new Random();
int numeroSecreto = aleatorio.Next(1, 101);
int numero = int.Parse( Console.ReadLine());
do
{
    Console.Write("Digite um número entre 1 e 100: ");
    int chute = int.Parse(Console.ReadLine());

    if (chute == numeroSecreto)
    {
        Console.WriteLine("Parabéns! Você acertou o número.");
        break;
    }
    else if (chute < numeroSecreto)
    {
        Console.WriteLine("O número é maior.");
    }
    else
    {
        Console.WriteLine("O número é menor.");
    }

} while (true);

Console.WriteLine("O jogo acabou. Você acertou o número secreto!");
Console.ReadKey();// espera o usuário digitar algo para fechar o console.

/*
Random aleatorio = new Random();
int numeroSecreto = aleatorio.Next(1, 101);

int numero;

Console.Write("Digite um número entre 1 e 100: ");
numero = int.Parse(Console.ReadLine());

while (numero != numeroSecreto)
{
    if (numero > numeroSecreto)
    {
        Console.WriteLine("É maior.");
    }
    else
    {
        Console.WriteLine("É menor.");
    }

    Console.Write("Digite um número entre 1 e 100: ");
    numero = int.Parse(Console.ReadLine());
}

Console.WriteLine("Parabéns! Você acertou o número secreto.");

Console.WriteLine("Pressione qualquer tecla para sair...");
Console.ReadKey();
*/