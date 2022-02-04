using System;

//A imobiliária Imóbilis vende apenas terrenos retangulares. Faça um 
//algoritmo para ler as dimensões de um terreno e depois exibir a área do terreno

namespace Imobiliaria.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char opcao;
            do
            {
                Console.Write("\n ----------------------------------");
                Console.WriteLine("Escolha \n (1) Calcular area terreno. \n (2) Encerrar programa");
                opcao = Console.ReadLine()[0];
                
                if (opcao == '1')
                {
                    double areaTriangulo, Triangulo, alturaTriangulo;

                    Console.Write("Informe a base do do terreno: ");
                    Triangulo =  Convert.ToDouble(Console.ReadLine());

                    Console.Write("Informe a altura do do terreno: ");
                    alturaTriangulo =  Convert.ToDouble(Console.ReadLine());

                    areaTriangulo = Triangulo * alturaTriangulo;
                    Console.Write("A área do terreno é de: {0}", areaTriangulo.ToString());
                }else if(opcao == '2')
                {
                    Console.Write("Osistema será encerrado ");
                }
                else
                {
                    Console.Write("A opção informada não corresponde a nenhuma opção valida");
                }
                
            } while (opcao != '2');
        }
    }
}
