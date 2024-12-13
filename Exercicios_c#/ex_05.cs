/* Entrar com um número e imprimir a mensagem correta: 
 é múltiplo de 3 ou não é múltiplo de 3.*/

int n1;

//Entrada de dados
Console.WriteLine("Digite um numero: ");
n1= int.Parse(Console.ReadLine());


//Processamento
if (n1 % 3 == 0)
    Console.WriteLine("O numero é multiplo de 3");

else
    Console.WriteLine("o numero NÃO é multiplo de 3");