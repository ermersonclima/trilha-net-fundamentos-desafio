namespace FundamentalsChallenge.Models
{
    public class ParkingLot
    {
        private decimal startingPrice = 0;
        private decimal perHourPrice = 0;
        private List<string> vehicles = new List<string>();

        public ParkingLot(decimal startingPrice, decimal perHourPrice)
        {
            this.startingPrice = startingPrice;
            this.perHourPrice = perHourPrice;
        }

        public void AddVehicle()
        {
            // TODO: Pedir para o usuário digitar uma placa (ReadLine) e adicionar na lista "veiculos"
            // *IMPLEMENTE AQUI*
            Console.WriteLine("Digite a placa do veículo para estacionar:");
        }

        public void RemoveVehicle()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            // Pedir para o usuário digitar a placa e armazenar na variável placa
            // *IMPLEMENTE AQUI*
            string vehiclePlate = "";

            // Verifica se o veículo existe
            if (vehicles.Any(vehicle => vehicle.ToUpper() == vehiclePlate.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                // TODO: Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
                // TODO: Realizar o seguinte cálculo: "startingPrice + perHourPrice * horas" para a variável totalPrice                
                // *IMPLEMENTE AQUI*
                int hours = 0;
                decimal totalPrice = 0; 

                // TODO: Remover a placa digitada da lista de veículos
                // *IMPLEMENTE AQUI*

                Console.WriteLine($"O veículo {vehiclePlate} foi removido e o preço total foi de: R$ {totalPrice}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListVehicles()
        {
            // Verifica se há veículos no ParkingLot
            if (vehicles.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                // TODO: Realizar um laço de repetição, exibindo os veículos estacionados
                // *IMPLEMENTE AQUI*
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
