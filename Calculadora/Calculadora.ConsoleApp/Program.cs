using System;

namespace Calculadora.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char acao;
            do
            {
                Console.WriteLine("--------------------");
                Console.WriteLine("Digite:\n (1) somar \n (2) Subtrair \n (3) Multiplicar \n (4) Dividir \n (s) Sair");
                acao = Convert.ToChar(Console.ReadLine());
                if (acao == '1' || acao == '2' || acao == '3' || acao == '4')
                {
                    double primeiroValor;
                    double segundoValor;
                    double resultado = 0;
                    
                    Console.Write("Informa o primeiro valor: ");
                    primeiroValor = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Informa o segundo valor: ");
                    segundoValor = Convert.ToDouble(Console.ReadLine());
                    switch (acao)
                    {
                        case '1':
                            resultado = primeiroValor + segundoValor;
                            break;
                        case '2':
                            resultado = primeiroValor - segundoValor;
                            break;
                        case '3':
                            resultado = primeiroValor * segundoValor;
                            break;
                        case '4':
                            do{
                                if (primeiroValor == 0)
                                {
                                    Console.WriteLine("Para divisão o primeiro numero não pode ser zero: ");
                                    primeiroValor = Convert.ToDouble(Console.ReadLine());
                                }
                                else if (segundoValor == 0)
                                {
                                    Console.WriteLine("Para divisão o segundo numero não pode ser zero: ");
                                    segundoValor = Convert.ToDouble(Console.ReadLine());
                                }
                            } while (primeiroValor == 0 || segundoValor == 0) ;
                            resultado = primeiroValor / segundoValor;
                            break;
                        default:
                            Console.WriteLine("Sair");
                            break;
                    }
                    Console.WriteLine("Resultado: {0}",resultado.ToString("N2"));

                }
                else
                {
                    Console.WriteLine("Opção não encontrada, repita a ação");
                }
            } while (acao != 's');
                
        }
    }
}
