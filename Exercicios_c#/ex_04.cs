/* Elabore um programa que o usuário digite a base e a altura 
  de um retângulo e exiba: área, perímetro e diagonal.*/

using System.Formats.Asn1;

int base1, altura;
double area, perimetro, diagonal;

//Entrada de dados
Console.WriteLine("Digite a base: ");
base1 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite a altura: ");
altura=int.Parse(Console.ReadLine());


//Processamento
area = base1 * altura;
perimetro = 2*(base1+altura);
diagonal = (base1+ altura) + (base1 + altura);

//Saída de dados
Console.WriteLine("A area é, " + area);
Console.WriteLine("O perimetro é " + perimetro);
Console.WriteLine("A diagonal é " + diagonal);
