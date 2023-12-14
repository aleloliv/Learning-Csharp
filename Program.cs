using System;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;

namespace CalculadoraCompleta
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha a operação, adição (a), subtração (s), multiplicação (m), divisão (d), exponenciação (e), raiz (r), ou sair (sair)");
            string operacao = Console.ReadLine();
            while(operacao != "exit") 
            {
                switch (operacao)
                {
                    case "a":
                        Console.Write("Digite um número: ");
                        double aa = double.Parse(Console.ReadLine());
                        Console.Write("Digite outro número: ");
                        double ba = double.Parse(Console.ReadLine());
                        double resultadsomea = aa + ba;
                        Console.WriteLine("A soma de {0} com {1} é: {2}.", aa, ba, resultadsomea);
                        Console.WriteLine("Escolha a operação, adição (a), subtração (s), multiplicação (m), divisão (d), exponenciação (e), raiz (r), ou sair (sair)");
                        operacao= Console.ReadLine();
                        break;
                    case "s":
                        Console.Write("Digite um número: ");
                        double _as = double.Parse(Console.ReadLine());
                        Console.Write("Digite outro número: ");
                        double bs = double.Parse(Console.ReadLine());
                        double resultadosubtracao = _as - bs;
                        Console.WriteLine("A subtração de {0} por {1} é {2}.", _as, bs, resultadosubtracao);
                        Console.WriteLine("Escolha a operação, adição (a), subtração (s), multiplicação (m), divisão (d), exponenciação (e), raiz (r), ou sair (sair)");
                        operacao = Console.ReadLine();
                        break;
                    case "m":
                        Console.Write("Digite um número: ");
                        double am = double.Parse(Console.ReadLine());
                        Console.Write("Digite outro número: ");
                        double bm = double.Parse(Console.ReadLine());
                        double resultadomultiplicacao = am * bm;
                        Console.WriteLine("A multiplicação de {0} por {1} é: {2}", am, bm, resultadomultiplicacao);
                        Console.WriteLine("Escolha a operação, adição (a), subtração (s), multiplicação (m), divisão (d), exponenciação (e), raiz (r), ou sair (sair)");
                        operacao = Console.ReadLine();
                        break;
                    case "d":
                        Console.Write("Digite um número: ");
                        double ad = double.Parse(Console.ReadLine());
                        Console.Write("Digite outro número: ");
                        double bd = double.Parse(Console.ReadLine());
                        double resultadodivisao = ad / bd;
                        Console.WriteLine("A divisão de {0} por {1} é: {2}", ad, bd, resultadodivisao);
                        Console.WriteLine("Escolha a operação, adição (a), subtração (s), multiplicação (m), divisão (d), exponenciação (e), raiz (r), ou sair (sair)");
                        operacao = Console.ReadLine();
                        break;
                    case "e":
                        Console.Write("Digite um número: ");
                        double ae = double.Parse(Console.ReadLine());
                        Console.Write("Digite outro número: ");
                        double be = double.Parse(Console.ReadLine());
                        double resultadoexponenciacao = Math.Pow(ae, be);
                        Console.WriteLine("{0} elevado a {1} é igual a: {2}", ae, be, resultadoexponenciacao);
                        Console.WriteLine("Escolha a operação, adição (a), subtração (s), multiplicação (m), divisão (d), exponenciação (e), raiz (r), ou sair (sair)");
                        operacao = Console.ReadLine();
                        break;
                    case "r":
                        Console.Write("Digite um número: ");
                        double ar = double.Parse(Console.ReadLine());
                        Console.Write("Digite outro número: ");
                        double br = double.Parse(Console.ReadLine());
                        double resultadoraiz = Math.Pow(ar, (1 / br));
                        Console.WriteLine("A raiz de {0} na base {1} é: {2}", ar, br, resultadoraiz);
                        Console.WriteLine("Escolha a operação, adição (a), subtração (s), multiplicação (m), divisão (d), exponenciação (e), raiz (r), ou sair (sair)");
                        operacao = Console.ReadLine();
                        break;
                    case "sair":
                        Console.WriteLine("Obrigada!");
                        operacao = "exit";
                        break;
                }
            }

        }
    }
}