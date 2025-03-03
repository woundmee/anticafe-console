using System.Reflection;
using Interfaces;
using Microsoft.VisualBasic;

namespace Services;

class GameService : IGameService
{
    private List<Game> games = new List<Game>()
    {
        new Game("FIFA 2024", new DateOnly(2024, 10, 1)),
        new Game("Mafia 2", new DateOnly(2021, 06, 12)),
        new Game("Call of Duty", new DateOnly(2008, 05, 05)),
        new Game("Forest v2", new DateOnly(2022, 06, 24)),
        new Game("PUBG", new DateOnly(2017, 05, 10)),
    };
    public List<Game> GetAllGamges()
        => games;
}

class Game
{
    internal string Name { get; set; } = string.Empty;
    internal DateOnly YearOfIssue { get; set; }

    internal Game(string name, DateOnly yearOfIssue)
    {
        Name = name;
        YearOfIssue = yearOfIssue;
    }

}