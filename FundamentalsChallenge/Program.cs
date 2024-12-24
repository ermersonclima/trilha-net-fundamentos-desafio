﻿using FundamentalsChallenge.Models;

Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal startingPrice = 0;
decimal perHourPrice = 0;

Console.WriteLine("Seja bem vindo ao sistema de estacionamento!\n" +
                  "Digite o preço inicial:");
startingPrice = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Agora digite o preço por hora:");
perHourPrice = Convert.ToDecimal(Console.ReadLine());

// Instancia a classe Estacionamento, já com os valores obtidos anteriormente
ParkingLot parkingLot = new ParkingLot(startingPrice, perHourPrice);

string selectedOption = string.Empty;
bool hasToShowMenu = true;

// Realiza o loop do menu
while (hasToShowMenu)
{
    Console.Clear();
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
            Console.WriteLine("Opção inválida");
            break;
    }

    Console.WriteLine("Pressione uma tecla para continuar");
    Console.ReadLine();
}

Console.WriteLine("O programa se encerrou");