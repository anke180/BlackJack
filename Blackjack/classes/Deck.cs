using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack.classes
{
    public class Deck
    {
        List<Card> cards = new List<Card>();

        public Deck()
        {
            // Create 52 unique cards without img
            foreach (Suits suits in Enum.GetValues(typeof(Suits)))
            {
                foreach (FaceValues faceValue in Enum.GetValues(typeof(FaceValues)))
                {
                    cards.Add(new Card(suits, faceValue));
                }
            }
        }

        public void Shuffle()
        {
            Random rnd = new Random();

            int cardLength = cards.Count();
            while(cardLength > 1)
            {
                int randomize = rnd.Next(cardLength--);
                Card temp = cards[cardLength];
                cards[cardLength] = cards[randomize];
                cards[randomize] = temp;
            }
        }
    }
}