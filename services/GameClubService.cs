using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Interfaces;

namespace Services;

class GameClubService : IGameClubService
{
   private readonly ICustomerService _customerService;
   private readonly IPersonalComputerService _pcService;
   private readonly IGameService _gameService;

   public GameClubService(
      ICustomerService customerService,
      IPersonalComputerService pcService,
      IGameService gameService)
   {
      _customerService = customerService;
      _pcService = pcService;
      _gameService = gameService;
   }

   public string GameProcess(int customerID, int gameID, int pcID)
   {
      var client = _customerService.GetAllCustomers()[customerID];
      var pc = _pcService.GetAllComputers()[pcID];
      var game = _gameService.GetAllGamges()[gameID];


      if (client.AmountOfMoney > pc.Price)
      {
         if (!pc.IsBusy)
         {
            _pcService.Reserve(pc.Name);
            return _pcService.Play(client.Name, pc.Name, game.Name);
         }
         else return $"{pc.Name} занят! Выберите другой.";
      }
      else
      {
         return "Недостаточно средств!\n" +
                $"{client.Name}, у вас {client.AmountOfMoney}р., а ПК стоит {pc.Price}р.";
      }
   }
   
   public string Info()
      => "Игровой клуб \"Rempage\"\nАдрес: ул. Комсомольская: 999Е";


}