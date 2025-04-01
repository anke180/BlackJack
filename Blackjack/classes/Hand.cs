using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    }
}