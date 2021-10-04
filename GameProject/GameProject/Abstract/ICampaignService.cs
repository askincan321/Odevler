using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    interface ICampaignService
    {
        void Add(Campaign campaing);
        void Delete(Campaign campaing);
        void Update(Campaign campaing);
    }
}
