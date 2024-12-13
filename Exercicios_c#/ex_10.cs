double numero, dia;

    //Entrada de dados
    Console.WriteLine("Digite um numero: ");
    numero = double.Parse(Console.ReadLine());

    //Processamento
    switch (numero)
     {
    case 1: 
         Console.WriteLine("Domingo");
        break;
      case 2:
        Console.WriteLine("Segunda");
        break;
      case 3:
        Console.WriteLine("Terça");
        break;
      case 4:
        Console.WriteLine("Quarta");
        break;
      case 5:
        Console.WriteLine("Quinta");
        break;
      case 6:
        Console.WriteLine("Sexta");
        break;
      case 7:
        Console.WriteLine("Sabado");
        break;
      }