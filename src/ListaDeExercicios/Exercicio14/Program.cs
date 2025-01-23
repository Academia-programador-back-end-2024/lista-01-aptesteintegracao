namespace Exercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Imprimir a sequência de Fibonacci até um número informado.
            Exemplo de entrada: Número = 50
            Exemplo de saída: Sequência de Fibonacci até 50: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34.
             */

            int numero;

            Console.WriteLine("Entre com o ultimo valor da sequencia");

            numero = 0;

            Console.WriteLine("0");
            Console.WriteLine("1");
            int anterior = 0, atual = 1, proximo;

            for (int i = 1; i < numero; i++)
            {
                proximo = anterior + atual;
                if (proximo <= numero)
                {
                    Console.WriteLine(proximo);
                    anterior = atual;
                    atual = proximo;
                }
            }

        }
    }
}
