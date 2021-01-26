using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GameManager
    {
        public void Add(Game game)
        {
            Console.WriteLine(game.GameName + " oyunu eklendi. Fiyatı: " + game.GamePrice);
        }

        public void Sell(Game game, Player player)
        {
            int new_price = game.GamePrice - 15;
            Console.WriteLine(game.GameName + " oyunu " + player.NickName + " adlı oyuncuya kış indirimi ile satıldı. Aldığı fiyat: " + new_price);
        }
    }
}
