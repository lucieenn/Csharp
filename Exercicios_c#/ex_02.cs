// See https://aka.ms/new-console-template for more information

int n1, n2, quociente, resto ;

Console.WriteLine("Digite o primeiro numero: ");
n1= int.Parse (Console.ReadLine());

Console.WriteLine("Digite o segundo numero: ");
n2= int.Parse (Console.ReadLine());

//Processamento
quociente = n1 / n2;
resto = n1 % n2;

//Saída de dados
Console.WriteLine("O dividendo é: " + n1);
Console.WriteLine("O divisor é: "+n2);
Console.WriteLine("O quociente é " + quociente);
Console.WriteLine("O resto é: " + resto);


