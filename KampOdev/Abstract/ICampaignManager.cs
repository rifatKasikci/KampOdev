using KampOdev.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace KampOdev
{
    public interface ICampaignManager
    {
        void AddCampaign(Campaign campaign);

        void DeleteCampaign(Campaign campaign);

        void UpdateCampaign(Campaign campaign);

    }
}
