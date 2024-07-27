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
            string placa = Console.ReadLine
}
