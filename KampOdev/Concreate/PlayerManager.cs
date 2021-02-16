using KampOdev.Abstract;
using KampOdev.Concreate;
using System;
using System.Collections.Generic;
using System.Text;

namespace KampOdev
{
    public class PlayerManager : IPlayerManager
    {
        IUserValidationService _userValidationService;
       
        public PlayerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService; 
        }



        public void AddPlayer(Player player)
        {

            if (_userValidationService.Validation(player) == true)
            {
                Console.WriteLine("User validated.");
                Console.WriteLine(player.Nick + " Added.");
            }
            else
            {
                Console.WriteLine("User couldn't validated");
            }
        }
      
        public void DeletePlayer(Player player)
        {
            Console.WriteLine(player.Nick + " Deleted.");
        }

        public void UpdatePlayer(Player player)
        {
            Console.WriteLine(player.Nick + " Updated.");
        }
    }
}
