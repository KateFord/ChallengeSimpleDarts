using Darts;
using System;

namespace ChallengeSimpleDarts
{
    public class Game
    {

        private Player player1;
        private Player player2;

        private Random _random;

        public Game(string player1Name, string player2Name)
        {
            player1 = new Player();
            player1.Name = player1Name;

            player2 = new Player();
            player2.Name = player2Name;

            _random = new Random();

        }

        private void turn(Player player)
        {
            for (int i = 0; i <= 3; i++)
            {

                Dart dart = new Dart(_random);
                dart.Throw();
                Score.CalculateDartScore(player, dart);
                Console.WriteLine(player.Name, dart.Score.ToString(), dart.Band, player.Score);
            }
        }

        public string Play()
        {
            while (player1.Score < 300 && player2.Score < 300)
            {
                turn(player1);
                turn(player2);
            }

            return DisplayResults();
        }

         public string DisplayResults()
        {
           string result = String.Format("{0}:  {1}  {2}: {3} ...  ", player1.Name, player1.Score, player2.Name, player2.Score);
            return result +=  (player1.Score > player2.Score ? " " + player1.Name + " is the winner!" : " " + player2.Name + " is the winner!");
        }

    }
}