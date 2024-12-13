var a = new int[5];
var b = new int[5];
var c = new int[5];
int i;


for (i = 0; i < 5; i++)
{
    Console.WriteLine("Digite o {0}° digito A: ", i + 1);
    a[i] = int.Parse(Console.ReadLine());
}
for (i = 0; i < 5; i++)
{
    Console.WriteLine("Digite o {0}° digito B: ", i + 1);
    b[i] = int.Parse(Console.ReadLine());
}

for (i = 0; i < 5; i++)
{
    c[i] = a[i] + b[i];
    Console.WriteLine("A soma dos {0}° digitos são: {1} ", i + 1, c[i]);
}