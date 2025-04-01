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
        Deck deck = new Deck();
        Hand hand;
        Player[] players = new Player[2];
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
            players[0] = new Player(card1Player1,card2Player1);
            players[1] = new Player(card1Player2, card2Player2);
            hand = new Hand(firstCardDealer,secondCardDealer);
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
            Console.WriteLine("The deck is shuffled");
        }

        private void drawCards_Click(object sender, EventArgs e)
        {
            Card drawnCard = deck.DrawCard();
            textDrawnCard.Text = drawnCard.ToString();
            Console.WriteLine("You have drawn a Card");
        }

        private void natural(object sender, EventArgs e)
        {
        }

        public Card dealingCards()
        {
            Card dealingCard = deck.DrawCard();
            return dealingCard;
        }

        private void dealingCard_Click(object sender, EventArgs e)
        {
            //for loop player
            for (int i = 0; i < 2; i++)
            {
                for (int x = 0; x < 2; x++)
                {
                    Card dealingCard = dealingCards();
                    dealingCard.Flip();
                    players[i].recieveCard(dealingCard);
                }
            }
            
            //for loop hand dealer
            for (int i = 0; i < 1; i++)
            {
                Card dealingCard = dealingCards();
                dealingCard.Flip();
                hand.recieveCard(dealingCard);
            }
            Card dealingHiddenCard = dealingCards();
            hand.recieveCard(dealingHiddenCard);
            Console.WriteLine("You have dealt the cards to the players and yourself");
        }
    }
}