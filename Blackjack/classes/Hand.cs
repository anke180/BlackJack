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
            //hier moeten we dus de waardes hebben van de 2 kaarten in int, want dat kunnen we gebruiken in de if 
            int totalPointsCards = 21;
            //daarna checken if de waarde van de 2 kaarten gelijk is 21 dus met een if statement
            if (totalPointsCards == 21) {
                Console.WriteLine("this player does have a natural!");
            }
            else {
                Console.WriteLine("this player does not have a natural.");
            }
        }
    }
}