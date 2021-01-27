using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player()
            {
                TCNo = "22222222222",
                FirstName = "Engin",
                LastName = "Demiroğ",
                NickName = "The SOLID Developer",
                YearofBirth = "1985"
            };

            User user1 = new User()
            {
                TCNo = "22222222222",
                FirstName = "Engin",
                LastName = "Demiroğ",
                YearofBirth = "1985"
            };

            Game game1 = new Game()
            {
                GameName = "Rocket League",
                GamePrice = 30
            };
            VerifyManager verifyManager = new VerifyManager();
            verifyManager.Verification(player1, user1);

            PlayerManager playerManager1 = new PlayerManager();
            playerManager1.Add(player1);

            GameManager gameManager = new GameManager();
            gameManager.Add(game1);

            ICampaign winterSale = new WinterSale();
            winterSale.Update(game1);

            GameManager gameManager1 = new GameManager();
            gameManager1.Sell(game1, player1);

            winterSale.Delete(game1);
            playerManager1.Delete(player1);
            
        }
    }
}
