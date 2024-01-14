using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Escolha uma operação:");
        Console.WriteLine("1 - Somar");
        Console.WriteLine("2 - Subtrair");
        Console.WriteLine("3 - Multiplicar");
        Console.WriteLine("4 - Dividir");

        int operacao = int.Parse(Console.ReadLine());

        Console.WriteLine("Escolha o primeiro número:");
        int num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Escolha o segundo número:");
        int num2 = int.Parse(Console.ReadLine());

        int resultado = 0;

        switch (operacao)
        {
            case 1:
            {
                resultado = CalcularSoma(num1, num2);
                break;
            }
            case 2:
            {
                resultado = CalcularSubtracao(num1, num2);
                break;
            }
            case 3:
            {
                resultado = CalcularMultiplicacao(num1, num2);
                break;
            }
            case 4:
            {
                resultado = CalcularDivisao(num1, num2);
                break;
            }
            default:
            {
                Console.WriteLine("Opção inválida. Tente novamente.");
                break;
            }
        }

        Console.WriteLine(resultado);
    }

    public static int CalcularSoma(int num1, int num2)
    {
        int res1 = num1 + num2;
        return res1;
    }

    public static int CalcularSubtracao(int num1, int num2)
    {
        int res1 = num1 - num2;
        return res1;
    }

    public static int CalcularMultiplicacao(int num1, int num2)
    {
        int res1 = num1 * num2;
        return res1;
    }

    public static int CalcularDivisao(int num1, int num2)
    {
        int res1 = num1 / num2;
        return res1;
    }
}
