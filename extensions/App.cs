using Services;
using Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System.Runtime.CompilerServices;
using System.ComponentModel.Design;

namespace Extensions;

static class App
{
    public static void Start()
    {
        Console.Clear();
        GameClubStart();

    }

    private static void GameClubStart()
    {
        var service = new ServiceCollection().AddService();
        var serviceProvider = service.BuildServiceProvider();

        var gameclub = serviceProvider.GetRequiredService<IGameClubService>();
        var pc = serviceProvider.GetRequiredService<IPersonalComputerService>();
        var customer = serviceProvider.GetRequiredService<ICustomerService>();
        var game = serviceProvider.GetRequiredService<IGameService>();

        Console.Write("\nРегистрация нового клиента.\nВаше имя: ");
        string newCustomer = Console.ReadLine()!;
        Console.Write("Ваш бюджет (руб): ");
        float newCustomerAmountOfMoney = float.Parse(Console.ReadLine()!);

        customer.AddNewCustomer(newCustomer, newCustomerAmountOfMoney);

        Console.WriteLine("Свободные ПК:");
        Console.WriteLine(
            string.Join(", ", pc.GetAllComputers()
                                .Where(x => !x.IsBusy)
                                .Select(x => $"{x.Name} ({x.Price}р.)")));


        Console.Write($"Выбор ПК (1-{pc.GetAllComputers().Count}): ");
        int choisePC = int.Parse(Console.ReadLine()!);

        Console.WriteLine("Доступные игры:");
        Console.WriteLine(string.Join(", ", game.GetAllGamges().Select(x => x.Name)));
        Console.Write($"Выбор игры (1-{game.GetAllGamges().Count}): ");
        int choiseGame = int.Parse(Console.ReadLine()!);

        gameclub.GameProcess(customer.GetAllCustomers().Count - 1, choiseGame, choisePC).PrintLine();
    }
}