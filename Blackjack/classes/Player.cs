using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack.classes
{
    public class Player
    {
        Hand hand = new Hand();
        System.Windows.Forms.Label label;

        public Player(System.Windows.Forms.Label label)
        {
            this.label = label;
        }

        public void recieveCard(Card card)
        {
            this.label.Text = card.ToString();
        }
    }
}