// See https://aka.ms/new-console-template for more information

int numero, antecessor, sucessor;

//Entrada de dados
Console.WriteLine("Digite um numero inteiro");
numero=int.Parse(Console.ReadLine());

//Processamento
antecessor = numero - 1;
sucessor = numero + 1;

//Saída de dados
Console.WriteLine("O antecessor de "+numero+" é " +antecessor+"");
