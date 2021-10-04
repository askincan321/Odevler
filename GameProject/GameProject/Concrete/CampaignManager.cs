using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class CampaignManager : ICampaignService

    {
        public void Add(Campaign campaing)
        {
            Console.WriteLine(campaing.Name + " kampanyası eklendi");
        }

        public void Delete(Campaign campaing)
        {
            Console.WriteLine(campaing.Name + " kampanyası silindi");
        }

        public void Update(Campaign campaing)
        {
            Console.WriteLine(campaing.Name + " kampanyası güncellendi");
        }
    }
}