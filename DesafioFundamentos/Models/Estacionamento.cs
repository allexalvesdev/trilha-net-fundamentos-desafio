using System.Numerics;

namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            // Implementado!!!!!
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            var placa = Console.ReadLine();

            veiculos.Add(placa);
        }

        public void RemoverVeiculo()
        {
            if (veiculos.Any())
            {
                Console.WriteLine("Digite a placa do veículo para remover:");
                string placa = Console.ReadLine();

                // Verifica se o veículo existe
                var placaExiste = VerificaPlaca(placa);

                if (placaExiste)
                {
                    CalcularValorTempoEstacionamento(this.precoPorHora, this.precoInicial, placa);
                    veiculos.Remove(placa);
                }
                else
                {
                    Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados, para ser removido.");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");

                foreach (var veiculo in veiculos)
                {
                    Console.WriteLine(veiculo);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }

        private bool VerificaPlaca(string placa)
        {
            return veiculos.Any(x => x.ToUpper() == placa.ToUpper());
        }

        private void CalcularValorTempoEstacionamento(decimal precoPorHora, decimal precoInicial, string placa)
        {
            int horas = 0;
            decimal valorTotal = 0;

            Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
            horas = int.Parse(Console.ReadLine());

            valorTotal = (precoPorHora * horas) + precoInicial;
            Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
        }
    }
}
