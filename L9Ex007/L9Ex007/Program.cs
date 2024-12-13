var idade = new int[7];
var peso = new int[7];
int soma = 0, media = 0 ;

for (int i = 0; i < 7; i++)
{
    Console.Write("Digite o {0}° idade:", i+1);
    idade[i] = int.Parse(Console.ReadLine());
    Console.Write("Digite o {0}° peso: ", i + 1);
    peso[i] = int.Parse(Console.ReadLine());

   
    if (peso[i] >= 90)
    {
        soma = soma + 1;
    }
    media = soma / 7;
}

Console.WriteLine("Há {0} pessoas com mais de 90Kg", soma);
Console.WriteLine("A médias das idades é: ", media);