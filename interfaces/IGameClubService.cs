using Services;

namespace Interfaces;

interface IGameClubService
{
    string Info();
    string GameProcess(int customerID, int gameID, int pcID);
}