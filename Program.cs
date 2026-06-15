double soma = 0;

for (int i = 1; i <= 5; i++)
{
    Console.Write("Informe um valor: ");
    soma += double.Parse(Console.ReadLine());
}

double media = soma / 5;

Console.WriteLine("Soma dos valores: " + soma);
Console.WriteLine("Média dos valores: " + media);