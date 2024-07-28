namespace Sistema_de_Estacionamento.Models {
    public class Estacionamento {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estaciomanento(decimal percoInicial, decimal precoPorHora) {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
    }

        public vois AdicionarVeiculo() {
            Console.WriteLine("Digite a placa do veículo para estacionar: ");
            string placa = Console.ReadLine().ToUpper();
            veiculos.Add(placa);
    }

        public void RemoverVeiculo() {
            Console.WriteLine("Digite a placa do veículo para remover:");
              string placa = Console.ReadLine().ToUpper();

            if (veiculos.Any(x = > x.ToUpper() == placa.ToUpper())) {
                ConsoleWrite($"Digite a quantiddade de horas que o veículo permaneceu estacionado:");

                int horas = int.Parse(Console.ReadLIne());
                decimal valorTotal = percoInicial + precoPorHoras * horas'

                veiculos.Remover(placa);
                Console.WriteLine($"Oveículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
             else
                 Console.WriteLine("Veículo não encontrado. Confira se digitou a placa corretamente")'
                 
        }
    public void ListarVeiculos() {
        if (veiculos.any()) {
            Console.WriteLine("Os veículos estacionados são: ");

            foreach (string placa in veiculos) {
                Console.WriteLine(placa);
            }
    }
        else
            Console.WriteLine("Não há veículos estacionados.")
        }
    }

}
