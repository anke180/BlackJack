namespace Blackjack.classes
{
    public enum Suits
    {
        CLUBS, 
        DIAMONDS, 
        HEARTS, 
        SPADES
    }

    public enum FaceValues
    {
        ACE = 1,
        TWO, 
        THREE,
        FOUR,
        FIVE,
        SIX,
        SEVEN,
        EIGHT,
        NINE,
        TEN, 
        JACK, 
        QUEEN,
        KING
    }

    public class Card
    {
        Suits suit;
        FaceValues faceValue;
        int value;
        bool showFaceValue = false;

        public Suits Suit { get { return suit; } }
        public int Value { get { return value; } }
        public bool ShowFaceValue { get { return showFaceValue;  } }



        public Card(Suits suit, FaceValues faceValue)
        {
            this.suit = suit;
            this.faceValue = faceValue;
            switch (faceValue)
            {
                case FaceValues.ACE:
                    this.value = 11;
                    break;

                case FaceValues.TEN:
                case FaceValues.JACK:
                case FaceValues.QUEEN:
                case FaceValues.KING:
                    this.value = 10;
                    break;

                default:
                    this.value = (int)faceValue;
                    break;
            }
        }

        public override string ToString()
        {
            if (showFaceValue == true)
            {
                return this.faceValue + " Of " + this.suit;
            }
            else
            {
                return "The value of this card is hidden";
            }
        }

        public void Flip()
        {
            showFaceValue = true;
        }
    }
}