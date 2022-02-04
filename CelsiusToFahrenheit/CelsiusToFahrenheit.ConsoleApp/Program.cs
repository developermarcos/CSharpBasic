using System;

//• Alguns países medem temperaturas em graus Celsius, e outros em graus
//Fahrenheit. Faça umalgoritmo para ler uma temperatura Celsius e imprimi-Ia em
//Fahrenheit (pesquise como fazer estetipo de conversão).

namespace CelsiusToFahrenheit.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char encerrarSistema;
            do
            {
                Console.Write("\n ----------------------------------");
                Console.WriteLine("Escolha \n (1) Transformar Celsius em Fahrenheit. \n (2) Encerrar programa");
                encerrarSistema = Convert.ToChar(Console.ReadLine());
                if (encerrarSistema == '1')
                {
                    double idade;
                    Console.Write("informe a temperatua em Celsius: ");
                    idade = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Temperatura em graus Fahrenheit: {0}", idade * 1.8 + 32);
                }
                else if (encerrarSistema == '2')
                {
                    Console.Write("Sistema será encerrado");
                }
                else
                {
                    Console.Write("Opção não encontrada, tente novamente.");
                }
            } while (encerrarSistema != '2');
        }
    }
}
