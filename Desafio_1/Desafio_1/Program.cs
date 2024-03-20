using System;

class program
{
    static void Main(string[] args)
    {
        int INDICE, SOMA, K;

        INDICE = 13;

        K = 0;

        // Chamando método para fazer o calculo da soma.
        SOMA = CalcularSoma(INDICE, K);

        Console.WriteLine($"{INDICE} É o valor do indice.\n");

        Console.WriteLine($"O valor da variável SOMA é: {SOMA}");


    }

    /*
     * MÉTODO CALCULO SOMA
     */
    static int CalcularSoma (int indice, int k)
    {
        int soma = 0;

        while (k < indice)
        {
            k++;
            soma += k;
        }
        return soma;
    }


}