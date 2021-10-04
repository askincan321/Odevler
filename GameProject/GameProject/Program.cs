using GameProject.Abstract;
using GameProject.Concrete;
using GameProject.Entities;
using System;

namespace GameProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            Game game1 = new Game() { Name = "Mortal Kombat" , Price = 40, Stock = 120 };
            Game game2 = new Game() { Name = "F1 2021", Price = 200, Stock = 320 };
            Gamer gamer1 = new Gamer() { FirstName = "Ebru", LastName = "Terzioğlu", BirthYear = 1997, NationaltyId = "919191" };
            Campaign campaign = new Campaign() { Name = "Friday sale", Discount = 20, };

            GameManager gameManager = new GameManager();
            gameManager.Add(game1);
            gameManager.Delete(game2);
            gameManager.Update(game1);

            GamerManager gamerManager = new GamerManager();
            gamerManager.Add(gamer1);
            gamerManager.Delete(gamer1);
            gamerManager.Add(gamer1);

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign);


            SaleManager saleManager = new SaleManager();
            saleManager.Sale(gamer1, game2, campaign);
        }
    }
}
