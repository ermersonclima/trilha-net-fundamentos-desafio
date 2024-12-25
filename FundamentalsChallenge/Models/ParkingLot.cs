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
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string vehiclePlate = Console.ReadLine().ToUpper();
            if (!vehicles.Contains(vehiclePlate))
            {
                vehicles.Add(vehiclePlate);
                Console.WriteLine("Veículo estacionado e registrado.");
            }
            else
            {
                Console.WriteLine("Veículo já está estacionado.");
            }
        }

        public void RemoveVehicle()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            string vehiclePlate = Console.ReadLine().ToUpper();

            if (vehicles.Contains(vehiclePlate))
            {
                bool isHoursParkedValid = false;
                do
                {
                    Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                    string hoursParked = Console.ReadLine();

                    if (decimal.TryParse(hoursParked, out decimal parsedHoursParked))
                    {
                        decimal totalPrice = this.startingPrice + this.perHourPrice * parsedHoursParked;
                        vehicles.Remove(vehiclePlate);
                        isHoursParkedValid = true;

                        Console.WriteLine($"O veículo {vehiclePlate} foi removido e o preço total foi de: R$ {totalPrice}.");
                    }
                    else
                    {
                        Console.WriteLine("A quantidade de horas digitadas não é válida. Tente novamente inserindo um valor válido.");
                    }
                } while (!isHoursParkedValid);
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente.");
            }
        }

        public void ListVehicles()
        {
            if (vehicles.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                foreach (string vehicle in vehicles)
                {
                    Console.WriteLine(vehicle);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
