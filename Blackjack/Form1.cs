using Blackjack.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Blackjack
{
    public partial class BlackJack : Form
    {
        //Card twoOfHearts = new Card(Suits.HEARTS, FaceValues.TWO);
        Deck deck = new Deck();

        public BlackJack()
        {
            InitializeComponent();
            //twoOfHearts.Suit = Suits.HEARTS;
        }


        public void shuffleButton_Click(object sender, EventArgs e)
        {
            deck.Shuffle();
            Console.WriteLine("it works!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Card drawnCard = deck.DrawCard();
            textDrawnCard.Text = drawnCard.ToString();

        }
    }
}