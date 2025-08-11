using System;

class Program
{
    static void Main()
    {
        bool sucesso;
        int soma;

        // Chama o método para somar 5 inteiros
        AddInts(out soma, out sucesso);

        // Exibe o resultado
        if (sucesso)
            Console.WriteLine($"Soma bem-sucedida! Resultado: {soma}");
        else
            Console.WriteLine("Erro: entrada inválida. A soma não foi realizada.");
    }

    static void AddInts(out int resultado, out bool sucesso)
    {
        resultado = 0;
        sucesso = true;

        for (int i = 1; i <= 5; i++)
        {
            Console.Write($"Digite o {i}º número inteiro: ");
            if (int.TryParse(Console.ReadLine(), out int num))
            {
                resultado += num;
            }
            else
            {
                sucesso = false;
                resultado = 0; // zera a soma se houver erro
                return;
            }
        }
    }
}

