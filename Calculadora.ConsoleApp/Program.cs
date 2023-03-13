using System.Globalization;

namespace Calculadora.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Boolean verificar = true;
            string[] v = new string[20];
            int i = 0;
            double x = 0, y = 0;
            while (verificar == true)
            {                
                Console.WriteLine("Digite o tipo da operação: \n 1-Soma \n 2-Subtração \n 3-Multiplicação \n 4-Divisão \n 5-Tabuada");
                int operacao = int.Parse(Console.ReadLine());

                double resultado = 0;
                double resultadoF = 0;

                if (operacao == 1)
                {
                    Console.WriteLine("\nDigite o primeiro numero: ");
                    x = double.Parse(Console.ReadLine());

                    Console.WriteLine("Digite o segundo numero: ");
                    y = double.Parse(Console.ReadLine());

                    resultado = x + y;
                    Console.WriteLine(resultado);
                }
                else if (operacao == 2)
                {
                    Console.WriteLine("\nDigite o primeiro numero: ");
                    x = double.Parse(Console.ReadLine());

                    Console.WriteLine("Digite o segundo numero: ");
                    y = double.Parse(Console.ReadLine());

                    resultado = x - y;
                    Console.WriteLine(resultado);
                }
                else if (operacao == 3)
                {
                    Console.WriteLine("\nDigite o primeiro numero: ");
                    x = double.Parse(Console.ReadLine());

                    Console.WriteLine("Digite o segundo numero: ");
                    y = double.Parse(Console.ReadLine());

                    resultado = x * y;
                    Console.WriteLine(resultado);
                }
                else if(operacao == 4)
                {
                    Console.WriteLine("\nDigite o primeiro numero: ");
                    x = double.Parse(Console.ReadLine());

                    Console.WriteLine("Digite o segundo numero: ");
                    y = double.Parse(Console.ReadLine());

                    while (y == 0)
                    {
                        Console.WriteLine("Não é possivel dividir um numero por 0");
                        Console.WriteLine("Digite novamente o segundo numero: ");
                        y = double.Parse(Console.ReadLine());
                    }
                    resultado = x / y;
                    resultadoF = Math.Round(resultado, 2);
                    Console.WriteLine(resultadoF);
                }
                else if(operacao == 5)
                {
                    Console.WriteLine("\nDigite o numero: ");
                    x = double.Parse(Console.ReadLine());

                    for (int j = 0; j <= 10; j++)
                    {
                        Console.WriteLine(j + " * " + x + "= " + (x*j));
                    }
                }
                string textX = Convert.ToString(x);
                string textY = Convert.ToString(y);
                if(operacao == 4)
                {
                    string textRF = Convert.ToString(resultadoF);
                    v[i] = (textX + " + " + textY + "= " + textRF);
                }
                else
                {
                    string textR = Convert.ToString(resultado);
                    v[i] = (textX + " + " + textY + "= " + textR);
                }                                
                i++;
                Console.WriteLine("Deseja continuar com contas(true/false): ");
                verificar = Boolean.Parse(Console.ReadLine());
            }
            Console.Clear();
            Console.WriteLine("Histórico:");
            for(int j = 0; j < v.Length; j++)
            {
                Console.WriteLine(v[j]);
            }
        }
    }
}