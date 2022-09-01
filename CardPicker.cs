using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickACard
{
     class CardPicker
     {
        static Random random = new Random();
        public static string[] PickACard(int numberOfCards)
        {
            string[] pickedCards = new string[numberOfCards];
            for (int i = 0; i < numberOfCards; i++) 
            {
                pickedCards[i] = randomValue() + " " + RandomSuit();
            }
            return pickedCards;
        }

        private static string RandomSuit()
        {
            int value = random.Next(1, 5);
            if (value == 1) return "karo";
            if (value == 2) return "kier";
            if (value == 3) return "pik";
            else return "trefl";
        }

        private static string randomValue()
        {
            int value = random.Next(1, 14);
            if (value == 1) return "as";
            if (value == 11) return "valet";
            if (value == 12) return "dama";
            if (value == 13) return "król";
            else return value.ToString();
        }
    }
}
