using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Números no intervalo [10, 20] em ordem crescente:");

        int numero = 10; // Inicializa com o primeiro número do intervalo

        while (numero <= 20) // Condição: enquanto o número for menor ou igual a 20
        {
            Console.WriteLine(numero); // Imprime o número atual
            numero++; // Incrementa para o próximo número
        }

        Console.WriteLine("Fim do intervalo.");
        Console.ReadLine(); // Para manter a janela aberta no Visual Studio
    }
}
