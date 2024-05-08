using DIO.Common.models;

Pessoa p = new Pessoa();

p.Nome = "Fernanda";
p.Idade = 21;
p.Apresentar(); 





























// using System.Diagnostics.Contracts;
// using System.Reflection.Emit;
// using System.Runtime.InteropServices;

// string opcao;
// bool menuInterativo = true;

// while(menuInterativo)
// {
//   Console.WriteLine("Digite a sua opção:");
//   Console.WriteLine("1 - Cadastrar cliente");
//   Console.WriteLine("2 - Buscar cliente");
//   Console.WriteLine("3 - Apagar cliente");
//   Console.WriteLine("4 - Encerrar");

//   opcao = Console.ReadLine();

//   switch(opcao)
//   {
//     case "1":
//     Console.WriteLine("Cadastro de cliente");
//     break;

//     case "2":
//     Console.WriteLine("Busca de cliente");
//     break;

//     case "3":
//     Console.WriteLine("Apagar cliente");
//     break;

//     case "4":
//     Console.WriteLine("Encerrar Processo");
//     menuInterativo = false;
//     break;

//     default:
//     Console.WriteLine("Opção inválida");
//     break;
//   }

// }

// Console.WriteLine("Deu certo");
















// int soma = 0,
//  numero = 0;

// do{
//   Console.WriteLine("Digite um número (0 para parar)");
//   numero =  Convert.ToInt32(Console.ReadLine());
//   soma += numero;

// }while (numero != 0);

// Console.WriteLine($"Total da soma dos números digitados é: {soma}");























// while (contador <= 10) {
//   Console.WriteLine($"{numero} x {contador} = {numero * contador}");
//   contador++;

//   if (contador == 5){
//     break;
//   }
// }