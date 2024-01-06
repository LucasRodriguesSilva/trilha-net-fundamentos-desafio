using System.Text.RegularExpressions;

namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal _precoInicial = 0;
        private decimal _precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            _precoInicial = precoInicial;
            _precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            // Implementado!
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placaDoVeiculo = Console.ReadLine();

            // Verificar depois

            // string validacaoPlacaDoVeiculo;
            // string primeirasTresLetras = Console.ReadLine();
            // if(primeirasTresLetras = Regex.IsMatch(primeirasTresLetras, ))

            bool verificarAdicionarVeiculo = true;

            for (int i = 0; i < veiculos.Count; i++)
            {
                if (placaDoVeiculo.ToUpper() == veiculos[i].ToUpper())
                {
                    Console.WriteLine("Já existe um veículo com a mesma placa, aperte qualquer tecla para voltar ao menu inicial:");
                    Console.ReadLine();
                    verificarAdicionarVeiculo = false;
                    break;
                }
            }

            while (verificarAdicionarVeiculo)
            {
                veiculos.Add(placaDoVeiculo);
                break;
            }
            
        }

        public void RemoverVeiculo()
        {
            // Pedir para o usuário digitar a placa e armazenar na variável placa
            // Implementado!
            Console.WriteLine("Digite a placa do veículo para remover:");
            string placa = "";
            placa = Console.ReadLine();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                // Implementado!
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                // Implementado!                
                int horas = 0;
                horas = Convert.ToInt32(Console.ReadLine());
                decimal valorTotal = 0;
                valorTotal = _precoInicial + _precoPorHora * horas; 

                // Implementado!
                veiculos.Remove(placa);

                Console.WriteLine($"O veículo {placa.ToUpper()} saiu do estacionamento e o preço total foi de: R$ {valorTotal}, aperte qualquer tecla para voltar ao menu inicial:");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente, aperte qualquer tecla para voltar ao menu inicial:");
                Console.ReadLine();
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");

                // Implementado!
                foreach( string veiculosEstacionados in veiculos)
                {
                    Console.WriteLine(veiculosEstacionados.ToUpper());
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
