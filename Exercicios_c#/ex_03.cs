
int n1, n2, n3, n4;
double media;

//Entrada de dados
Console.WriteLine("Digite um numero: ");
n1=int.Parse(Console.ReadLine());
Console.WriteLine("Digite um numero: ");
n2 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite um numero: ");
n3 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite um numero: ");
n4 = int.Parse(Console.ReadLine());

//Processamento
media = (n1 + n2 + n3 + n4) / 4;

//Saída de dados
Console.WriteLine("A média dos 4 numeros é: " + media);