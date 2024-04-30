using GameSaleProject.Abstracts;
using GameSaleProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSaleProject.Concretes
{
    public class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine(game.GameName + " İsimli Oyun Eklendi!");
        }

        public void Remove(Game game)
        { 
            Console.WriteLine(game.GameName + " İsimli Oyun Silindi");
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.GameName + " İsimli Oyun Güncellendi");
        }
    }
}
