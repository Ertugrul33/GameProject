using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class VerifyManager
    {
        public void Verification(Player player, User user)
        {
            if (player.TCNo == user.TCNo && player.FirstName == user.FirstName && player.LastName == user.LastName && player.YearofBirth == user.YearofBirth)
            {
                Console.WriteLine("Oyuncu bilgileri e-devlet ile doğrulandı.");
            }
            else
            {
                Console.WriteLine("Oyuncu bilgileri e-devlet ile uyuşmadı. Lütfen bilgilerinizi kontrol ediniz.");
            }
        }
    }
}
