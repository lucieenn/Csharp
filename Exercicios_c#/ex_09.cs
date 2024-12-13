
int numero = 0;

//Entrada de dados
Console.WriteLine("Digite o codigo do livro: ");
numero=int.Parse(Console.ReadLine());

//Processamento
switch (numero)
{
    case 1:
        Console.WriteLine("Ficção");
        break;
    case 2:
        Console.WriteLine("Não-Ficção");
        break;
    case 3:
        Console.WriteLine("Inválido");
        break;
}