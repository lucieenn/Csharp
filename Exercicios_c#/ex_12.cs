/*construa um algoritmo que, dados os comprimentos dos três lados (A, B e C) de um triângulo, verifique o tipo de triângulo formado. Apresentar qual é o tipo.
 
***** Verificar se os lados formam ou não um triângulo ***** Por exemplo: os lados 1, 2 e 34 não formam um triângulo
 
Sabe-se que:

- Triângulo do tipo Equilátero – possui os três lados iguais
- Triangulo do tipo Isósceles – possui dois lados iguais
- Triângulo do tipo Escaleno – possui os três lados diferentes */

double a, b, c;

//Entrada de dados 
Console.WriteLine("Digite o lado A do triangulo: ");
a= double.Parse(Console.ReadLine());
Console.WriteLine("Digite o lado B do triangulo: ");
b= double.Parse(Console.ReadLine());
Console.WriteLine("Digite o lado C (base) do triangulo: ");
c= double.Parse(Console.ReadLine());

//Processamento
if(a > c && b>c) {
    Console.WriteLine("Isso não é um triangulo seu lixo");
        }
else if(a==b && a==c)
{
    Console.WriteLine("O triângulo é do tipo Equilátero");
}

else if(a==b || b==c || a==c)
{
    Console.WriteLine("O triângulo é do tipo Isósceles");
}
else{
    Console.WriteLine("O triângulo é do tipo Escaleno");
}
  