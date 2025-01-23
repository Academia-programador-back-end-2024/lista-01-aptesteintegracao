namespace Exercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             *  Substituir múltiplos de 3 pela palavra "Fizz" e múltiplos de 5 pela palavra "Buzz" na contagem de 1 a 100.
             *  Exemplo de saída: 1, 2, Fizz, 4, Buzz, Fizz, 7, 8, Fizz, Buzz, 11, Fizz, 13, 14, FizzBuzz, ...
             */

            for (int i = 1; i <= 100; i++)
            {
                bool fizz = (i % 3 == 0);
                bool buzz = (i % 5 == 0);
                bool fizzBuzz = fizz && buzz;

                string resultado = fizzBuzz ? "FizzBuzz" : buzz ? "Buzz" : fizz ? "Fizz" : i.ToString();

                Console.WriteLine(resultado);

            }
        }
    }
}
