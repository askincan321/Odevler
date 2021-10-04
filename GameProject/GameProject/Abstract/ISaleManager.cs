using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    interface ISaleManager
    {
        void Sale(Gamer gamer, Game game, Campaign campaing);
    }
}
