using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class WinterSale : ICampaign
    {
        public void Add(Game game)
        {
            Console.WriteLine("Kış indirimi " + game.GameName + " oyununa eklendi.");
        }

        public void Delete(Game game)
        {
            Console.WriteLine("Kış indirimi " + game.GameName + " oyunundan silindi.");
        }

        public void Update(Game game)
        {
            int new_price = game.GamePrice - 15;
            Console.WriteLine(game.GameName + " oyununun fiyatı kış indirimi ile güncellendi. Yeni fiyat: " + new_price);
        }
    }
}
