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
            while (verificar == true)
            {
                Console.WriteLine("\nDigite o primeiro numero: ");
                double x = double.Parse(Console.ReadLine());

                Console.WriteLine("Digite o segundo numero: ");
                double y = double.Parse(Console.ReadLine());

                Console.WriteLine("Digite o tipo da operação: \n 1-Soma \n 2-Subtração \n 3-Multiplicação \n 4-Divisão");
                string operacao = Console.ReadLine();

                double resultado = 0;
                double resultadoF = 0;

                if (operacao.Equals("Soma", StringComparison.InvariantCultureIgnoreCase))
                {
                    resultado = x + y;
                    Console.WriteLine(resultado);
                }
                else if (operacao.Equals("Subtraçao", StringComparison.InvariantCultureIgnoreCase))
                {
                    resultado = x - y;
                    Console.WriteLine(resultado);
                }
                else if (operacao.Equals("Multiplicaçao", StringComparison.InvariantCultureIgnoreCase))
                {
                    resultado = x * y;
                    Console.WriteLine(resultado);
                }
                else if(operacao.Equals("Divisao", StringComparison.InvariantCultureIgnoreCase))
                {
                    while(y == 0)
                    {
                        Console.WriteLine("Não é possivel dividir um numero por 0");
                        Console.WriteLine("Digite novamente o segundo numero: ");
                        y = double.Parse(Console.ReadLine());
                    }
                    resultado = x / y;
                    resultadoF = Math.Round(resultado, 2);
                    Console.WriteLine(resultadoF);
                }
                string textX = Convert.ToString(x);
                string textY = Convert.ToString(y);
                if(operacao.Equals("Divisao", StringComparison.InvariantCultureIgnoreCase))
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