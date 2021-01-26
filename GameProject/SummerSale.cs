using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class SummerSale:ICampaign
    {
        public void Add(Game game)
        {
            Console.WriteLine("Yaz indirimi " + game.GameName + " oyununa eklendi.");
        }

        public void Delete(Game game)
        {
            Console.WriteLine("Yaz indirimi " + game.GameName + " oyunundan silindi.");
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.GameName + " oyununun fiyatı yaz indirimi ile güncellendi. Yeni fiyat: ", game.GamePrice - 15);
        }
    }
}
