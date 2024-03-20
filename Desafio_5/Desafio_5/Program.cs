using System;

class Program
{
    static void Main()
    {
        // String a ser invertida
        Console.Write("Digite uma palavra/texto para que possa ser invertida: ");
        string textoOriginal = Console.ReadLine();

        // Inverter a string
        string textoInvertido = InverterString(textoOriginal);

        // Exibir a string invertida
        Console.WriteLine("\nString original: " + textoOriginal);
        Console.WriteLine("String invertida: " + textoInvertido);
    }

    /*
     * MÉTODO DE INVERSÃO DA STRING.
     */
    static string InverterString(string texto)
    {
        // Converter a string para um array de caracteres
        char[] caracteres = texto.ToCharArray();

        // Inverter os caracteres
        int comprimento = caracteres.Length;
        for (int i = 0; i < comprimento / 2; i++)
        {
            char temp = caracteres[i];
            caracteres[i] = caracteres[comprimento - 1 - i];
            caracteres[comprimento - 1 - i] = temp;
        }

        // Criar uma nova string com os caracteres invertidos
        string textoInvertido = new string(caracteres);
        return textoInvertido;
    }
}
