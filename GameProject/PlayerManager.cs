using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class PlayerManager
    {
        public void Add(Player player)
        {
            Console.WriteLine("Yeni kullanıcı eklendi. Nicki: " + player.NickName + ". Adı: " + player.FirstName + " " + player.LastName);
        }

        public void Update(Player player)
        {
            Console.WriteLine("Kullanıcı bilgileri güncellendi: " + player.NickName + player.FirstName + player.LastName);
        }
        public void Delete(Player player)
        {
            Console.WriteLine(player.NickName + " nickli " + player.FirstName + " " + player.LastName + " adlı kullanıcı silindi." );
        }
    }
}
