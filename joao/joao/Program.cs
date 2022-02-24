using System;



namespace joao
{
    class Program
    {
        static void Main(string[] args)
        {
            double primeiroNumero = 0;
            double segundoNumero = 0;
            double recebeSoma = 0;
            double recebeSubtração = 0;
            double recebeMultiplicaçao = 0;
            double recebeDivisão = 0;
            Console.WriteLine("Programa calculadora...\nDigite o primeiro número");
            primeiroNumero = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número..");
            segundoNumero = double.Parse(Console.ReadLine());

            recebeSoma = primeiroNumero + segundoNumero;
            recebeSubtração = primeiroNumero - segundoNumero;
            recebeMultiplicaçao = primeiroNumero * segundoNumero;
            recebeDivisão = primeiroNumero / segundoNumero;
            Console.WriteLine("A Soma do seu número digitado é {0}....", recebeSoma);
            Console.WriteLine("A Subtração do seu número digitado é {0}....", recebeSubtração);
            Console.WriteLine("A Multiplicação do seu número digitado é {0}....", recebeMultiplicaçao);
            Console.WriteLine("A Divisão do seu número digitado é {0}....", recebeDivisão);





        }
    }
}