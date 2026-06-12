Console.Write("Informe a primeira pontuação: ");
int p1 = int.Parse(Console.ReadLine());

Console.Write("Informe a segunda pontuação: ");
int p2 = int.Parse(Console.ReadLine());

Console.Write("Informe a terceira pontuação: ");
int p3 = int.Parse(Console.ReadLine());

if (p1 == p2 && p2 == p3)
{
    Console.WriteLine("As três pontuações são iguais.");
}
else
{
    int maior = p1;

    if (p2 > maior)
        maior = p2;

    if (p3 > maior)
        maior = p3;

    Console.WriteLine($"Maior pontuação: {maior}");
}