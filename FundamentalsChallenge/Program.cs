using FundamentalsChallenge.Models;

Console.OutputEncoding = System.Text.Encoding.UTF8;

bool isParseableToDecimal(string input)
{
    decimal result;
    return decimal.TryParse(input, out result);
}

Console.WriteLine("Seja bem vindo ao sistema de estacionamento!\n" +
                  "Digite o preço inicial:");
string startingPriceInput = Console.ReadLine();

if (!isParseableToDecimal(startingPriceInput))
{
    Console.WriteLine("O valor digitado não é válido. Encerrando programa.");
    Environment.Exit(0);
}
decimal startingPrice = Convert.ToDecimal(startingPriceInput);

Console.WriteLine("Agora digite o preço por hora:");
string perHourPriceInput = Console.ReadLine();

if (!isParseableToDecimal(perHourPriceInput))
{
    Console.WriteLine("O valor digitado não é válido. Encerrando programa.");
    Environment.Exit(0);
}
decimal perHourPrice = Convert.ToDecimal(perHourPriceInput);

ParkingLot parkingLot = new ParkingLot(startingPrice, perHourPrice);

string selectedOption = string.Empty;
bool hasToShowMenu = true;

while (hasToShowMenu)
{
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar veículo");
    Console.WriteLine("2 - Remover veículo");
    Console.WriteLine("3 - Listar veículos");
    Console.WriteLine("4 - Encerrar");

    switch (Console.ReadLine())
    {
        case "1":
            parkingLot.AddVehicle();
            break;

        case "2":
            parkingLot.RemoveVehicle();
            break;

        case "3":
            parkingLot.ListVehicles();
            break;

        case "4":
            hasToShowMenu = false;
            break;

        default:
            Console.WriteLine("Opção inválida.");
            break;
    }

    Console.WriteLine("Pressione uma tecla para continuar.");
}

Console.WriteLine("O programa se encerrou.");
