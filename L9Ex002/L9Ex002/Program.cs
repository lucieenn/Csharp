//Faça um programa que leia 15 números reais e armazene-os em um vetor. Em seguida:  
//Imprimir todos os elementos do vetor;
//Mostrar na tela a soma dos elementos do vetor. 
//Mostrar na tela a média dos elementos do vetor
var vetor = new int[15];
double n, s = 0, m=0;
for (int i = 0; i < 15; i++)
{
    Console.WriteLine("Digite seu {0}° numero", i +1);
    vetor[i] = int.Parse(Console.ReadLine());
    s = s + vetor[i];
    m = s / 2;
}
Console.WriteLine("A soma é: " + s);
Console.WriteLine("A média é: "+ m);