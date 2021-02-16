using KampOdev.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace KampOdev
{
    public class CampaignManager : ICampaignManager
    {
        public void AddCampaign(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " campaign added.");
        }

        public void DeleteCampaign(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " campaign deleted.");
        }

        public void UpdateCampaign(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " campaign updated.");

        }
    }
}
