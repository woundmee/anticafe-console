using System.Runtime.CompilerServices;
using Services;

namespace Interfaces;

interface IPersonalComputerService
{
    string Play(string player, string pc, string game);
    string Reserve(string pcName);
    string Release(string pcName);
    List<Computer> GetAllComputers();    
}