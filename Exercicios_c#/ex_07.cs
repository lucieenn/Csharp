/*Elabore um programa que leia a idade de uma pessoa e informe sua classe eleitoral: 
    Não eleitor (abaixo de 16 anos) 
    Eleitor obrigatório (entre 18 e 65 anos) 
    Eleitor facultativo (maior do que 65 anos) */

int idade;
Console.WriteLine("Digite sua idade: ");
idade = int.Parse(Console.ReadLine());

if (idade < 16)
    Console.WriteLine("Não eleitor");
else if (idade <= 65)
    Console.WriteLine("Eleitor obrigatório");
else if(idade >= 65)
    Console.WriteLine("Eleitor Facultativo");