using System;
using System.Collections.Generic;

namespace Blackjack.classes
{
    public class Hand
    {
        List<Card> cards = new List<Card>();
        System.Windows.Forms.Label label;
        System.Windows.Forms.Label label2;

        public Hand(System.Windows.Forms.Label label, System.Windows.Forms.Label label2)
        {
            this.label = label;
            this.label2 = label2;
        }

        public void recieveCard(Card card)
        {
            cards.Add(card);
            this.label.Text = cards[0].ToString();
            if (cards.Count >= 2)
            {
                this.label2.Text = cards[1].ToString();
            }
        }

        public void checkForNatural()
        {
            Card firstCard = cards[0];
            Card secondCard = cards[1];

            int totalPointsCards = 21;
            int totalPointsRecievedCards = firstCard.Value + secondCard.Value;
            
            if (totalPointsRecievedCards == totalPointsCards) {
                Console.WriteLine("this player does have a natural!");
            }
            else {
                Console.WriteLine("this player does not have a natural!");
                Console.WriteLine(totalPointsRecievedCards);
            }
        }
    }
}