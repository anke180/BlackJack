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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Blackjack
{
    public partial class BlackJack : Form
    {
        //Card twoOfHearts = new Card(Suits.HEARTS, FaceValues.TWO);
        Deck deck = new Deck();
        Hand hand = new Hand();
        List<Card> cards = new List<Card>();


        //State diagram nog maken + kijken bij Robert op Github hoe het zit
        //private enum GameStates
        //{
        //    START_GAME,
        //    SHUFFLE_DECK,
        //    DEAL_AT_START,
        //    CHECK_DEALER_FOR_BLACKJACK,
        //}

        public BlackJack()
        {
            InitializeComponent();
            //twoOfHearts.Suit = Suits.HEARTS;
        }

        //private void handleEvent(GameStates newState)
        //{
        //    if ()
        //    {

        //    }
        //    else
        //    {
        //        points++;
        //        switch (newState)
        //        {
        //            case GameStates.SHUFFLE_DECK:
        //                deck.Shuffle();
        //                currentGameState = GameStates.SHUFFLE_DECK;
        //                break;
        //        }
        //    }
        //}

        private void shuffleButton_Click(object sender, EventArgs e)
        {
            deck.Shuffle();
            Console.WriteLine("it works!");
        }

        private void drawCards_Click(object sender, EventArgs e)
        {
            Card drawnCard = deck.DrawCard();
            textDrawnCard.Text = drawnCard.ToString();
        }

        private void natural(object sender, EventArgs e)
        {

        }

        public Card dealingCards()
        {
            Card dealingCards = deck.DrawCard();
            dealingCards.Flip();
            return dealingCards;
        }
    }
}