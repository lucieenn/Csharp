var nome = new string[3];
var idade = new int[3];
int i;

for (i = 0 ; i < 3; i++)
{
    Console.WriteLine("Digite o {0}° nome: ", i + 1);
    nome[i] = Console.ReadLine();
}

for (i = 0; i < 3; i++)
{
    Console.WriteLine("Digite a {0}° idade: ", i + 1);
    idade[i] = int.Parse(Console.ReadLine());
}

if (idade[0] > idade[1] || idade[0] > idade[2])
    Console.WriteLine("\nO mais velho é o :{0} ", nome[0]);

else if (idade[1] > idade[0] || idade[1] > idade[2])
{
    Console.WriteLine("\nO mais velho é o :{0} ", nome[1]);
}
else if (idade[2] > idade[0] || idade[2] > idade[1])
{
    Console.WriteLine("\nO mais velho é o : ", nome[2]);
}
