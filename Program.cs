using System;

public class Calculadora
{

    public static void Main(string[] args)
    {
        Console.Write("Digite o primeiro número: ");
        double a = double.Parse(Console.ReadLine()!);

        Console.Write("Digite o segundo número: ");
        double b = double.Parse(Console.ReadLine()!);

        Console.Write("Escolha a Operação: ");
        Console.Write("1 - Soma");
        Console.Write("2 - Subtração");
        Console.Write("3 - Multiplicação");
        Console.Write("4 - Divisão");

        int operação = int.Parse(Console.ReadLine());

        double resultado = 0;
        switch (operação)
        {
            case 1:
                resultado = Soma(a, b);
                break;

            case 2:
                resultado = Subtracao(a, b);
                break;

            case 3:
                resultado = Multiplicacao(a, b);
                break;

            case 4:
                resultado = Divisao(a, b);
                break;

            default:
                Console.WriteLine("Operação Inválida!");
                return;
        }

        Console.WriteLine($"Resultado: {resultado}");
    }
    public static double Soma(double a, double b)
    {
        return a + b;
    }
    public static double Subtracao(double a, double b)
    {
        return a - b;
    }
    public static double Multiplicacao(double a, double b)
    {
        return a * b;
    }
    public static double Divisao(double a, double b)
    {
        return a / b;
    }

}
