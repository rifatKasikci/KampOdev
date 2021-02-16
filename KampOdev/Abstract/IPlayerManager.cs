using System;
using System.Collections.Generic;
using System.Text;

namespace KampOdev
{
    public interface IPlayerManager
    {
        void AddPlayer(Player player);
        void DeletePlayer(Player player);
        void UpdatePlayer(Player player);

    }
}
