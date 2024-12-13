/*A Prefeitura de Santos abriu uma linha de crédito para os funcionários estatutários. 
 * O valor máximo da prestação não poderá ultrapassar 30% do salário bruto. 
  Elabore um algoritmo que o usuário digite o salárdio bruto do funcionário e o valor da prestação. 
  O programa deverá informar se o empréstimo pode ou não ser 
  concedido e qual o valor máximo da prestação para este funcionário.*/

using System.ComponentModel.Design;

double salario, trinta, prestacao;


//Entrada de dados
Console.WriteLine("Qual valor você deseja retirar? ");
prestacao = double.Parse(Console.ReadLine());
Console.WriteLine("Qual o seu salario? ");
salario = double.Parse(Console.ReadLine());

trinta = salario * 0.3;
Console.WriteLine("30% da sua renda é: " + trinta);

//Processamento
if (prestacao <= trinta)
    Console.WriteLine("Você pode retirar seu emprestimo");

else
    Console.WriteLine("Você NÃO pode retirar seu emprestimo");

