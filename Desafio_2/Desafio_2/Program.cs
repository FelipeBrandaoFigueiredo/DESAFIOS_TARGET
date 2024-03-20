using System;

class Program
{
    static void Main()
    {
        Console.Write("Informe um número para verificar se pertence a sequência de Fibonacci: ");
        int numeroUsuario = int.Parse(Console.ReadLine());

        // Chamando método de verificação do número.
        bool verificaçãoSequencia = VerificarFibonacci(numeroUsuario);

        // Chamando o método de exibição de resultado.
        ExibirResultado(numeroUsuario, verificaçãoSequencia);

        // Chamando o método de exibição da sequência de Fibonacci
        ExibirSequenciaFibonacci(numeroUsuario);
    }


    /*
     * MÉTODO DE VERIFICAÇÃO
     */
    static bool VerificarFibonacci(int numero)
    {
        int a = 0;
        int b = 1;

        // tratamento para o número 0.
        if (numero == 0)
        {
            return true;
        }

        // Gerando a sequência de Fibonacci
        while (b <= numero)
        {
            int temp = b;
            b = a + b;
            a = temp;

            if (b == numero)
            {
                return true;
            }
        }

        return false;
    }

    /* 
     * MÉTODO DE EXIBIÇÃO DA SEQUÊNCIA DE FIBONACCI
     */

    static void ExibirSequenciaFibonacci(int numero)
    {
        int a = 0;
        int b = 1;
        Console.Write($"\nSequência de Fibonacci até {numero}: ");
        Console.Write($"\n{a} {b} ");
        while (b <= numero)
        {
            int temp = b;
            b = a + b;
            a = temp;
            if (b <= numero)
            {
                Console.Write($"{b} ");
            }
        }
        Console.WriteLine();
    }

    /*
     * MÉTODO DE EXIBIÇÃO DE VERIFICAÇÃO
     */

    static void ExibirResultado(int numero, bool verificacaoSequencia)
    {

        if (verificacaoSequencia)
        {
            Console.WriteLine("\n{0} pertence à sequência de Fibonacci.", numero);
        }
        else
        {
            Console.WriteLine("\n{0} não pertence à sequência de Fibonacci.", numero);
        }
    }
}