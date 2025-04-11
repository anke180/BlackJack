using Blackjack.classes;
using System;
using System.Windows.Forms;

namespace Blackjack
{
    public partial class BlackJack : Form
    {
        Deck deck = new Deck();
        Hand hand;
        Player[] players = new Player[2];

        private enum GameStates
        {
            SHUFFLE_DECK,
            DEAL_CARDS_AT_START,
            CHECK_PLAYER1_FOR_NATURAL,
            CHECK_PLAYER2_FOR_NATURAL,
            CHECK_DEALER_FOR_NATURAL,
        }

        int pointsDealer = 0;
        GameStates currentGameState = GameStates.SHUFFLE_DECK;

        public BlackJack()
        {
            InitializeComponent();
            players[0] = new Player(card1Player1,card2Player1);
            players[1] = new Player(card1Player2, card2Player2);
            hand = new Hand(firstCardDealer,secondCardDealer);
        }

        private void handleEvent(GameStates newState)
        {
            if (currentGameState != newState)
            {
                pointsDealer--;
            }
            else
            {
                pointsDealer++;
                switch (newState)
                {
                    case GameStates.SHUFFLE_DECK:
                        currentGameState = GameStates.DEAL_CARDS_AT_START;
                        break;
                    case GameStates.DEAL_CARDS_AT_START:
                        currentGameState = GameStates.CHECK_PLAYER1_FOR_NATURAL;
                        break;
                    case GameStates.CHECK_PLAYER1_FOR_NATURAL:
                        currentGameState = GameStates.CHECK_PLAYER2_FOR_NATURAL;
                        break;
                    //alleen als je nou meerdere keren op check natural player 2 klikt, gaan de points ++ ipv --
                }
            }
            dealerPoints.Text = pointsDealer.ToString();
        }

        private void shuffleButton_Click(object sender, EventArgs e)
        {
            handleEvent(GameStates.SHUFFLE_DECK);
            deck.Shuffle();
            Console.WriteLine("The deck is shuffled");
        }

        private void drawCards_Click(object sender, EventArgs e)
        {
            Card drawnCard = deck.DrawCard();
            textDrawnCard.Text = drawnCard.ToString();
            Console.WriteLine("You have drawn a Card");
        }

        public Card dealingCards()
        {
            Card dealingCard = deck.DrawCard();
            return dealingCard;
        }

        private void dealingCard_Click(object sender, EventArgs e)
        {
            handleEvent(GameStates.DEAL_CARDS_AT_START);
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

            //for loop hand dealer, twijfel of dit uberhaubt in een loop moet omdat dit maar 1 keer gebeurt
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

        private void checkNaturalPlayer1_Click(object sender, EventArgs e)
        {
            handleEvent(GameStates.CHECK_PLAYER1_FOR_NATURAL);
            //mag alleen als de eerste speler aan de beurt is
            players[0].checkForNatural();
        }

        private void checkNaturalPlayer2_Click(object sender, EventArgs e)
        {
            handleEvent(GameStates.CHECK_PLAYER2_FOR_NATURAL);
            //mag alleen als de tweede speler aan de beurt is
            players[1].checkForNatural();
        }

        private void checkNaturalDealer_Click(object sender, EventArgs e)
        {
            //dit moet zorgen voor een min punt, want je mag niet controleren op een natural voor de dealer
            hand.checkForNatural();
        }
    }
}