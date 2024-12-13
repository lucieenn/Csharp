var vetor =new int[8];
int par = 0, soma = 0, impar = 0;
for (int i = 0; i < 8; i++)
{
    Console.Write("Escreva seu {0}° número: " ,i+ 1);
    vetor[i] = int.Parse(Console.ReadLine());
    if (vetor[i] % 2 == 0)
    {
        par = par + 1;
    }
    else
    {
        impar = impar + 1;
    }
}
Console.WriteLine("A quantidade de números pares é: "+ par);
Console.WriteLine("A quantidade de números ímpares é: " + impar);