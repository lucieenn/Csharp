using System;
var vet = new int[10];
int par = 0, impar = 0, soma = 0, maior = 0, menor = 0;
double media =0, raiz = 0, divisao = 0;


for (int i = 0; i < 10; i++)
{
    Console.Write("Digite o número da {0}° : ", i);
    vet[i] = int.Parse(Console.ReadLine());

    if (vet[i] % 2 == 0)
    {
        par = par + 1;

    }

    else
    {
        impar = impar + 1;
    }
    if (maior < vet[i])
    {
        maior = vet[i];
    }
    if (menor > vet[i])
    {
        menor = vet[i];
    }
    if (vet[4] > vet[10])
    { 
        divisao = vet[4] / vet[10];
    }
    soma = soma + vet[i];
    media = soma /2;
    raiz = Math.Sqrt(vet[3]);
   
}

Console.WriteLine("A quantidade de pares é:{0}\n a quantidade ímpares é:{1}  ", par, impar);
Console.WriteLine("A média dos números é: "+ media);
Console.WriteLine("O maior número é: " + maior);
Console.WriteLine("O menor número é: " + menor);
Console.WriteLine("A raiz quadrada da 4° posição é: " + raiz);
Console.WriteLine("A divisão da 3° posição com a 9° é: " + divisao);
