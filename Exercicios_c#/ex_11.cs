using System.Diagnostics.Tracing;

string pr1, pr2, pr3;
double p1, p2, p3;

//Entrada de dados
//p1
Console.WriteLine("Escreva o produto um: ");
pr1 = Console.ReadLine();
Console.WriteLine("Digite o seu preço: ");
p1=double.Parse(Console.ReadLine());

//p2
Console.WriteLine("Escreva o segundo produto: ");
pr2= Console.ReadLine();
Console.WriteLine("Digite o seu preço: ");
p2 = double.Parse(Console.ReadLine());

//p3
Console.WriteLine("Escreva o terceiro produto: ");
pr3= Console.ReadLine();
Console.WriteLine("Digite o seu preço: ");
p3 = double.Parse(Console.ReadLine());


//Processamento e saída de dados
if (p1 < p2)
    Console.WriteLine("O produto mais barato é o: " + pr1);
if (p1 < p3)
    Console.WriteLine("O produto mais barato é o: " + pr2);
else 
    Console.WriteLine("O produto mais é o: "+ pr3);