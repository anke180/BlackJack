﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        Image img;

        public Suits Suit 
        { 
            get 
            {
                return suit;
            }
        }

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
    }
}
