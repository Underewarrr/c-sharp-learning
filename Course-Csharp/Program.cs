// Tipos
// int, float, double, string, bool, char, byte, short, long, decimal

Console.Write("Digite Uma String: ");

string csharp = Console.ReadLine();

Console.WriteLine($"Sua String {csharp}. Informações: ");

Console.WriteLine($"Possui {csharp.Length} caracteres.");
Console.WriteLine($"O Primeiro Caracter É {csharp[0]}.");
Console.WriteLine($"O Último Caracter É {csharp[csharp.Length - 1]}.");

if (csharp.Length % 2 == 0)
{
    Console.WriteLine("O Número É PAR.");
}
else
{
    Console.WriteLine("O Número É IMPAR.");
}

if (csharp.Length % 3 == 0)
{
    Console.WriteLine("O Número É MÚLTIPLO DE 3.");
}
else
{
    Console.WriteLine("O Número NÃO É MÚLTIPLO DE 3.");
}


