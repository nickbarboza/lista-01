Console.Write("Informe o valor total da compra: ");
double valor = double.Parse(Console.ReadLine());

double desconto = 0;

if (valor >= 200)
{
    desconto = valor * 0.10;
}

double valorFinal = valor - desconto;

Console.WriteLine($"Valor original: R$ {valor:F2}");
Console.WriteLine($"Desconto aplicado: R$ {desconto:F2}");
Console.WriteLine($"Valor final: R$ {valorFinal:F2}");