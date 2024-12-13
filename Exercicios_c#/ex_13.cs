int contador = 0, num, somanum=0;
Double media;


//Entrada de dados
Console.WriteLine("Digite um numero: ");
num= int.Parse(Console.ReadLine());

while(num > -0)
{
    somanum = somanum + num;
    contador= contador + 1;
    Console.WriteLine("Digite um numero novamente: ");
    num=int.Parse(Console.ReadLine());
}

if(contador> -0)
{
    media= somanum/contador;
    Console.WriteLine("A media é: "+media);
}
