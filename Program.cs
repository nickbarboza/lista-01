int quantidadeClientes;
double tempoAtendimento;
double tempoTotal = 0;

Console.Write("Informe a quantidade de clientes atendidos: ");
quantidadeClientes = int.Parse(Console.ReadLine());

for (int i = 1; i <= quantidadeClientes; i++)
{
    Console.Write("Informe o tempo do atendimento: ");
    tempoAtendimento = double.Parse(Console.ReadLine());

    tempoTotal += tempoAtendimento;
}

double tempoMedio = tempoTotal / quantidadeClientes;

Console.WriteLine("Tempo total de atendimento: " + tempoTotal + " minutos");
Console.WriteLine("Tempo médio por cliente: " + tempoMedio + " minutos");