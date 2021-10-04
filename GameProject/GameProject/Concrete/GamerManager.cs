using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class GamerManager : IGamerService
    {
        public void Add(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " isimli oyuncu  eklenmiştir.");
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " isimli oyuncu  silinmiştir.");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " isimli oyuncu güncellenmiştir.");
        }

        public static implicit operator GamerManager(GameManager v)
        {
            throw new NotImplementedException();
        }
    }
}
