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
        Player[] players = new Player[2];


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
            players[0] = new Player(card1Player1);
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
            //dealingCards();
            Card drawnCard = deck.DrawCard();
            textDrawnCard.Text = drawnCard.ToString();
        }

        private void natural(object sender, EventArgs e)
        {

        }

        public Card dealingCards()
        {
            Card dealingCard = deck.DrawCard();
            dealingCard.Flip();
            return dealingCard;
        }

        private void dealingCard_Click(object sender, EventArgs e)
        {
            Card dealingCard = dealingCards();
            players[0].recieveCard(dealingCard);

            dealingCard = dealingCards();
            players[0].recieveCard(dealingCard);
            //card1Player1.Text = dealingCard.ToString();
            //card1Player2.Text = dealingCard.ToString();
            //firstCardDealer.Text = dealingCard.ToString();
            //card2Player1.Text = dealingCard.ToString();
            //card2Player2.Text = dealingCard.ToString();
        }
    }
}