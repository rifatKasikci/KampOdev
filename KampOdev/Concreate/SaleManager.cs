using KampOdev.Abstract;
using KampOdev.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace KampOdev.Concreate
{
    class SaleManager : ISaleManager
    {
        public void Returnin(Player player, Game game, Campaign campaign)
        {
            player.Balance -= game.GamePrice;
            Console.WriteLine(player.Nick + " bought " + game.GameName + " from the " + campaign.CampaignName + " campaign."  );
            Console.WriteLine(player.Balance + " dolars left from your balance.");
        }

        public void Saleing(Player player, Game game, Campaign campaign)
        {
            player.Balance += game.GamePrice;
            Console.WriteLine(player.Nick + " returned the " + game.GameName + ".");
            Console.WriteLine("Your balance : " + player.Balance);
            
        }
    }
}
