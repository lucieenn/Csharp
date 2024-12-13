int senha, senha1 = 12345;

//Entrada 
Console.WriteLine("Digite sua senha: ");
senha=int.Parse(Console.ReadLine());

while(senha != senha1)
{
    Console.WriteLine("Digite sua senha novamente: ");
    senha = int.Parse(Console.ReadLine());
}