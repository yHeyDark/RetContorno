int largura, altura;

Console.WriteLine("Tamanho do Triangulo");

Console.Write("Largura(1 a 10): ");
if (!int.TryParse(Console.ReadLine(), out largura) || largura < 1 || largura > 10)
{
    Console.WriteLine("largura invalida digite um número de 1 a 10");
    return;
}

Console.Write("Altura(1 a 10): ");
if (!int.TryParse(Console.ReadLine(), out altura) || altura < 1 || largura > 10)
{
    Console.WriteLine("Altura invalida digite um número de 1 a 10");
    return;
}

for (int i = 0; i < altura; i++)
{
    for (int j = 0; j < largura; j++)
    {
        if (i == 0 || i == altura - 1 || j == 0 || j == largura - 1)
        {
            Console.Write("*");
        }

        else
        {
            Console.Write(" ");
        }
    }
    Console.WriteLine();
    }