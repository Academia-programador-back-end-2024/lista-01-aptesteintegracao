namespace Exercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             *Calcular o fatorial de um número e exibir o resultado.
             *Exemplo de entrada: Número = 5
             *Exemplo de saída: 5! = 120.
             *1= 1
             *2 = 2
             *3 = 6
             */
            Console.WriteLine("Informe o número para calculo do seu fatorial");

            int numero = Convert.ToInt32(Console.ReadLine());

            int fatorial = 1;

            for (int i = 1; i <= numero; i++)
            {
                fatorial *= i;
            }

            Console.WriteLine($"O fatorial do número {numero} é {fatorial}");
        }
    }
}
