using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class SaleManager : ISaleManager
    {
        public void Sale(Gamer gamer, Game game, Campaign campaing)
        {
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " adlı oyuncu " + game.Name + " isimli oyunu " + campaing.Name + " kampanyasını " +
                "kullanarak satın almıştır");
        }
    }
}
