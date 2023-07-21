class Veiculo
{
    public string Placa { get; set; }
    public string Modelo { get; set; }
    public string Marca { get; set; }
    public DateTime HoraEntrada { get; set; }
    public DateTime HoraSaida { get; set; }
}

class Estacionamento
{
    private List<Veiculo> veiculosEstacionados;

    public Estacionamento()
    {
        veiculosEstacionados = new List<Veiculo>();
    }

    public void AdicionarVeiculo(Veiculo veiculo)
    {
        veiculosEstacionados.Add(veiculo);
        Console.WriteLine("Veículo adicionado ao estacionamento.");
    }

    public void RemoverVeiculo(string placa, DateTime horaSaida)
    {
        Veiculo veiculoRemovido = veiculosEstacionados.Find(v => v.Placa == placa);

        if (veiculoRemovido != null)
        {
            veiculoRemovido.HoraSaida = horaSaida;
            TimeSpan tempoEstacionado = veiculoRemovido.HoraSaida - veiculoRemovido.HoraEntrada;
            double valorCobrado = CalcularValorEstacionamento(tempoEstacionado);
            Console.WriteLine($"Veículo removido do estacionamento. Valor cobrado: R$ {valorCobrado:F2}");
            veiculosEstacionados.Remove(veiculoRemovido);
        }
        else
        {
            Console.WriteLine("Veículo não encontrado no estacionamento.");
        }
    }

    public void ListarVeiculos()
    {
        Console.WriteLine("Veículos estacionados:");

        foreach (var veiculo in veiculosEstacionados)
        {
            Console.WriteLine($"Placa: {veiculo.Placa}, Modelo: {veiculo.Modelo}, Marca: {veiculo.Marca}, Hora de Entrada: {veiculo.HoraEntrada}");
        }
    }

    private double CalcularValorEstacionamento(TimeSpan tempoEstacionado)
    {
        // Implemente aqui a lógica para calcular o valor cobrado durante o período de estacionamento
        // Pode ser por hora, por fração de tempo ou outra regra específica do estacionamento.
        // Neste exemplo, assumimos um valor fixo de R$ 2,00 por hora estacionada.
        double valorPorHora = 2.0;
        double horasEstacionadas = tempoEstacionado.TotalHours;
        double valorCobrado = horasEstacionadas * valorPorHora;
        return valorCobrado;
    }
}

class Program
{
    static void Main()
    {
        Estacionamento estacionamento = new Estacionamento();

        while (true)
        {
            Console.WriteLine("=== Menu ===");
            Console.WriteLine("1 - Adicionar Veículo");
            Console.WriteLine("2 - Remover Veículo");
            Console.WriteLine("3 - Listar Veículos");
            Console.WriteLine("0 - Sair");
            Console.Write("Opção: ");
            int opcao = int.Parse(Console.ReadLine());

            if (opcao == 1)
            {
                Veiculo novoVeiculo = new Veiculo();
                Console.WriteLine("Digite a Placa:");
                novoVeiculo.Placa = Console.ReadLine();
                Console.WriteLine("Digite o Modelo:");
                novoVeiculo.Modelo = Console.ReadLine();
                Console.WriteLine("Digite a Marca:");
                novoVeiculo.Marca = Console.ReadLine();
                novoVeiculo.HoraEntrada = DateTime.Now;
                estacionamento.AdicionarVeiculo(novoVeiculo);
            }
            else if (opcao == 2)
            {
                Console.WriteLine("Digite a Placa do Veículo a ser removido:");
                string placaRemover = Console.ReadLine();
                Console.WriteLine("Digite a Hora de Saída (formato: dd/MM/yyyy HH:mm):");
                DateTime horaSaida = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", null);
                estacionamento.RemoverVeiculo(placaRemover, horaSaida);
            }
            else if (opcao == 3)
            {
                estacionamento.ListarVeiculos();
            }
            else if (opcao == 0)
            {
                break;
            }
            else
            {
                Console.WriteLine("Opção inválida. Tente novamente.");
            }
        }

        Console.WriteLine("Programa encerrado.");
    }
}
