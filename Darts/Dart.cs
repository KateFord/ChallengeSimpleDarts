using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Darts
{
    public class Dart
    {

        // Properties
        public int Score { get; set; }
        public string Band { get; set; }

        private Random _random;
 
         //Constructor
        public Dart (Random random)
        {
            this.Score = 0;
            this.Band = "Undefined";
            this._random = random;
        }

        
        public void Throw()
        {
 
            this.Score = _random.Next(0, 21);
            int randomProbability = _random.Next(1, 101);

            // Probably would have been better to use booleans "IsTriple" and "IsDouble" as properties and check true and false
            if (randomProbability <= 5) this.Band = "triple";
            else if (randomProbability <= 10) this.Band = "double";
            else this.Band = "single";
            }
        }


}
