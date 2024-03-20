using System;

class Program
{
    static void Main()
    {
        // Sequência a)
        int[] sequenciaA = { 1, 3, 5, 7 };
        int proximoElementoA = CalcularProximoElemento(sequenciaA);
        Console.WriteLine("a) Próximo elemento da sequência a): " + proximoElementoA);

        // Sequência b)
        int[] sequenciaB = { 2, 4, 8, 16, 32, 64 };
        int proximoElementoB = CalcularProximoElemento(sequenciaB);
        Console.WriteLine("b) Próximo elemento da sequência b): " + proximoElementoB);

        // Sequência c)
        int[] sequenciaC = { 0, 1, 4, 9, 16, 25, 36 };
        int proximoElementoC = CalcularProximoElemento(sequenciaC);
        Console.WriteLine("c) Próximo elemento da sequência c): " + proximoElementoC);

        // Sequência d)
        int[] sequenciaD = { 4, 16, 36, 64 };
        int proximoElementoD = CalcularProximoElemento(sequenciaD);
        Console.WriteLine("d) Próximo elemento da sequência d): " + proximoElementoD);

        // Sequência e)
        int[] sequenciaE = { 1, 1, 2, 3, 5, 8 };
        int proximoElementoE = CalcularProximoElemento(sequenciaE);
        Console.WriteLine("e) Próximo elemento da sequência e): " + proximoElementoE);

        // Sequência f)
        int[] sequenciaF = { 2, 10, 12, 16, 17, 18, 19 };
        int proximoElementoF = CalcularProximoElemento(sequenciaF);
        Console.WriteLine("f) Próximo elemento da sequência f): " + proximoElementoF);
    }


    /*
     * MÉTODO PARA CALCULAR O PRÓXIMO ELEMENTO DE UMA SEQUÊNCIA COM BASE NA LÓGICA DA SEQUÊNCIA.
     */
    static int CalcularProximoElemento(int[] sequencia)
    {
        int diferenca = sequencia[1] - sequencia[0];
        int ultimoElemento = sequencia[sequencia.Length - 1];
        int proximoElemento = ultimoElemento + diferenca;

        return proximoElemento;
    }
}

