
using System.Reflection.Metadata;
using Interfaces;

namespace Services;

class PersonalComputer : IPersonalComputerService
{
    private List<Computer> computers = new List<Computer>()
    {
        new Computer("PC-1", false, 100.0f),
        new Computer("PC-2", false, 99.6f),
        new Computer("PC-3", false, 40.8f),
        new Computer("PC-4", false, 11.5f),
        new Computer("PC-5", false, 85.0f)
    };

    public List<Computer> GetAllComputers()
        => computers;

    public string Play(string player, string pc, string game)
        => $"{player} играет в {game} на {pc}";


    public string Release(string pcName)
        => $"[{pcName} свободен] ";
    

    public string Reserve(string pcName)
    {
        var pc = computers.FirstOrDefault(x => x.Name == pcName);

        if (pc != null)
        {
            if (!pc.IsBusy)
            {
                pc.IsBusy = true;
                return $"[{pcName} занят!] ";
            }
            else
            {
                return $"[{pcName} уже занят!] ";
            }
        }
        else return "ПК отсутствуют...";

    }
}


class Computer
{
    internal string Name { get; set; } = string.Empty;
    internal bool IsBusy { get; set; }
    internal float Price { get; set; }

    internal Computer(string name, bool isBusy, float price)
    {
        Name = name;
        IsBusy = isBusy;
        Price = price;
    }
}