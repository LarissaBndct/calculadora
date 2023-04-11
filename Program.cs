using System;
class Program
{
    static void Main(string[]arg)
    {
        Console.WriteLine("----------Operação entre dois números-----------");
        Console.WriteLine("Digite o primeiro número da operação: ");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Escolha a operação: ");
        Console.WriteLine(" A - Adição \n S - Subtração \n D - Divisão \n M - Multiplicação");
        Char operacao = Console.ReadKey(true).KeyChar;
        Console.WriteLine("Digite o segundo número da operação: ");
        double num2 = Convert.ToDouble(Console.ReadLine());
        
        double resultado = 0;

        switch(operacao)
        {
            case 'a':

            resultado = (num1 + num2);
            break;

            case 's':
            
            resultado = (num1 - num2);
            break;

            case 'd':

            resultado = (num1 / num2);
            break;

            case 'm':
            resultado = (num1 * num2);
            break;

            default:
            Console.WriteLine("Opção inválida");
            break;        
        }

        Console.WriteLine("O resultado da operação é: "+resultado);
    }
}