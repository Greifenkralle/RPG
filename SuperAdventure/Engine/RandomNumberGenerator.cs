using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Engine
{
    public static class RandomNumberGenerator
    {
        private static readonly RNGCryptoServiceProvider _generator = new RNGCryptoServiceProvider();

        public static int NumberBetween(int minimumValue, int maximumValue)
        {
            //Array der Länge 1 - 1 Element
            byte[] randomNumber = new byte[1];

            _generator.GetBytes(randomNumber);

            //Calculate basis of the multipler, by using the ascii value of the byte
            double asciiValueOfRandomCharacter = Convert.ToDouble(randomNumber[0]);
            double multipler = Math.Max(0, (asciiValueOfRandomCharacter / 255d) - 0.00000000001);

            //Calculate the range
            int range = maximumValue - minimumValue + 1;

            double randomValueInRange = Math.Floor(multipler * range);

            return (int)(minimumValue + randomValueInRange);
        }
    }
}
