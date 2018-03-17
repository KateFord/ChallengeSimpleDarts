using Darts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChallengeSimpleDarts
{
    public class Score
    {

        public static void CalculateDartScore(Player player,Dart dart)
        {
            if (dart.Band == "triple" && dart.Score == 0) player.Score += 50;
            else if (dart.Band == "double" && dart.Score == 0) player.Score += 25;
            else if (dart.Band == "triple") player.Score += dart.Score * 3;
            else if (dart.Band == "double") player.Score += dart.Score * 2;
            else player.Score += dart.Score;
        }

    }
}