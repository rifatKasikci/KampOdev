using KampOdev.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace KampOdev.Abstract
{
    public interface ISaleManager
    {
        void Saleing(Player player,Game game,Campaign campaign);

        void Returnin(Player player, Game game, Campaign campaign);
        
    }
}
