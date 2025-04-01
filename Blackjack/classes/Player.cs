using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack.classes
{
    public class Player
    {
        Hand hand;
        public Player(System.Windows.Forms.Label label, System.Windows.Forms.Label label2)
        {
            hand = new Hand(label,label2);
        }

        public void recieveCard(Card card)
        {
            hand.recieveCard(card);
        }
    }
}